using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureIncSharp
{
    internal class Program
    {
        public static int Id { get; private set; }
        public static string Name { get; private set; }

        static void Main(string[] args)
        {
            Customer c1 = new Customer(101, "Mark");
            c1.PrintDetails();

            Customer c2 = new Customer();
            c2.Id = 102;
            c2.Name = "Jolly";
            c2.PrintDetails();

            Customer c3 = new Customer
            (
                Id = 103,
                Name = "Rob"
            );
            c3.PrintDetails();
        }
    }

    public struct Customer
    {
        private string _name;
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} and Name = {1}", Id, Name);
        }
    }
}
