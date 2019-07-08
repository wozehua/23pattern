using System;
using MementoPattern_备忘录模式_.GameProgress;

namespace MementoPattern_备忘录模式_
{
    /// <summary>
    /// 备忘录模式：在不破坏封装性的前提下，捕获一个对象的内部状态，
    /// 并在该对象之外保存这个状态。这样以后就可以将该对象恢复到原先保存的状态。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //大战Boss前 这个里面实现了保存状态的方法和 恢复之前状态的方法。
            GameRole gameRole = new GameRole();
            gameRole.GetInitState();
            gameRole.StateDisplay();

            //保存游戏 在开始消耗之前进行状态保存。
            RoleStateCaretaker roleStateCaretaker = new RoleStateCaretaker {RoleStateMemento = gameRole.SaveState()};
            //开始消耗操作
            gameRole.Fight();
            gameRole.StateDisplay();

            //恢复之前状态
            gameRole.RecoveryState(roleStateCaretaker.RoleStateMemento);
            gameRole.StateDisplay();
            Console.Read();
        }
    }
}
