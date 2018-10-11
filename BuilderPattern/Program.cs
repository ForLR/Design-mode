using System;
using System.Collections.Generic;

/// <summary>
/// 建造者模式
/// </summary>
namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder builder1 = new ConcreteBuilder1();
            Builder builder2 = new ConcreteBuilder2();
            director.Construct(builder1);
            builder1.GetComputer().Add("Apple");
            builder1.GetComputer().Add("戴尔");
            builder1.GetComputer().Show();

            director.Construct(builder2);
            builder2.GetComputer().Add("华硕");
            builder2.GetComputer().Show();
            Console.ReadKey();
        }
        public class Director
        {
            public void Construct(Builder builder)
            {
                builder.BuildPartCpu();
                builder.BuildPartMainBoard();
                builder.GetComputer();
            }
        }
        public abstract class Builder
        {
            public abstract void BuildPartCpu();
            public abstract void BuildPartMainBoard();
            public abstract IComputer GetComputer();
        }
        public interface IComputer
        {
            void Add(string str);
            void Show();
        }
        public class Computer : IComputer
        {
            private IList<string> vs = new List<string>();
            public void Add(string str)
            {
                vs.Add(str);
            }
            public void Show()
            {
                Console.WriteLine("电脑开始组装");
                foreach (var item in vs)
                {
                    Console.WriteLine("开始组装"+item);
                }
                Console.WriteLine("电脑组装完成");
            }
        }
        public class ConcreteBuilder1 : Builder
        {
            private readonly IComputer computer = new Computer();
            public override void BuildPartCpu()
            {
                Console.WriteLine("A 构建cpu");
            }

            public override void BuildPartMainBoard()
            {
                Console.WriteLine("A 构建主机");
            }

            public override IComputer GetComputer()
            {
                return computer;
            }
        }
        public class ConcreteBuilder2 : Builder
        {
            private readonly IComputer computer = new Computer();
            public override void BuildPartCpu()
            {
                Console.WriteLine("B 构建cpu");
            }

            public override void BuildPartMainBoard()
            {
                Console.WriteLine("B 构建主机");
            }
            public override IComputer GetComputer()
            {
                return computer;
            }
        }

    }
}
