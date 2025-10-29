using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersInCSharp
{

    public class Customer
    {
        private int _id;

        public int id
        {
            get 
            { 
                return _id; 
            }
            set 
            { 
                _id = value; 
            }
        }

        protected int _idP;

    }

    public class  CorporateCustomer : Customer
    {
        public void PrintId()
        {
            CorporateCustomer cc = new CorporateCustomer();
            cc._idP = 10;

            this._idP = 10;

            base._idP = 10;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            // c1._id = 1;  this is not allowed

            //c1._idp = 1; this will throw an error as protect members are available
            // withi the class or in inherited class

            c1.id = 1; // only public properties of that private field is accesscible



        }
    }
}
