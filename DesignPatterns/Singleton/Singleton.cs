using System;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        private readonly string myName;

        private Singleton()
        {
            myName = "Heisenberg";
        }

        public static Singleton Instance => _instance ?? (_instance = new Singleton());

        public void SayMyName()
        {
            Console.WriteLine($"{myName}.");
        }
    }
}
