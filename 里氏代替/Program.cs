using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏代替
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            var r = new Square() { Width=10,Height=10};
            test.Resize(r);
            Console.WriteLine(r.Width+@"\t"+r.Height);
            Console.ReadKey();
        }
        public abstract class Quadrangle
        {
            public virtual long Width { get; set; }
            public virtual long Height { get; set; }
        }
        public class Rectangle: Quadrangle
        {
            public override long Width { get; set; }
            public override long Height { get; set; }
        }
        public class Square : Rectangle
        {
            public override long Width { get => base.Width ; set { base.Width = value; base.Height = value; } }
            public override long Height { get => base.Height; set { base.Width = value; base.Height = value; } }
        }
       public class Test
        {
            
            public void Resize(Quadrangle e)
            {
                while (e.Height>=e.Width)
                {
                    e.Width++;
                }
            }
        }
    }
}
