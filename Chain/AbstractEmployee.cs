using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    /// <summary>
    /// 抽象职员
    /// </summary>
    public abstract class AbstractEmployee
    {
        protected AbstractEmployee _employee;


        public void SetLeader(AbstractEmployee employee)
        {
            this._employee = employee;
        }
        public abstract void Audit(ApplyContext context);

        public virtual void  NextAudit(ApplyContext context)
        {
            if (_employee != null)
            {
                _employee.Audit(context);
            }
            else
            {
                context.adutit_msg = "审核拒绝";
                context.audit = false;
                Console.WriteLine("审核拒绝");
            }
           
        }

    }
}
