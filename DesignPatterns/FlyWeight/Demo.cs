using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyWeight
{
    class Demo
    {
        private readonly string[] colors = { "Red", "Green", "Yellow", "Blue" };
        private Random random = new Random();

        public void Run()
        {
            for (var i = 0; i < 20; i++)
            {
                var circle = (Circle) ShapeFactory.GetCircle(GetRandomColor());

                circle.X = random.Next(100);
                circle.Y = random.Next(100);
                circle.Radius = 100;
                circle.Draw();
            }
        }

        private string GetRandomColor()
        {
            return colors[random.Next(colors.Length)];
        }
    }
}
