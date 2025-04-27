using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment;
 class ReverseArray
{
    int[] arr = new int[5];
    int num;
    public void getValue()
    {
        for(int i=0;i < 5; i++)
        {
            Console.Write($"Enter no {i + 1} : ");
            int.TryParse(Console.ReadLine(), out num);
            arr[i] = num;
        }
    }

    public void reverse()
    {
        int left = 0;
        int right = arr.Length - 1;
        int mid = (left + right) / 2;
        for (int i = 0; i < mid; i++)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
    }

    public void printValue()
    {
        foreach(int i in arr)
        {
            Console.WriteLine(i);
        }
    }

   public void average()
    {
        double total=0;
        double avg;
        foreach(int i in arr)
        {
            total+= i;
        }
        Console.WriteLine(total);
        avg =(double)( total/arr.Length);
        Console.WriteLine($"The average of given numbers is : {avg}");
    }
}
