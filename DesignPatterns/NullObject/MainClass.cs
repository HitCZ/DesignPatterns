using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject {
    class MainClass {
        public static void Main(string[] args) {
            AbstractCustomer cust1 = CustomerFactory.GetCustomer("Rob");
            AbstractCustomer cust2 = CustomerFactory.GetCustomer("Bob");
            AbstractCustomer cust3 = CustomerFactory.GetCustomer("Julie");
            AbstractCustomer cust4 = CustomerFactory.GetCustomer("Laura");

            Console.WriteLine("Zakaznici: ");
            Console.WriteLine(cust1.GetName());
            Console.WriteLine(cust2.GetName());
            Console.WriteLine(cust3.GetName());
            Console.WriteLine(cust4.GetName());
        }
    }
}
