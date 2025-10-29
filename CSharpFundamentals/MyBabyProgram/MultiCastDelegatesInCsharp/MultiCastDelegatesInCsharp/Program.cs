using System;

public delegate void SampleDelegate();
class Program
{
    static void Main(string[] args)
    {
        SampleDelegate del = new SampleDelegate(SampleMethod1);
        del();

        SampleDelegate del1, del2, del3, del4;
        del1 = new SampleDelegate(SampleMethod1);
        del2 = new SampleDelegate(SampleMethod2);
        del3 = new SampleDelegate(SampleMethod3);


        /*
           club delegate together using + and - sign .


        */
        del4 = del1 + del2 + del3;
        del4();

    }

    public static void SampleMethod1()
    {
        Console.WriteLine("Sample method invoked");
    }

    public static void SampleMethod2()
    {
        Console.WriteLine("Sample method 2 invoked");
    }

    public static void SampleMethod3()
    {
        Console.WriteLine("Sample method 3 invoked");
    }

}

