using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CommandPattern_命令模式_.Example
{
    public class Waiter
    {
        private List<Command> commands = new List<Command>();

        public void SetOrder(Command command)
        {
            if (command.ToString() == "BakeChickenWingCommand")
            {
                Console.WriteLine("服务员：鸡翅没有了，请点别的烧烤");
            }
            else
            {
                commands.Add(command);
                Console.WriteLine($"增加订单：{command}时间：{DateTime.Now.ToString(CultureInfo.InvariantCulture)}");
            }

        }

        public void CancelOrder(Command command)
        {
            commands.Remove(command);
            Console.WriteLine($"取消订单：{command}时间：{DateTime.Now.ToString(CultureInfo.InvariantCulture)}");
        }

        public void Notify()
        {
            foreach (var cmd in commands)
            {
                cmd.ExcuteCommand();
            }
        }
    }
}
