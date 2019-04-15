/*
*命名空间: 代理模式
*类    名：Proxy
*创 建 人：蔡泽华
*创建时间：2018/1/7 22:37:39
*/

namespace 代理模式
{

    public class Proxy:IGiveGift
    {
        private readonly Pursuit _gg;

        public Proxy(SchoolGirl mm)
        {
            _gg = new Pursuit(mm);
        }

        public void GiveDolls()
        {
            _gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            _gg.GiveFlowers();
        }

        public void GiveChocolate()
        {
            _gg.GiveChocolate();
        }
    }
}
