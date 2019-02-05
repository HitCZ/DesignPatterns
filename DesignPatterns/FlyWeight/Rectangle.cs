using System;

namespace DesignPatterns.FlyWeight
{
    public class Rectangle : IShape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; }

        public Rectangle(string color)
        {
            Color = color;
        }

        public void Draw()
        {
            Console.WriteLine($"Rectangle: Draw() [Color:{Color}, X:{X}, Y:{Y}]");
        }
    }
}
