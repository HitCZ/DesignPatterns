using System;

namespace DesignPatterns.State
{
    public class HurtState : IState
    {
        public void Move()
        {
            Console.WriteLine("Moving with a limp.");
        }
    }
}
