namespace MementoPattern_备忘录模式_.GameProgress
{
    /// <summary>
    /// 角色状态存储箱类
    /// </summary>
    public class RoleStateMemento
    {
        public int Vitality { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public RoleStateMemento(int vit,int atk,int def)
        {
            Vitality = vit;
            Attack = atk;
            Defense = def;
        }
    }
}
