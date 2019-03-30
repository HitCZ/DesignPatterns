using DesignPatterns.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesignPatterns.State
{
    public class Player : INotifyPropertyChanged
    {
        private int health = 100;

        public IState State { get; set; } = new FullHealthState();

        public int Health
        {
            get => health;
            set
            {
                health = value;
                OnPropertyChanged(nameof(Health));
            }
        }

        public Player()
        {
            PropertyChanged += Player_PropertyChanged;
        }

        private void Player_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(Health):
                    CheckStateChange();
                    break;
            }
        }

        public void Move() => State.Move();

        private void CheckStateChange()
        {
            if (health >= 100)
                State = new FullHealthState();
            else if (health < 100 && health > 0)
                State = new HurtState();
            else 
                State = new DeadState();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
