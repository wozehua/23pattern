namespace IteratorPattern_迭代器模式_
{
    /// <summary>
    /// Iterator迭代器抽象类
    /// </summary>
   abstract class Iterator
   {
       public abstract object First();

       public abstract object Next();

       public abstract bool IsDone();

       public abstract object CurrentItem();
   }
}
