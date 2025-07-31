using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Sivuyise Matwa
 * 03 August 2024
 * 
 */

namespace WaiteringSystem
{
    public abstract class Person
    {
        #region Fields
        private string _ID;
        private string _Name;
        private string _Phone;

        #region Constructors
        public Person()
        {
            ID = "";
            Name = "";
            Phone = "";
        }
        public Person(string iD, string name, string phone)
        {
            this._ID = iD;
            this._Name = name;
            this._Phone = phone;
        }

        #region Properties

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        public void toString()
        {
            Console.WriteLine(Name + "\n " + Phone);
        }
        #endregion
    }
    #endregion

}
// An abstract class is flaged with the key word "abstract" when it is created
// an abstract class cannot be instantiated but you can create type of thereof
// An abstract class, usually have just declared methods, that is they just declared and not implemented
// It is public
#endregion
