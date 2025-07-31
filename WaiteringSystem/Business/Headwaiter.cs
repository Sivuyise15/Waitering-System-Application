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
    public class Headwaiter : Role
    {
        private decimal salary;

        public Headwaiter():base() {
            RoleVal = RoleType.Headwaiter;
            description = "Headwaiter";
            salary = 0;
        }
        public Headwaiter(int salary, string descrip, RoleType ROLVAL) : base(descrip, ROLVAL) {
            roleval = ROLVAL;
            description = descrip;
            salary = 0;
        }
        public decimal salaryAmount {
            get { return salary; }
            set { salary = value; }
        }

        public override decimal Payment() {
            return salary;
        }
    }
}
