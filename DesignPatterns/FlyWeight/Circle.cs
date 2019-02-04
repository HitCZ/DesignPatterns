using System;

namespace DesignPatterns.FlyWeight
{
    public class Circle : IShape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
        public string Color { get; }

        public Circle(string color)
        {
            Color = color;
        }

        public void Draw()
        {
            Console.WriteLine(
                $"Circle: Draw() [Color:{Color}, X:{X}, Y:{Y}, Radius:{Radius}]");
        }
    }
}
