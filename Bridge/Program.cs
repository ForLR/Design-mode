using System;
/// <summary>
/// 桥接模式 把继承变为组合
/// 抽象部分和实现部分 分离 
/// 依赖同个抽象  对应不同实现
/// </summary>
namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new ConcreteRemote
            {
                GetTV = new ChangHong()
            };
            remote.On();
            remote.Wacthing();
            remote.Off();
            remote.GetTV = new SuoNi();
            remote.On();
            remote.Wacthing();
            remote.Off();
            Console.ReadKey();
        }
        public abstract class TV
        {
            public abstract void On();
            public abstract void OFF();
            public abstract void Watch();
        }
        public class ChangHong : TV
        { 
            public override void OFF()
            {
                Console.WriteLine("ChangHong 关闭");
            }

            public override void On()
            {
                Console.WriteLine("ChangHong 打开");
            }

            public override void Watch()
            {
                Console.WriteLine("ChangHong 观看");
            }
        }
        public class SuoNi : TV
        {
            public override void OFF()
            {
                Console.WriteLine("SuoNi 关闭");
            }

            public override void On()
            {
                Console.WriteLine("SuoNi 打开");
            }

            public override void Watch()
            {
                Console.WriteLine("SuoNi 观看");
            }
        }

        public class RemoteControl
        {
            public TV TV;
            public TV GetTV { get { return TV; } set { TV = value; } }
            public virtual void On()
            {
                TV.On();
            }
            public virtual void Off()
            {
                TV.On();
            }
            public virtual void Wacthing()
            {
                TV.Watch();
            }
        }
        public class ConcreteRemote:RemoteControl
        {
            public override void Wacthing()
            {
                base.Wacthing();
            }
        }


    }
}
