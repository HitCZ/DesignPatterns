using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Servant {
    class Main {
        public static void main(string[] args) {
            Triangle t = new Triangle();
            Ellipse e = new Ellipse();

            MoveServant servant = new MoveServant();
            servant.MoveBy(t, 5, 5);
            servant.MoveBy(e, 50, 5);

        }
    }
}
