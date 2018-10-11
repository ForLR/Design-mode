using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    /// <summary>
    /// 模板模式  ....exm？？？ 虚方法？？？
    /// 定义抽象类 抽象方法 具体实现交由具体实现类
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ChaoBoCai boCai = new ChaoBoCai();
            boCai.Begin();
            Console.ReadKey();
        }
        public abstract class ChaoCai
        {
            public  void DaoYou()
            {
                Console.WriteLine("倒油");
            }
            public void ShaoRe()
            {
                Console.WriteLine("烧热");
            }
            public abstract void FangCai();
            public void FanChao()
            {
                Console.WriteLine("翻炒");
            }
            public void Begin()
            {
                DaoYou();
                ShaoRe();
                FangCai();
                FanChao();
            }
        }
        public class ChaoBoCai : ChaoCai
        {
            public override void FangCai()
            {
                Console.WriteLine("放入菠菜");
            }
        }
    }
}
