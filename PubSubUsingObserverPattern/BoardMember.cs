using System;

namespace PubSubUsingObserverPattern
{
    public class BoardMember : IObserver<Stock>
    {
        public IDisposable unsubscriber;

        private string boardMemberName;

        public BoardMember(string name)
        {
            boardMemberName = name;
        }

        public void OnCompleted()
        {
            Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }

        public void OnNext(Stock value)
        {
            Console.WriteLine($"{boardMemberName} - The updated price for stock {value.StockName} is {value.StockPrice}");
        }

        public void Subscribe(IObservable<Stock> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
