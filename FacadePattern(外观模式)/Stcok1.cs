using System;

//这边为了方便就把所有类都写在一起
namespace FacadePattern_外观模式_
{
    /// <summary>
    /// 股票一
    /// </summary>
    public class Stock1
    {
        public void Sell()
        {
            Console.WriteLine("股票一卖出");
        }

        public void Buy()
        {
            Console.WriteLine("股票一买入");
        }
    }

    public class Stock2
    {
        public void Sell()
        {
            Console.WriteLine("股票二卖出");
        }

        public void Buy()
        {
            Console.WriteLine("股票二买入");
        }
}

    public class NationalDebt1
    {
        public void Sell()
        {
            Console.WriteLine("卖出国债");
        }

        public void Buy()
        {
            Console.WriteLine("买入国债");
        }
    }
    public class Realty1
    {
        public void Sell()
        {
            Console.WriteLine("卖出房地产");
        }

        public void Buy()
        {
            Console.WriteLine("买入房地产");
        }
    }
}
