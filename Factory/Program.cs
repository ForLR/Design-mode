using System;

namespace Factory
{
    class Program
    {
        public static void Main(string [] agrs)
        {
            Show(new Byd());
            Show(new Fll());
            Console.ReadKey();
        }
        public abstract class AbstractFactoryCar //抽象工厂 定义方法
        {
            public abstract void Run();
            public abstract void Price();
           
        }
        public class Byd : AbstractFactoryCar //具体类继承抽象工厂 实现自己的方法
        {
            public override void Price()
            {
                Console.WriteLine("1000");
            }

            public override void Run()
            {
                Console.WriteLine("I am Byd and begin Run");
            }
        }
        public class Fll : AbstractFactoryCar
        {
            public override void Price()
            {
                Console.WriteLine("2000");
            }

            public override void Run()
            {
                Console.WriteLine("I am Fll and begin Run");
            }
        }
        public static void Show(AbstractFactoryCar car) //参数类型设置为抽象工厂类型 然后传入具体继承抽象工厂的类来实现自己的方法
        {
            car.Price();
            car.Run();
        }
    }

}
