using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Summarize
{
    class Program
    {
        static void Main(string[] args)
        {
            抽象工厂.IFactory factory = new 抽象工厂.JeepCarFactory();
            factory.GetCar().GetCar();


            Console.ReadKey();
        }
        #region 简单工厂


        public class 简单工厂
        {
            public interface ICar
            {
                void GetCar();
            }
            public class SportCar : ICar
            {
                public void GetCar()
                {
                    Console.WriteLine("SportCar");
                }
            }
            public class JeepCar : ICar
            {
                public void GetCar()
                {
                    Console.WriteLine("JeepCar");
                }
            }
            public enum CarType { SportCar=1, JeepCar=2 }

            public class Factory
            {
                public ICar Car(CarType type)
                {
                    switch (type)
                    {
                        case CarType.JeepCar:
                            return new JeepCar();
                        case CarType.SportCar:
                            return new SportCar();
                        default:
                            throw new Exception();
                    }
                }
            }

        }
        #endregion
        #region 抽象工厂
        public class 抽象工厂
        {
            public interface IFactory
            {
                ICar GetCar();
            }
            public interface ICar
            {
                void GetCar();
            }
            public class JeepCar : ICar
            {
                public void GetCar()
                {
                    Console.WriteLine("JeepCar");
                }
            }
            public class SuperCar : ICar
            {
                public void GetCar()
                {
                    Console.WriteLine("SuperCar");
                }
            }
            public class JeepCarFactory : IFactory
            {
                public ICar GetCar()
                {
                    return new JeepCar();
                }
            }
            public class SuperCarFactory : IFactory
            {
                public ICar GetCar()
                {
                    return new SuperCar();
                }
            }
        }

        #endregion
    }
}
