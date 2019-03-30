using System;

namespace DesignPatterns.State
{
    public class DeadState : IState
    {
        public void Move()
        {
            Console.WriteLine("Can't move since you are dead!");
        }
    }
}
