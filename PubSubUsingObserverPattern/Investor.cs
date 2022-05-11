using System;

namespace PubSubUsingObserverPattern
{
    public class Investor : IObserver<Stock>
    {
        public IDisposable unsubscribe;
        private string investorName;

        public Investor(string name)
        {
            investorName = name;
        }

        public void OnError(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        public void OnNext(Stock stock)
        {
            Console.WriteLine($"{investorName} - The updated price for stock {stock.StockName} is {stock.StockPrice}");
        }

        public void OnCompleted()
        {
            Unsubscribe();
        }

        public void Subscribe(IObservable<Stock> provider)
        {
            if (provider != null)
                unsubscribe = provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            unsubscribe.Dispose();
        }
    }
}
