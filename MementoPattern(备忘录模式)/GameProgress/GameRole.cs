using System;

namespace MementoPattern_备忘录模式_.GameProgress
{
    public class GameRole
    {
        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality { get; set; }

        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// 防御力
        /// </summary>
        public int  Defense { get; set; }

        /// <summary>
        /// 保存状态
        /// </summary>
        /// <returns></returns>
        public RoleStateMemento SaveState()
        {
            return (new RoleStateMemento(Vitality, Attack, Defense));
        }

        public void RecoveryState(RoleStateMemento roleStateMemento)
        {
            Vitality = roleStateMemento.Vitality;
            Attack = roleStateMemento.Attack;
            Defense = roleStateMemento.Defense;
        }

        public void StateDisplay()
        {
            Console.WriteLine("角色当前状态:");
            Console.WriteLine($"体力:{Vitality}");
            Console.WriteLine($"攻击力:{Attack}");
            Console.WriteLine($"防御力:{Defense}");
        }

        public void GetInitState()
        {
            Vitality = 100;
            Attack = 100;
            Defense = 100;
        }

        public void Fight()
        {
            Vitality = 0;
            Attack = 0;
            Defense = 0;
        }
    }
}
