using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Practice;

internal class StaticConstrucor
{
    public int Name { get; set; }
    public static int Age { get; set; }
     static StaticConstrucor()
    {
        Console.WriteLine("Static constructor called");
    }

    public static void Display()
    {
        Console.WriteLine("static void method");
    }

    public void Display1()
     {
        Console.WriteLine("non static void method");
    }
}
