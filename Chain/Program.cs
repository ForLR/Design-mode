using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    /// <summary>
    /// 责任链模式
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            ApplyContext context = new ApplyContext
            {
                 hour=35,
                 name="张三"
            };
            StaffPeson peson = new StaffPeson();
            Mange mange = new Mange();
            Ceo ceo = new Ceo();
            peson.SetLeader(mange);
            mange.SetLeader(ceo);

            peson.Audit(context);



            Console.ReadKey();

        }
    }

    



}
