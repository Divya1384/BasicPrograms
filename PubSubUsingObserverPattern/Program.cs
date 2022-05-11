using System;

namespace PubSubUsingObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StockService objStockService = new StockService();

            Investor objInvestor1 = new Investor("Bob");
            Investor objInvestor2 = new Investor("James");

            BoardMember objBoardMember1 = new BoardMember("Tom");
            BoardMember objBoardMember2 = new BoardMember("Frank");

            objInvestor1.Subscribe(objStockService);
            objInvestor2.Subscribe(objStockService);
            objBoardMember1.Subscribe(objStockService);
            objBoardMember2.Subscribe(objStockService);

            objStockService.PublishMessage(new Stock("IBM", 2590));
            objStockService.PublishMessage(new Stock("Philips", 5000));

            objInvestor2.Unsubscribe();

            objStockService.PublishMessage(new Stock("IBM", 2590));
            objStockService.PublishMessage(new Stock("Philips", 5000));

            objStockService.StopPublish();

            Console.Read();
        }
    }
}
