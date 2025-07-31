using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiteringSystem;
/* Sivuyise Matwa
 * 03 August 2024
 * 
 */
namespace WaiteringSystem.Business
{
    public class Employee : Person
    {
        #region Fields
        private string _id;
        public Role _role;

        #region constructor
        public Employee(Role roleValue) {
            switch (roleValue.RoleVal) {
                case 0:
                    roleValue = new Role();
                    break;
                case (Role.RoleType)1:
                    roleValue = new Headwaiter();
                    break;
                case (Role.RoleType)2:
                    roleValue = new Waiter();
                    break;
                case (Role.RoleType)3:
                    roleValue = new Runner();
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        #region Properties
        public string id
        {
            get { return id; }
            set { id = value; }
        }

        public string role
        {
            get { return role; }
            set { role = value; }
        }
        #endregion
    }
    #endregion
}
#endregion
