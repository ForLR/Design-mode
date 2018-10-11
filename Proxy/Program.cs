using System;
/// <summary>
/// 代理模式
/// </summary>
namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.BuyProduct();
            Console.ReadKey();
        }
        public abstract class Proson
        {
            public abstract void BuyProduct();
        }
        public class ReadProson : Proson
        {
            public override void BuyProduct()
            {
                Console.WriteLine("从国外买特产");
            }
        }
        public class Proxy: Proson
        {
            private ReadProson Proson;
            public Proxy()
            {
                Proson = new ReadProson();
            }
            private void  BuyPhone()
            {
                Console.WriteLine("帮张三从国外买手机");
            }
            private void BuyComputer()
            {
                Console.WriteLine("帮李四从国外买电脑");
            }
            public override void BuyProduct()
            {
                BuyPhone();
                BuyComputer();
                Proson.BuyProduct();
            }
        }

    }
}
