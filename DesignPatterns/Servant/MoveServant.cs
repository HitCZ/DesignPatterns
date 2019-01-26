using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Servant {
    class MoveServant {
        public void MoveTo(IMovable serviced, Position where) {
            serviced.SetPosition(where);
        }

        public void MoveBy(IMovable serviced, int dx, int dy) {
            dx += serviced.GetPosition().xPosition;
            dy += serviced.GetPosition().yPosition;

            serviced.SetPosition(new Position(dx, dy));
        }
    }
}
