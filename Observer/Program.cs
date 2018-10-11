using System;
using System.Collections.Generic;
/// <summary>
/// 观察者模式
/// 被观察者 把观察者添加到一个列表里面，提供add和delete操作，观察者添加更新操作 并把更新结果通过属性保存，在被观察者里面通过这个属性来通知观察者
/// </summary>
namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Depositor depositor1 = new BeiJingDepositor("张三",10000);
            Depositor depositor2 = new BeiJingDepositor("李四", 1523);

            BeiJingBankMessageSystem beiJingBank = new BeiJingBankMessageSystem();
            beiJingBank.Add(depositor1);
            beiJingBank.Add(depositor2);
            //取钱
            depositor1.GetMoney(123);
            depositor2.GetMoney(500);
            beiJingBank.Notity();
            depositor1.GetMoney(500);
            beiJingBank.Notity();
            Console.ReadKey();
        }
        /// <summary>
        /// 抽象观察者角色（Observer）
        /// </summary>
        public abstract class Depositor
        {
            public string Name { get; set; }
            public int Balance { set; get; }
       
            public bool IsChanged { get; set; }
            public DateTime OperationDateTime { get; set; }
            public Depositor(string name,int balance)
            {
                Name = name;
                Balance = balance;
                IsChanged = false;
            }
            public void GetMoney(int money)
            {
                if (money>0&&money<= Balance)
                {
                    Balance -= money;
                    IsChanged = true;
                }
            }
            public abstract void Update(int money,DateTime dateTime);
        }
        /// <summary>
        /// 具体观察者
        /// </summary>
        public class BeiJingDepositor : Depositor
        {
            public BeiJingDepositor(string name, int balance) :base(name,balance)
            {
            
            }
            public override void Update(int money, DateTime dateTime)
            {
                Console.WriteLine("{0}账户发生了变化,当前的余额为{1}，变化的具体时间为时间为{2}", Name, money, dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public abstract class BankMessageSystem
        {
            public IList<Depositor> observers;
            public BankMessageSystem()=> observers = new List<Depositor>();
       
            public abstract void Add(Depositor depositor);
            public abstract void Delete(Depositor depositor);
            public void Notity()
            {
                foreach (var item in observers)
                {
                    if (item.IsChanged)
                    {
                        item.Update(item.Balance, DateTime.Now);
                        item.IsChanged = false;
                    }
                }
            }
        }
        /// <summary>
        /// 被观察者
        /// </summary>
        public class BeiJingBankMessageSystem : BankMessageSystem
        {
            public override void Add(Depositor depositor)=> observers.Add(depositor);
            public override void Delete(Depositor depositor)=> observers.Remove(depositor);

        }

    }
}
