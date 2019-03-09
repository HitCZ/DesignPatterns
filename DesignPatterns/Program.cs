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
        static void Main(string[] args)
        {
            var red = 2;
            var green = 3;
            var blue = 4;
            var color = Color.Get(red, green, blue);
            var color2 = Color.Get(red, green, blue);

            Console.Read();
        }
    }
}
