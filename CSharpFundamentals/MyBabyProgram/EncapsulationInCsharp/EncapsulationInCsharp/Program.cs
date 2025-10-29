using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PropertiesInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                Marking class filed public and exposing it to the external 
                fields bas as we will not have control over what gets assigned 
                returned

                Allowing this to happen violates bussines rules as id cannot be
                negative, name cannot be null or spcase and pass mark cannot be 
                modified.

                We must restrict the access of these class memebers variables and
                take contorl over, what can be changed and what to be returned.
            
                We  use the concept of getter and setter method making 
                class variables as private
            */

            Student c1 = new Student();
            c1.Id = 1;
            c1.Name = "test";

            Console.WriteLine("Student Id = {0}",c1.Id);
            Console.WriteLine("Studen name = {0}",c1.Name);
            Console.WriteLine("Marks = {0}",c1.PassMark);

        }
    }


    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;
        private string _city;
        private string email { get; set; }


        /* 
            This can also be implemented using auto implemented properties.
            compilers will create private, anonymous field that can only be
            accessed through get and set accessories

            check line 49 to see the example of auto implemented properties
        */
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student id cannot be negative");
                }
                this._id = value;
            }

            get
            {
                return this._id;
            }
        }

        //read and write properties
        public string Name
        {
            get
            {
                return (string.IsNullOrEmpty(this._name)) ? "No Name" : this._name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be empty or null");
                }
                this._name = value;
            }
            
        }

        //read only properties
        public int PassMark
        {
            get
            {  
                return this._passMark; 
            }
        }
    }

}
