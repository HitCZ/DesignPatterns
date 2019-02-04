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
            var demo = new FlyWeight.Demo();
            demo.Run();

            Console.Read();
        }
    }
}
