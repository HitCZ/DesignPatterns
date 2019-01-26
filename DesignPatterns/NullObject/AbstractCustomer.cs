using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject {
    abstract class AbstractCustomer {
        protected string name;

        public abstract bool IsNil();
        public abstract string GetName();
    }
}
