using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Sivuyise Matwa
 * 03 August 2024
 * 
 */
namespace WaiteringSystem.Business
{
    public class Role
    {
        public enum RoleType
        {
            NoRole = 0,
            Headwaiter = 1,
            Waiter = 2,
            Runner = 3
        }
        protected string description;
        protected RoleType roleval;
        public Role()
        {
            this.roleval = RoleType.NoRole;
            this.description = "No role";
        }

        public Role(string description, RoleType roleval)
        {
            this.description = description;
            this.roleval = roleval;
        }

        public RoleType RoleVal { 
            get { return this.roleval; } set { this.roleval = value; }
        }

        public string Description { get { return description; } set { description = value; } }

        public virtual decimal Payment()
        {
            return 0;
        }

        public virtual decimal Payment(int payment)
        {
            return 0;
        }
    }
}
