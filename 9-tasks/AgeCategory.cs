using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment;
 class AgeCategory
{
    public void checkAge()
    {
        Console.WriteLine("Age category checker");
        int age;
    age:
        Console.Write("Enter your age : ");
        int.TryParse(Console.ReadLine(), out age);
        if (age > 0 && age < 122)
        {
            string category = age < 13 ? "Child" : age >= 13 && age <= 17 ? "Teen" : age >= 18 && age <= 59 ? "Adult" : "Senior";
            Console.WriteLine($"According to your age your category is {category}");
        }
        else
        {
            Console.WriteLine("I think you enter a wrong age of yours chect it");
            goto age;
        }
    }
    }
