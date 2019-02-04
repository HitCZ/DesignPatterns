using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyWeight
{
    class ShapeFactory
    {
        private static readonly Dictionary<string, IShape> cache 
            = new Dictionary<string, IShape>();

        public static IShape GetCircle(string color)
        {
            cache.TryGetValue(color, out var circle);

            if (!(circle is null))
                return circle;

            circle = new Circle(color);
            cache.Add(color, circle);
            Console.WriteLine($"Creating circle of color: {color}.");

            return circle;
        }
    }
}
