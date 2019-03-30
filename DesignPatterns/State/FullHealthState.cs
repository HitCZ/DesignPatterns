using System;

namespace DesignPatterns.State
{
    public class FullHealthState : IState
    {
        public void Move()
        {
            Console.WriteLine("Moving with a full speed.");
        }
    }
}
