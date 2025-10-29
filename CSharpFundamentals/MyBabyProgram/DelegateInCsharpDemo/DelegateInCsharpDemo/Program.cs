using System;
using System.Collections.Generic;
class Program
{

    static void Main(string[] args)
    {

        List<Employee> emplist = new List<Employee>();
        emplist.Add(new Employee() { id = 101, name = "Marry", salary = 5000, Experience = 5 });
        emplist.Add(new Employee() { id = 102, name = "Mike", salary = 4000, Experience = 4 });
        emplist.Add(new Employee() { id = 102, name = "John", salary = 6000, Experience = 6 });
        emplist.Add(new Employee() { id = 102, name = "Tod", salary = 3000, Experience = 3 });

        IsPromotable ispromatable = new IsPromotable(Promote);

        Employee.PromoteEmployee(emplist, ispromatable);

        //another way to do same is by using lambda expression

        Employee.PromoteEmployee(emplist, emp => emp.Experience >= 5);

    }

    public static bool Promote(Employee emp)
    {
        if (emp.Experience >= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



}

public delegate bool IsPromotable(Employee empl);

public class Employee
{
    public int id { get; set; }
    public string name { get; set; }
    public int salary { get; set; }
    public int Experience { get; set; }


    /*
     The below class has hard coded logic to promote employee
     based on experience. What if i need to promote based on 
     salary. I cannot use the same method. 

    This can be obtained using delegates. it makes your fucntion 
    reusable.

    delegates are extensively used by framework developers.

     */
    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach (Employee emp in employeeList)
        {
            if (IsEligibleToPromote(emp))
            {
                Console.WriteLine(emp.name + "Promoted");
            }
        }
    }


}