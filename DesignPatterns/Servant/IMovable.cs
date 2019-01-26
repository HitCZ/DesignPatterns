using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Servant {
    interface IMovable {
        void SetPosition(Position p);
        Position GetPosition();
    }
}
