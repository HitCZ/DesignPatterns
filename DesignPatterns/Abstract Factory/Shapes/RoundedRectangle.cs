using System;

namespace DesignPatterns.Abstract_Factory.Shapes
{
    class RoundedRectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside RoundedRectangle::Draw() method.");
        }
    }
}
