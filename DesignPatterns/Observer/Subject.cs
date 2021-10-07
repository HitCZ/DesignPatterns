﻿using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    class Subject : IObservable
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
                observer.Update();
        }
    }
}
