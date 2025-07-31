using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WaiteringSystem.Business.Role;
/* Sivuyise Matwa
 * 03 August 2024
 * 
 */
namespace WaiteringSystem.Business
{
    public class Runner: Role
    {
        private decimal _tips;
        private int _rate;
        private int _noOfShift;

        public Runner() : base() { 
            RoleVal = RoleType.Runner;
            description = "Runner";
            getNoOfShift = 0;
            _rate = 0;
            _tips = 0;
        }
        public Runner(int tips,int rate, int noOfShoft, string descrip, RoleType ROLEVAL) : base(descrip, ROLEVAL) { 
            description = descrip;
            roleval = ROLEVAL;
            this.tips = tips;
            this.rate = rate;
            this._noOfShift = noOfShoft;
        }
        public int tips {
            get { return tips; } set { tips = value; }
        }

        public int rate { 
            get { return rate; } set { rate = value; }
        }
        public int getNoOfShift { 
            get { return _noOfShift; } set { _noOfShift = value; }
        }

        public int Payment() {
            return rate * _noOfShift;
        }

        public int Payment(int noOfTips) { 
            return rate * _noOfShift + noOfTips ;
        }
    }
}
