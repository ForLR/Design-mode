using System;
using System.Collections;
/// <summary>
/// 享元
/// </summary>
namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficFactory trafficFactory = new TrafficFactory();
            Traffic traffic1 = trafficFactory.GetTraffic("火车");
            Traffic traffic2 = trafficFactory.GetTraffic("大巴");
            traffic1.Ride(new User("张三"));
            traffic2.Ride(new User("李四"));
            Console.ReadKey();
        }
        public class User
        {
            public User(string name)
            {
                Name = name;
            }
            public string Name { get; }
        }
        public abstract class Traffic
        {
            public abstract void Ride(User user);
        }
        public  class Car:Traffic
        {
            private string _name;
            public Car(string  name)
            {
                _name = name;
            }
            public override void Ride(User user)
            {
                Console.WriteLine(user.Name+"乘坐"+_name);
            }
        }
        public class TrafficFactory
        {
            private Hashtable hashtable = new Hashtable();
            public Traffic GetTraffic(string key)
            {
                if (!hashtable.Contains(key))
                {
                    hashtable.Add(key, new Car(key));

                }
                return hashtable[key] as Car;
            }
            public int GetCount()
            {
                return hashtable.Count;
            }
        }
    }
}
