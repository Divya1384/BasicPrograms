namespace PubSubUsingObserverPattern
{
    public class Stock
    {
        public string StockName { get; set; }
        public decimal StockPrice { get; set; }

        public Stock(string name, decimal price)
        {
            StockName = name;
            StockPrice = price;
        }
    }
}
