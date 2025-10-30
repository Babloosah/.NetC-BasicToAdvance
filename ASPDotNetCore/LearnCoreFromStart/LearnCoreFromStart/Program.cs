using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);  // This Create castrol server and generate builder object
var app = builder.Build();              // when cllaing .Build() method on builder object, it create an instance of web application. So App is our web application

//app.MapGet("/", () => "Hello World!");   // middleware pipline component route. These codes are not exceutd in sequence. The Middleware component execute when the castorl service recieves the http request.


app.Run(async (HttpContext context) =>
{
    if (context.Request.Path.StartsWithSegments("/employees"))
    {
        if (context.Request.Method == "GET")
        {
            var employees = EmploeeRepository.GetEmployee();
            foreach (var employee in employees)
            {
                await context.Response.WriteAsync($"{employee.Name} : {employee.Position} \n");
            }
            return;
        }

        else if (context.Request.Method == "POST")
        {
            using var reader = new StreamReader(context.Request.Body);
            var body = await reader.ReadToEndAsync();
            var employee = JsonSerializer.Deserialize<Employee>(body);

            EmploeeRepository.AddEmployee(employee);
            context.Response.StatusCode = 201;
            return;
        }

        else if (context.Request.Method == "PUT")
        {
            using var reader = new StreamReader(context.Request.Body);
            var body = await reader.ReadToEndAsync();
            var employee = JsonSerializer.Deserialize<Employee>(body);

            EmploeeRepository.UpdateEmployee(employee);
            return;
        }

        else if (context.Request.Method == "DELETE")
        {
            var id = context.Request.Query["Id"];
            if (int.TryParse(id, out int empId))
            {
                if (context.Request.Headers["Authorization"] == "bob")
                {
                    var result = EmploeeRepository.DeleteEmployee(empId);

                    if (result)
                    {
                        context.Response.StatusCode = 204;
                        await context.Response.WriteAsync($"Employee with id {empId} was deleted.");
                    }
                    else
                    {
                        context.Response.StatusCode = 404;
                        await context.Response.WriteAsync("Employee delete opertaion failed.");
                    }
                }
                else
                {
                    context.Response.StatusCode = 401;
                    await context.Response.WriteAsync("Operation Unauhtorized.");
                }
            }
            return;
        }
        else 
        { return; }
    }
    else if (context.Request.Path.StartsWithSegments("/"))
    {
        if (context.Request.Method == "GET")
        {
            context.Response.Headers["Content-Type"] = "text/html";

            await context.Response.WriteAsync($"The method is : {context.Request.Method}  <br/>");
            await context.Response.WriteAsync($"The url is: {context.Request.Path}  <br/>");

            await context.Response.WriteAsync($"<b> Headers: </b> <br/>");
            await context.Response.WriteAsync("<ul>");

            foreach (var key in context.Request.Headers.Keys)
            {
                await context.Response.WriteAsync($"<li>{key} :  {context.Request.Headers[key]} </li>");
            }
            await context.Response.WriteAsync("</ul>");
            return;
        }
        else
        { return; }
    }
    else if (context.Request.Path == "/favicon.ico")
    {
        return;
    }
    else
    {
        context.Response.StatusCode = 400;
        await context.Response.WriteAsync($" Invalid URL method was passed");
        return;
    }
});

app.Run();  // it start the castrol service and run the application in infinte loop, It makes the castorl service listen to incoming http request can convert it to httpcontext object. 


static class EmploeeRepository
{
    private static List<Employee> employees = new List<Employee>
    {
        new Employee(1,"Esu","Boss",789456),
        new Employee(2,"Amu","Teacher",567783),
        new Employee(3,"bob","Student",567438)
    };

    public static List<Employee> GetEmployee() => employees;

    public static void AddEmployee(Employee? employee) 
    {  
        if (employee is not null)
        { 
            employees.Add(employee); 
        }
    }

    public static void UpdateEmployee(Employee? employee)
    {
        if (employee is not null)
        {
            var emp = employees.FirstOrDefault( e => e.Id == employee.Id);

            if ( emp is not null)
            {
                emp.Id = employee.Id;
                emp.Name = employee.Name;
                emp.Position = employee.Position;
                emp.Salary = employee.Salary;
            }
        }
    }

    public static bool DeleteEmployee ( int Id)
    {
        var emp = employees.FirstOrDefault(e => e.Id == Id);
        if ( emp is not null)
        {
            employees.Remove(emp);
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Employee
{
    public int Id { get; set; }
    public string Name {  get; set; }

    public string Position { get; set; }

    public int Salary { get; set; }

    public Employee(int id , string name, string position, int salary) 
    {
        Id = id;
        Name = name;
        Position = position;
        Salary = salary;
    }

}