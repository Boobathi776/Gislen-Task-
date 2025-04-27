using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Assignment;
 class SecondNumber
{
    int n;
    public int[] getValue()
    {
        Console.WriteLine("As per the instruction enter 10");
        Console.WriteLine("Enter no of Values : ");
        int.TryParse(Console.ReadLine(), out n);
        int[] values = new int[n];
        for (int i = 0; i < values.Length; i++)
        {
            Console.Write($"Entet Value {i+1} : ");
            int.TryParse(Console.ReadLine(), out values[i]);
            Console.WriteLine();
        }

        return values;
    }
    public void findSecondNumber(int[] values)
    {
        int firstBiggestNumber = values[0];
        int secondBiggestNumber = values[1];
        for(int i=0;i< values.Length; i++)
        {
           if(firstBiggestNumber <= values[i])
            {
                secondBiggestNumber = firstBiggestNumber;
                firstBiggestNumber = values[i];
            }
           else if(secondBiggestNumber <= values[i])
            {
                secondBiggestNumber = values[i];
            }
        }

        Console.WriteLine($"The second largest number is : {secondBiggestNumber}");
    }
}
