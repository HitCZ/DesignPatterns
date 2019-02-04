using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ObjectPool
{
    public class Pool<T> : IPool<T>
    {
        private readonly List<T> availableObjects = new List<T>();
        private readonly HashSet<T> objectsBeingUsed = new HashSet<T>();
        private readonly IFactory<T> objectFactory;
        private readonly int capacity;
        private int total = 0;
        private Task objectGettingTask;

        public Pool(IFactory<T> factory) : this(factory, 0)
        {
        }

        public Pool(IFactory<T> factory, int capacity) : this(factory, capacity, 0)
        {
        }

        public Pool(IFactory<T> factory, int capacity, int start)
        {
            if (start < 0)
                throw new ArgumentException("Number of starting objects cannot be lower than zero.");
            if (capacity != 0 && capacity < start)
                throw new ArgumentException("The capacity cannot be lower than the starting number of instances.");

            this.capacity = capacity < 0 ? int.MaxValue : capacity;
            objectFactory = factory;

            for (var i = 0; i < start; i++)
            {
                CreateNext(true);
            }
        }

        #region IPool

        public T GetObjectNow()
        {
            return availableObjects.Count > 0 ? GetAvailableObject().Result : CreateNext(false);
        }

        public async Task<T> GetObjectWhenPossible()
        {
            if (availableObjects.Count > 0)
                return GetAvailableObject().Result;
            if (total < capacity)
                return CreateNext(false);
            do
            {
                try
                {
                    if (objectGettingTask is null)
                        objectGettingTask = Task.Factory.StartNew(GetObjectWhenPossible);
                    await objectGettingTask;
                }
                catch
                {
                    // ignored
                }
            } while (availableObjects.Count == 0);

            objectGettingTask = null;

            return GetAvailableObject().Result;
        }

        public Task<T> GetAvailableObject() => availableObjects.Count > 0 ?

        public void GetInstance(T instance)
        {
            throw new NotImplementedException();
        }

        #endregion IPool

        #region Private Methods

        private T CreateNext(bool isAvailable)
        {
            var nextInstance = objectFactory.GetNewInstance();

            if (isAvailable)
                availableObjects.Add(nextInstance);
            else
                objectsBeingUsed.Add(nextInstance);

            return nextInstance;
        }

        private T DeliverAvailable()
        {
            var removed = availableObjects.First();
            availableObjects.Remove(availableObjects.First());

            return removed;
        }

        #endregion Private Methods
    }
}
