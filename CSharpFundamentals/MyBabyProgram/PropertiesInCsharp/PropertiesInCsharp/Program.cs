using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            */

            Student c1 = new Student();
            //c1.id = -1;
            //c1.name = null;
            //c1.passMark = 0;

            //Console.WriteLine("Id = {0}, Name = {1}", c1.id, c1.name);

            /*
                Allowing this to happen violates bussines rules as id cannot be
                negative, name cannot be null or spcase and pass mark cannot be 
                modified.

                We must restrict the access of these class memebers variables and
                take contorl over, what can be changed and what to be returned.
            
                We  use the concept of getter and setter method making 
                class variables as private
            */

            //Since we have made class atrributes as private we can only set
            //value using its method.

            c1.setId(101);
            c1.setName("TEW");

            Console.WriteLine("Id = {0}, Name = {1}", c1.getId(), c1.getName());

        }
    }


    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;

        public void setId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Student id cannot be negative");
            }
            this._id = id;
        }

        public int getId()
        {
            return this._id;
        }

        public string getName()
        {
            return (string.IsNullOrEmpty(this._name)) ? "No Name" : this._name;
        }

        public void setName(string name)
        {

            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty or null");
            }
            this._name = name;
        }

        public int getPassMark()
        {
            return this._passMark;
        }
    }

}
