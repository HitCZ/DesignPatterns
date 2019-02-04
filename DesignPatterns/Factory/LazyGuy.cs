using System;

namespace DesignPatterns.Factory
{
    public class LazyGuy : Person
    {
        public override void Alarm()
        {
            Console.WriteLine("I am slowly getting up.");
        }

        public override void Work()
        {
            Console.WriteLine("Working lazily.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Still asleep.");
        }

        public override void ShiftEnd()
        {
            Console.WriteLine("Going to bed.");
        }
    }
}
