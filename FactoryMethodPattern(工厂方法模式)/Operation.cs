
namespace FactoryMethodPattern_工厂方法模式_
{
    /// <summary>
    /// Operation操作类
    /// </summary>
    public class Operation
    {
        #region 注释代码
        //public static double GetResult(double numberA,double numberB,string operate)
        //{
        //    double result = 0d;
        //    switch (operate)
        //    {
        //        case "+":
        //            result = numberA + numberB;
        //            break;
        //        case "-":
        //            result = numberA - numberB;
        //            break;
        //        case "*":
        //            result = numberA * numberB;
        //            break;
        //        case "/":
        //            result = numberA / numberB;
        //            break;
        //    }
        //    return result;
        //} 
        #endregion
        
        public double NumberA
        {
            get;
            set;
        }

        public double NumberB
        {
            get;set;
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
