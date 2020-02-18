using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    public class StaffPeson : AbstractEmployee
    {
        public override void Audit(ApplyContext context)
        {
            if (context.hour<8)
            {
                context.AuditOk();
            }
            else
            {
               this.NextAudit(context);
            }
        }
    }
}
