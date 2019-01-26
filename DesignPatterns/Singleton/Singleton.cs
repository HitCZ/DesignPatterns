using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private Singleton instance;
        private readonly string myName;

        private Singleton()
        {
            myName = "Heisenberg";
        }

        public Singleton Instance => instance ?? (instance = new Singleton());

        public void SayMyName()
        {
            Console.WriteLine($"{myName}.");
        }
    }
}
