using System.Collections;

namespace DesignPatterns.Iterator
{
    public class JellyBeanCollection : ICandyCollection
    {
        private readonly ArrayList items = new ArrayList();

        public int Count => items.Count;

        public object this[int index]
        {
            get => items[index];
            set => items.Add(value);
        }

        public IJellyBeanIterator CreateIterator()
        {
            return new JellyBeanIterator(this);
        }
    }
}
