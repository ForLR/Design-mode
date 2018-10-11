using System;
/// <summary>
/// 命令模式
/// </summary>
namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCommand concrete=new ConcreteCommand(new Receicer());
            Invoker invoker = new Invoker();
            invoker.SetCommand(concrete);
            invoker.ExecuteCommand();
            Console.ReadKey();
        }
        /// <summary>
        /// 
        /// </summary>
        public class Receicer
        {
            public void Action()
            {
                Console.WriteLine("跑1000m");
            }
        }
        /// <summary>
        /// 抽象命令
        /// </summary>
        public abstract class Command
        {
            public Receicer receicer;
            public Command(Receicer receicer)
            {
                this.receicer = receicer;
            }
            public abstract void Execute();
        }
        /// <summary>
        /// 具体命令实现，须知道命令接受者
        /// </summary>
        public class ConcreteCommand : Command
        {
            public ConcreteCommand(Receicer receicer) : base(receicer)
            {
            }
            public override void Execute()
            {
                receicer.Action();
            }
        }
        /// <summary>
        /// 调用命令
        /// </summary>
        class Invoker
        {
            private ConcreteCommand Concrete;
            public void SetCommand(ConcreteCommand Concrete)
            {
                this.Concrete = Concrete;
            }
            public void ExecuteCommand()
            {
                if (Concrete!=null)
                {
                    Concrete.Execute();
                }   
            }
        }
    }
}
