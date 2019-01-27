using System;

namespace DesignPatterns.Factory
{
    public abstract class Person {
        private int index;

        public Person GetPerson() {
            switch (index++ % 2) {
                case 0:
                    return new LazyGuy();
                case 1:
                    return new ActionGuy();
                default:
                    throw new Exception("Invalid maximum.");
            }
        }

        public abstract void Alarm();
        public abstract void Work();
        public abstract void ShiftEnd();
        public abstract void Sleep();

        public void Test() {
            for (var i = 1; i <= 2; i++) {
                var p = GetPerson();

                Console.WriteLine("\n=== Novy clovek: " + p.GetType().Name);
                p.Alarm();
                p.Work();
                p.ShiftEnd();
                p.Sleep();
            }
        }
       
    }
}
