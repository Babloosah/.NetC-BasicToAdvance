using System;

public class Employee
{
    public string firstName = "FN";
    public string lastName = "LN";

    public virtual void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName);
    }
}

public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName + " - Part Time");
    }
}

public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName + " - Full Time");
    }
}

public class TemporayrEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName + " - Temporary");
    }
}

public class Program
{
    public static void Main()
    {
        Employee[] employees = new Employee[4];
        employees[0] = new Employee();
        employees[1] = new PartTimeEmployee();
        employees[2] = new FullTimeEmployee();
        employees[3] = new TemporayrEmployee();

        foreach (Employee e in employees)
        {
            e.PrintFullName();
        }
        
    }
}
