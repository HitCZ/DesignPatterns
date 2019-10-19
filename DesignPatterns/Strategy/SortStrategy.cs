using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public abstract class SortStrategy
    {
        public virtual void Sort(List<Student> list)
        {
            Console.WriteLine($"{GetType().Name} used.");
            list.ForEach(s => Console.WriteLine(s.Name));
        }
    }
}
