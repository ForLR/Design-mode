using System;
/// <summary>
/// 外观模式 
/// </summary>
namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.ShowAB();
            facade.ShowBC();
            Console.ReadKey();
        }
        public class A
        {
            public void show()
            {
                Console.WriteLine("I am A");
            }
        }
        public class B
        {
            public void show()
            {
                Console.WriteLine("I am B");
            }
        }
        public class C
        {
            public void show()
            {
                Console.WriteLine("I am C");
            }
        }
        public class Facade
        {
            private A a;
            private B b;
            private C c;
            public Facade()
            {
                a = new A();
                b = new B();
                c = new C();
            }
            public void ShowAB()
            {
                a.show();
                b.show();
            }
            public void ShowBC()
            {
                b.show();
                c.show();
            }
        }
    }
}
