using System;
/// <summary>
/// 中介模式
/// </summary>
namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Preson a = new A
            {
                HP = 1000
            };
            Preson b = new B
            {
                HP = 2000
            };
            //A攻击B
            MediatorPater mediator = new MediatorPater(a,b);
            mediator.AttackA(100);
            Console.WriteLine("A的生命值为:"+a.HP+ "\tB的生命值为:" + b.HP);
            Console.ReadKey();
        }
        public abstract class Preson
        {
            public int HP { get; set; }
            public abstract void Attack(int hp, AbstractMediator  mediator);
        }
        public class A : Preson
        {
            public override void Attack(int hp, AbstractMediator mediator) => mediator.AttackB(hp);
        }
        public class B : Preson
        {
            public override void Attack(int hp, AbstractMediator mediator)
            {
                mediator.AttackA(hp);
            }
        }
        public abstract class AbstractMediator
        {
            public Preson mediatorA, mediatorB;
            public AbstractMediator(Preson mediatorA, Preson mediatorB)
            {
                this.mediatorA = mediatorA;
                this.mediatorB = mediatorB;
            }
            public abstract void AttackA(int hp);
            public abstract void AttackB(int hp);
        }
        public class MediatorPater : AbstractMediator
        { 
            public MediatorPater(Preson mediatorA, Preson mediatorB) :base(mediatorA, mediatorB)
            {
            }
            public override void AttackA(int hp)
            {
                mediatorA.HP -= hp * 2;
                mediatorB.HP -= hp * 3;
            }
            public override void AttackB(int hp)
            {
                mediatorA.HP -= hp * 5;
                mediatorA.HP -= hp * 4;
            }
        }
    }
}
