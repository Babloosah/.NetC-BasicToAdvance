using System;
// using System called as namespace declaration which states that we will use
// class and methods from this name spaces. It is way to organize your code 
// and reuse it in differenr project. it is colletion of class, structs, enums,delegates and interfaces.
// it may include other namespaces too.

internal class Program
{

    /* on excueting code without call to MEthodBeforeMain() method,
     it will only display The engineers way. We also must call 
     MethodAfterMain() method to display "Method after main"
     */
    static void MethodBeforeMain()
    {
        Console.WriteLine("Method before main");
    }

    static void Main()
    {
        Console.WriteLine("The Engineers Way");
        MethodAfterMain();
        MethodBeforeMain();
    }

    static void MethodAfterMain() 
    {
        Console.WriteLine("Method after Main");
    }
}
