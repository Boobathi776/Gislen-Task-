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
        List<int> numbers = new List<int>();
        Console.WriteLine(" Safe Number Collector");
        do
        {
            Console.Write("Enter a Number : ");
            int.TryParse(Console.ReadLine(), out num);
            numbers.Add(num);
            Console.Write("Enter 'y' if you have extra numbers to add else type 'exit' : ");
            text = Console.ReadLine();

        } while (text != "exit");

        int[] arr = new int[numbers.Count];
        int i = 0;
        foreach(int n in numbers)
        {
            arr[i] = n ;
            i++;
        }
        Console.WriteLine(arr);
        foreach(int item in arr)
        {
            Console.WriteLine(item);
        }
    }
}
