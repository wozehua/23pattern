/*
*命名空间: 代理模式
*类    名：Pursuit
*创 建 人：蔡泽华
*创建时间：2018/1/7 22:27:29
*/
using System;

namespace 代理模式
{
    /// <summary>
    /// 
    /// </summary>
    public class Pursuit:IGiveGift
    {
        private readonly SchoolGirl _mm;

        public Pursuit(SchoolGirl mm)
        {
            _mm = mm;
        }

        public void GiveDolls()
        {
            Console.WriteLine(_mm.Name+"songniyangwawa");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(_mm.Name+"xianhua");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(_mm.Name +" qiaokeli");
        }
    }
}
