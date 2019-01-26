using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Servant {
    class Position {
        public readonly int xPosition;
        public readonly int yPosition;
        
        public Position(int x, int y) {
            this.xPosition = x;
            this.yPosition = y;
        }
    }
}
