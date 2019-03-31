using System;

namespace DesignPatterns.TemplateMethod
{
    public class Football : Game
    {
        protected override void Initialize()
        {
            Console.WriteLine("Preparing Football game.");
        }

        protected override void Start()
        {
            Console.WriteLine("Starting Football game.");
        }

        protected override void End()
        {
            Console.WriteLine("Ending Football game.");
        }
    }
}
