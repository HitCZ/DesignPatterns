using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns {
    abstract class Person {
        private static int index = 0;

        public static Person GetPerson() {
            switch (index++ % 2) {
                case 0:
                    return new LazyGuy();
                case 1:
                    return new ActionGuy();
                default:
                    throw new Exception("Spatne definovane maximum");
            }
        }

        abstract public void Alarm();
        abstract public void Work();
        abstract public void ShiftEnd();
        abstract public void Sleep();


        private class LazyGuy : Person {
            public override void Alarm() {
                Console.WriteLine("Pomalu vstavam");
            }

            public override void Work() {
                Console.WriteLine("Line pracuji");
            }

            public override void Sleep() {
                Console.WriteLine("Stale spim");
            }

            public override void ShiftEnd() {
                Console.WriteLine("Odchazim spat");
            }
        }

        private class ActionGuy : Person {
            public override void Alarm() {
                Console.WriteLine("Rychle vstavam");
            }

            public override void ShiftEnd() {
                Console.WriteLine("Aktivne odpocivam");
            }

            public override void Sleep() {
                Console.WriteLine("Omdlim a spim");
            }

            public override void Work() {
                Console.WriteLine("Cile pracuji");
            }
        }


        public static void Test() {
            for (int i = 1; i <= 2; i++) {
                Person p = GetPerson();
                Console.WriteLine("\n=== Novy clovek: " + 
                    p.GetType().Name);
                p.Alarm();
                p.Work();
                p.ShiftEnd();
                p.Sleep();
            }
        }
       
    }
}
