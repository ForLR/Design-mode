using System;
using System.Collections.Generic;
/// <summary>
/// 组合模式
/// </summary>
namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Man grandpa = new Boy("爷爷");
            Man grandma = new Girl("奶奶");
            grandpa.Add(grandma);
            Man father = new Boy("爸爸");
            Man gugu = new Girl("姑姑");
            Man mother = new Girl("妈妈");
            father.Add(mother);
            grandpa.Add(father);
            grandpa.Add(gugu);
            grandpa.Info();
            father.Info();
            Console.ReadKey();
        }
        public abstract class Man
        {
            public string Name { get; set; } 
            public abstract void Add(Man father);
            public abstract void Remove(Man father);
            public abstract void Info();
        }
        public class Boy : Man
        {
            public Boy(string name)
            {
                Name = name;
            }
            public List<Man> famaily = new List<Man>();
            public override void Add(Man father)
            {
                famaily.Add(father);
            }

            public override void Info()
            {
                foreach (var item in famaily)
                {
                    Console.WriteLine("{0} 有{1}", Name, item.Name);
                }
            }
            public override void Remove(Man father)
            {
                famaily.Remove(father);
            }
        }
        public class Girl : Man
        {
            public Girl(string name)
            {
                Name = name;
            }
            List<Man> famaily = new List<Man>();
            public override void Add(Man father)
            {
                famaily.Add(father);
            }

            public override void Info()
            {
                foreach (var item in famaily)
                {
                    Console.WriteLine("我是:" + item.Name);
                }
            }
            public override void Remove(Man father)
            {
                famaily.Remove(father);
            }
        }
    }
}
