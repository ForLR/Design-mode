using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class zhongjiezhe
    {
        public static void Main(string [] args)
        {
            Human humanA = new A() { Name="A"};
            Human humanB = new A() { Name = "B" };
            Agency agency = new AgencySpecific(humanA,humanB);
            agency.Say1("hi");
            agency.Say2("haha");
            Console.ReadKey();
        }

        public abstract class Human
        {
            public string Name { get; set; }
            public abstract void say(string str, Agency agency);
        }
        public class A : Human
        {
            public override void say(string str, Agency agency)
            {
                agency.Say1(str);
            }
        }
        public class B : Human
        {
            public override void say(string str, Agency agency)
            {
                agency.Say2(str);
            }
        }
        public abstract class Agency
        {
            public Human human1, human2;
            public Agency(Human human1, Human human2)
            {
                this.human1 = human1;
                this.human2 = human2;
            }
            public abstract void Say1(string str);
            public abstract void Say2(string str);
        }
        public class AgencySpecific : Agency
        {
            public AgencySpecific(Human human1, Human human2) : base(human1,human2)
            {

            }
            public override void Say1(string str)
            {
                Console.WriteLine(human1.Name+"对"+human2.Name+"Say:"+str);
            }

            public override void Say2(string str)
            {
                Console.WriteLine(human2.Name + "对" + human1.Name + "Say:" + str);
            }
        }
    }
}
