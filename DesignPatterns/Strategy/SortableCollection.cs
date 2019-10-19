using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    class SortableCollection : ISortableCollection
    {
        private readonly List<Student> list;
        private SortStrategy sortStrategy;

        public SortableCollection(SortStrategy strategy)
        {
            list = new List<Student>();
            sortStrategy = strategy;
        }


        public void SetSortStrategy(SortStrategy strategy)
        {
            sortStrategy = strategy;
        }

        public void Sort()
        {
            sortStrategy.Sort(list);
        }
        
        int ISortableCollection.Count() => list.Count;
        public void Add(Student student) => list.Add(student);
        public void Remove(Student student) => list.Remove(student);
    }
}
