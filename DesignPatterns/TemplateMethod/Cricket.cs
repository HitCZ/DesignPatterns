using System;

namespace DesignPatterns.TemplateMethod
{
    public class Cricket : Game
    {
        protected override void Initialize()
        {
            Console.WriteLine("Preparing Cricket game.");
        }

        protected override void Start()
        {
            Console.WriteLine("Starting Cricket game.");
        }

        protected override void End()
        {
            Console.WriteLine("Ending Cricket game.");
        }
    }
}
