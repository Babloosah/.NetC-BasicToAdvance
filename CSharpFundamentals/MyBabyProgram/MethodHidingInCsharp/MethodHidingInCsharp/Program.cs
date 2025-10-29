using System;

public class Employee
{
    public string firstName;
    public string lastName;

    public void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName);  
    }
}


public class PartTimeEmployee :  Employee
{

    /*
     * Using same method tat is present in base class will be hidden with 
       derived class method. We use New keywoard.
     
     * We can call the hidden base class method using base keyword from
       base class. See line number 29.

     * Another way to do this is by typecasting the derived class object
       with the base class
     */
    public new void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName + " - Contractor");

        base.PrintFullName();
    }

}

public class FullTimeEmployee : Employee
{

}


public class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.firstName = "FullTIme";
        FTE.lastName = "Employee";
        FTE.PrintFullName();

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.firstName = "PartTime";
        PTE.lastName = "Employee";
        PTE.PrintFullName();

        //typecasting child class insatnace with base class.
        ((Employee)PTE).PrintFullName();

        /* A child class reference variable can not point to base class object whereas
            parent class object variable can point to child class object.
            Uncomment below lines of code to see it.
        */

        Employee e = new PartTimeEmployee();
        //PartTimeEmployee pte1 = new Employee();
    }
}
