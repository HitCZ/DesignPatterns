namespace DesignPatterns.State
{
    public class Enemy
    {
        public void AttackPlayer(Player p)
        {
            var damage = 50;
            p.Health -= damage;
        }
    }
}
