using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    public class ApplyContext
    {
        public int id { get; set; }

        public int hour { get; set; }

        public string name { get; set; }

        public string adutit_msg { get; set; }

        public bool audit { get; set; }


        public void SetAudit(bool isOk)
        {
            if (isOk)
            {
                this.adutit_msg = "审核通过";
                this.audit = true;
                Console.WriteLine($"{this.name}的申请于{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}审核通过");
            }
            else
            {
                this.adutit_msg = "交由下一个审核";
                Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}由{this.name}审核交由下一个审核");

            }
        }

        public void AuditOk()
        {
            SetAudit(true);
        }

        public void AuditRefuse()
        {
            SetAudit(false);
        }
    }
}
