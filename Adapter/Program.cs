using System;

/// <summary>
/// 适配器模式 对不支持的方法 进行封装 得到自己能够调用的类型
/// 有类适配器和对象适配器 推荐对象适配器
/// 我们访问的接口A中没有需要的方法bb 但是这个方法在b中含有 而我们又不能直接访问b   用一个适配类来解决  继承接口a  然后在适配类中访问b的方法 这样就实现适配的作用 
/// </summary>
namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Threehole threehole = new Threehole();
            threehole.Request();
            Threehole hole = new PowerAdapterS();
            hole.Request();
            Console.ReadKey();
        }
        #region 类适配器
        public interface IThreeHole
        {
            void Request();
        }
        public abstract class TwoHole
        {
            public void SpecificRequest()
            {
                Console.WriteLine("两个孔的插头");
            }
        }
        /// <summary>
        /// PowerAdapter 
        /// </summary>
        public class PowerAdapter : TwoHole, IThreeHole
        {
            public void Request()
            {
                SpecificRequest();
            }
        }
        #endregion
        #region 对象适配器
        public class Threehole
        {
            public virtual void Request()
            {
                Console.WriteLine("三个孔的插头");
            }  
        }
        public class TwoHoleS
        {
            public void SpecificRequest()
            {
                Console.WriteLine("两个孔的插头");
            }
        }
        public class PowerAdapterS:Threehole
        {
            TwoHoleS HoleS = new TwoHoleS();
            public override void Request()
            {
                HoleS.SpecificRequest();
            }
        }
        #endregion

    }
}
