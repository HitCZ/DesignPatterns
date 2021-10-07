using System;

namespace DesignPatterns.Composite
{
    /// <summary>
    /// Composite pattern represents a tree structure of objects and gives support for same method for both composite and leaf objects.
    /// </summary>
    public class CompositeSample : IPatternSample
    {
        #region Public Methods

        public void Run()
        {
            var keyboard = new FinalComponent(2000);
            var mouse = new FinalComponent(1500);
            var hdd = new FinalComponent(5000);
            var cpu = new FinalComponent(7000);
            var ram = new FinalComponent(2000);

            var mb = new CompositeComponent { Components = { cpu, ram } };
            var @case = new CompositeComponent { Components = { hdd, mb } };
            var pc = new CompositeComponent { Components = { mouse, keyboard, @case } };

            Console.WriteLine("Prices: ");
            Console.WriteLine($"{nameof(keyboard)}: {keyboard.GetPrice()}");
            Console.WriteLine($"{nameof(pc)}: {pc.GetPrice()}");
        }

        #endregion Public Methods
    }
}
