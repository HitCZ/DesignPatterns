using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject {
    class CustomerFactory {
        public static readonly string[] names = { "Rob", "Joe", "Julie" };

        public static AbstractCustomer GetCustomer(string name) {
            for (int i = 0; i < names.Length; i++) {
                if (names[i].Equals(name, StringComparison.InvariantCultureIgnoreCase)) {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }
    }
}
