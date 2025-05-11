using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment.Practice
{
    internal class ConstructorDoubt
    {
       public ConstructorDoubt()
        {

        }
    }


    class ConstructorDoubt1
    {
        public void CreateObject()
        {
            ConstructorDoubt constructorDoubt = new ConstructorDoubt();
            Console.WriteLine("Object created");
        }
    }
}
