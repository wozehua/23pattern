using System;

namespace FacadePattern_外观模式_
{
    class Program
    {
        static void Main(string[] args)
        {
            Fund fund = new Fund();
            fund.FundBuy();
            fund.FundSell();
            Console.Read();
        }
    }
}
