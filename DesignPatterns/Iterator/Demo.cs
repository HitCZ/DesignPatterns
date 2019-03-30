using System;

namespace DesignPatterns.Iterator
{
    public class Demo
    {
        public Demo()
        {
            JellyBeanCollection collection = new JellyBeanCollection
            {
                [0] = new JellyBean("Cherry"),
                [1] = new JellyBean("Bubble Gum"),
                [2] = new JellyBean("Root Beer"),
                [3] = new JellyBean("French Vanilla"),
                [4] = new JellyBean("Licorice"),
                [5] = new JellyBean("Buttered Popcorn"),
                [6] = new JellyBean("Juicy Pear"),
                [7] = new JellyBean("Cinnamon"),
                [8] = new JellyBean("Coconut")
            };
            
            var iterator = collection.CreateIterator();

            for (var i = iterator.First(); !iterator.IsDone; i = iterator.Next())
            {
                Console.WriteLine(i.Flavor);
            }

            Console.ReadKey();
        }
    }
}
