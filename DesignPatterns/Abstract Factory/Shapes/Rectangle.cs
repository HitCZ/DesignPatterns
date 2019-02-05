using System;

namespace DesignPatterns.Abstract_Factory.Shapes
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
