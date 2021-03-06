﻿using System;

/// <summary>
/// 装饰模式 解决不能多继承或者在不改动源代码的同时添加新功能
/// 能动态的新增或组合对象的行为
/// 新增行为
/// </summary>
namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new ApplePhone();
            phone = new Sticker(phone);
            phone = new Mug(phone);
            phone.Print();

            Console.ReadKey();
        }
        public abstract class Phone  
        {
            public abstract void Print();
        }
        /// <summary>
        /// 具体实现类
        /// </summary>
        public class ApplePhone : Phone 
        {
            public override void Print()
            {
                Console.WriteLine("Apple 手机");
            }
        }
        /// <summary>
        /// 装饰抽象类
        /// </summary>
        public abstract class Decorator:Phone
        {
            private Phone phone;
            public Decorator(Phone phone)
            {
                this.phone = phone;
            }
            public override void Print()
            {
                if (phone!=null)
                {
                    phone.Print();
                }
            }
        }
        /// <summary>
        /// 具体装饰类
        /// </summary>
        public  class Sticker: Decorator
        {
            public Sticker(Phone phone):base(phone)
            {
                
            }
            public override void Print()
            {
                base.Print();
                AddSticker();
            }
            public void AddSticker()
            {
                Console.WriteLine("添加新功能 贴膜");
            }
        }
        /// <summary>
        /// 具体装饰类
        /// </summary>
        public class Mug : Decorator
        {
            public Mug(Phone phone) : base(phone)
            {
            }
            public override void Print()
            {
                base.Print();
                MakePhotos();
            }
            public void MakePhotos()
            {
                Console.WriteLine("添加新功能 拍照");
            }
        }

    }
}
