using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern_外观模式_
{
    /// <summary>
    /// 基金类 ==外观类
    /// </summary>
    public class Fund
    {
        Stock1 gu1;
        Stock2 gu2;
        NationalDebt1 nd1;
        Realty1 rt1;

        public Fund()
        {
            gu1 = new Stock1();
            gu2 = new Stock2();
            nd1 = new NationalDebt1();
            rt1 = new Realty1();
        }

        public void FundBuy()
        {
            gu1.Buy();
            gu2.Buy();
            nd1.Buy();
            rt1.Buy();
        }
        public void FundSell()
        {
            gu1.Sell();
            gu2.Sell();
            nd1.Sell();
            rt1.Sell();
        }
    }
}
