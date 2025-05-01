using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment;
class CalculatorTypeConversion
{
    double num;
    public double getValue()
    {
        Console.Write("Enter the number : ");
        try
        {
            num = Convert.ToDouble(Console.ReadLine());
        }catch(Exception e)
        {
            Console.WriteLine("Enter a number please...");
        }
        return num;
    }

    //public void showOption()
    //{
    //    Console.WriteLine("a.Addition");
    //    Console.WriteLine("b.Subtraction");
    //    Console.WriteLine("c.Multiplicaiton");
    //    Console.WriteLine("d.Division");
    //    Console.Write("Enter your choice : ");
    //}

    //public char getOption()
    //{
    //    char choice;
    //    char.TryParse(Console.ReadLine(), out choice);
    //    return choice;
    //}

    public void showResult(double num1 , double num2 )
    {
       
                double result;
                result = num1 + num2;
                Console.WriteLine($"The sum of given numbes is {result}");
            
                 result = num1 - num2;
                Console.WriteLine($"The subtraction of given numbers is {result}");
               
                result = num1 * num2;
                Console.WriteLine($"The multiplication of given numbers is {result}");

                if(num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"The division of given numbers is {result}");
                }
                else
                {
                    Console.WriteLine("The number is not divisible by Zero");
                }
                  
    }


}
