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
    public class Waiter : Role
    {
        private int _tips;
        private int _rate;
        private int _noOfShift;

        public Waiter() : base() { 
        }
        public Waiter(int tips, int rate, int shift, string descrip, RoleType ROLEVAL) : base(descrip,ROLEVAL) {
            description = descrip;
            roleval = ROLEVAL;
            this._tips = tips;
            this._rate = rate;
            this._noOfShift = shift;
        }
        public int tips { get { return _tips; } set { _tips = value; } }
        public int rate { get { return _rate; } set { _rate = value; } }
        public int noOfShift { get { return _noOfShift; } set { _noOfShift = value; } }

        public int Payment(int noTips) {
            return _rate * noOfShift + noTips;
        }
    }
}
