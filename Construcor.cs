using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment;

internal class Construcor
{
    public int a;
    public Construcor()
    {
        Console.WriteLine("This is a default constructor");
    }
   
    public Construcor(int a)
    {
        this.a = a;
        Console.WriteLine("This is a constructor with parameter");
    }

}
