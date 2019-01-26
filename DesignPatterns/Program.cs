using DesignPatterns.Library_Class;
using DesignPatterns.NullObject;
using DesignPatterns.Original;
using DesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns {
    class Program {
        static void Main(string[] args) {
            Color blue1 = Color.Get(0, 0, 255);
            Color red1 = Color.Get(255, 0, 0);
            Color blue2 = Color.Get(0, 0, 255);

            Console.WriteLine(blue1);
            Console.Read();
        }
    }
}
