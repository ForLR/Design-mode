using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    public class Mange : AbstractEmployee
    {
        public override void Audit(ApplyContext context)
        {
            if (context.hour < 24)
            {
                Console.WriteLine("Mange 审核通过");
                context.AuditOk();
            }
            else
            {
                this.NextAudit(context);
            }
        }
    }
}
