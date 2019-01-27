using System;
using System.Linq;

namespace DesignPatterns.NullObject
{
    class CustomerFactory
    {
        public static readonly string[] Names = { "Rob", "Joe", "Julie" };

        public static AbstractCustomer GetCustomer(string name)
        {
            if (Names.Any(customerName => customerName.Equals(name, StringComparison.InvariantCulture)))
                return new RealCustomer(name);

            return new NullCustomer();
        }
    }
}
