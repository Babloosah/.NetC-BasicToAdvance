using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_TypeMemberInCsharp
{

    /*
        
        This customer class has 3 private filed, 3 public properties and
        1 method. Since, All these reside insde the class, its called as
        class members. We also call it as Type members.

        So, in general classes, structs, enums, interfaces, delegates are 
        called as types and fileds, properties, constructors, method, etc,
        that normally reside in a type are called as type members.

        In C# there are 5 types of access modifiers.
            1. Private
            2. Protected
            3. Internal
            4. Protected Internal
            5. Public

        Type membbers can have all the access modifiers where as types 
        can only have 2 (internal, public) of those 5 access modifiers

        Using Region you can expand and collapse secitions of your code
        either manually or by using visual studion edit -> outlining ->
        all Outlining


     */
    public class Customer
    {
        #region privateFields
        private int _id;
        private string _firstName;
        private string _lastName;
        #endregion


        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string GetFullName()
        {
            return this._firstName + " " + this._lastName;
        }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }


}
