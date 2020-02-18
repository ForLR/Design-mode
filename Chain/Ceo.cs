using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    public class Ceo : AbstractEmployee
    {
        public override void Audit(ApplyContext context)
        {
            if (context.hour < 48)
            {
                Console.WriteLine("Ceo审核通过");
                context.AuditOk();
            }
            else
            {
                this.NextAudit(context);
            }
        }
    }
}
