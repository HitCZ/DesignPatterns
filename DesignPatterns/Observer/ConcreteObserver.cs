using System;

namespace DesignPatterns.Observer
{
    class ConcreteObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Subject changed");
        }
    }
}
