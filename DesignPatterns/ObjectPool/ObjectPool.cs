using System.Collections.Concurrent;

namespace DesignPatterns.ObjectPool
{
    public class ObjectPool<T> where T : new()
    {
        private readonly ConcurrentBag<T> items = new ConcurrentBag<T>();
        private const int MAX = 10;
        private int counter = 0;

        public void Release(T item)
        {
            if (counter >= MAX)
                return;
            
            items.Add(item);
            counter++;
        }

        public T Get()
        {
            if (items.TryTake(out var item))
            {
                counter--;
                return item;
            }

            var obj = new T();
            items.Add(obj);
            counter++;

            return obj;
        }
    }
}
