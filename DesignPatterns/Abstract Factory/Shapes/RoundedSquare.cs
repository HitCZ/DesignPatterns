using System;

namespace DesignPatterns.Abstract_Factory.Shapes
{
    class RoundedSquare : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside RoundedSquare::draw() method.");
        }
    }
}
