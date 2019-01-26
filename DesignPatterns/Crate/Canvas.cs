using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Crate {
    public class Canvas {

        public void DrawPoint(Point p) { }
        public void DrawPoint(int x, int y) { }

        public class Point {
            public readonly int x;
            public readonly int y;

            public Point(int x, int y) {
                this.x = x;
                this.y = y;
            }
        }
    }
}
