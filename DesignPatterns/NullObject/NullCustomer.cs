using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject {
    class NullCustomer : AbstractCustomer {
        public override string GetName() {
            return "Nenalezen v databazi zakazniku.";
        }

        public override bool IsNil() {
            return true;
        }
    }
}
