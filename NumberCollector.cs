using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment;
 class NumberCollector
{
    public void collecting()
    {
        string text;
        int num;
        bool state;
        List<int> numbers = new List<int>();
        Console.WriteLine(" Safe Number Collector");
        do
        {
        Doing:
            Console.Write("Enter a Number or \"exit\" : ");
            text = Console.ReadLine();
            if (text == "exit") break;
            else state = int.TryParse(text, out num);
            if (state)
                numbers.Add(num);
            else { Console.WriteLine("Enter a valid value...");
                goto Doing;
            }
        } while (true);

        int[] arr = new int[numbers.Count];
        int i = 0;
        foreach(int n in numbers)
        {
            arr[i] = n ;
            i++;
        }
        //Console.WriteLine(arr);
        foreach(int item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
