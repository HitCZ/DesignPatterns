using System;

namespace DesignPatterns.NullObject
{
    class MainClass {
        public static void Main(string[] args) {
            var cust1 = CustomerFactory.GetCustomer("Rob");
            var cust2 = CustomerFactory.GetCustomer("Bob");
            var cust3 = CustomerFactory.GetCustomer("Julie");
            var cust4 = CustomerFactory.GetCustomer("Laura");

            Console.WriteLine("Customers: ");
            Console.WriteLine(cust1.Name);
            Console.WriteLine(cust2.Name);
            Console.WriteLine(cust3.Name);
            Console.WriteLine(cust4.Name);
        }
    }
}
