namespace DesignMode
{
    public class Singleton
    {
            private static  Singleton _singleton=null;
            private static readonly object locks = new object();
            private Singleton()
            {
            }
            public static Singleton GetSingleton()
            {
                if (_singleton==null)//lock前面判断是否为null是增加性能
                {
                    lock (locks)
                {  
                    //这层判断为null 是为了防止多线程，当两个线程或多个同时进入到判断lock的时候 
                  //第一个进入lock里进行实例化 然后出lock时候 已经解锁 不判断为空的话后一个等待的线程将直接返回第一个进入的实例对象
                    if (_singleton == null)
                        {
                            _singleton = new Singleton();
                        }
                    }
                }
                return _singleton;
            }
    }
}
