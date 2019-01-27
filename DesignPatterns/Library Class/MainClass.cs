using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library_Class {
    class MainClass {
        static void Main(string[] args) {
            Console.WriteLine(MathLibraryClass.Add(5, 2));
            Console.WriteLine(MathLibraryClass.Power(5));
        }
    }
}
