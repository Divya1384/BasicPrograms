using System;
using System.Collections.Generic;

namespace PubSubUsingObserverPattern
{
    public class StockService : IObservable<Stock>
    {
        private List<IObserver<Stock>> observers = new List<IObserver<Stock>>();

        public IDisposable Subscribe(IObserver<Stock> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscribe(observers, observer);
        }

        private class Unsubscribe : IDisposable
        {
            private List<IObserver<Stock>> _observers;
            private IObserver<Stock> _observer;

            public Unsubscribe(List<IObserver<Stock>> observers, IObserver<Stock> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void PublishMessage(Stock stock)
        {
            foreach (var observer in observers)
            {
                if (observer == null)
                    observer.OnError(new ArgumentException());
                observer.OnNext(stock);
            }
        }

        public void StopPublish()
        {
            foreach (var observer in observers.ToArray())
            {
                if (observer != null)
                    observer.OnCompleted();
            }
            observers.Clear();
        }
    }
}
