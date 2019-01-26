using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Servant {
    class Triangle : IMovable {
        private Position p;

        public Position GetPosition() {
            return this.p;
        }

        public void SetPosition(Position p) {
            this.p = p;
        }
    }
}
