using System;

namespace DesignPatterns.Factory
{
    class ActionGuy : Person
    {
        public override void Alarm()
        {
            Console.WriteLine("Getting out of bed really fast.");
        }

        public override void ShiftEnd()
        {
            Console.WriteLine("Actively relaxing.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Pass out and fall asleep.");
        }

        public override void Work()
        {
            Console.WriteLine("Working super effectively.");
        }
    }
}
