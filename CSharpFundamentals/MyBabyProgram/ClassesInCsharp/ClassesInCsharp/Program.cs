using System;
using System.Runtime.CompilerServices;

public class Customer
{
    string _firstname;
    string _lastname;

    /*
     * Constructor is called to initialize the field of class.
     * it has same name as class.
     * it gets called autmatically when we create instance of the class.
     * 
     * if no constructor is codded, .Net framework adds default parameter less
     * constructor
     */

    public Customer()
    {
        this._firstname = "No Firtsname provided";
        this._lastname = "No Lastname provided";
    
    }

    //this can also be written as 
    //public Customer(): this("No Firtsname provided", "No Lastname provided")
    //{
    //}

    //Below is the parameterized constructor.
    public Customer(string Firstname, string Lastname)
    {
        this._firstname = Firstname;
        this._lastname = Lastname;
    }

    public void PrintFullNAme()
    {
        Console.WriteLine("Full Name = {0}", this._firstname + " " + this._lastname);
    }

    /*
     * Destructor is not require din C#.
     * it cleans up the resource.
     * it is called automatically by garbage collector.
     */ 

    ~Customer() 
    {
        //clean up code
    }


}

public class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer("Tew","Technologies");
        Customer c2 = new Customer();
        c1.PrintFullNAme();
        c2.PrintFullNAme();
    }
}

