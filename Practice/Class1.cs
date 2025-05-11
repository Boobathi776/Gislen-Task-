using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Assignment.Practice
{
    internal class Class1
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void WritingFile()
        {
            //string filePath = ConfigurationManager.AppSettings["Directory path"];
            //Console.WriteLine(filePath);

            //string filename = Console.ReadLine();
            //string fileNameWithPath = Path.Combine(filePath, filename);
            //if(File.Exists(fileNameWithPath))
            //{
            //    File.WriteAllText(fileNameWithPath, "hey naan solren la try panni paaru ");
            //}
            //else
            //{
            //    Console.WriteLine("The file doesn't exist");
            //    File.Create(fileNameWithPath);
            //}

            //Directory.CreateDirectory(Path.GetDirectoryName(@"D:\Workspace\File handling practice\durai\durai.txt"));
            //Console.WriteLine("ok da");
            //using (StreamWriter wroter = new StreamWriter(@"D:\Workspace\File handling practice\durai.txt"))
            //{
            //    wroter.WriteLine("naan than da leo");
            //}
            //int a = 5, b = 6;
            //switch ((a, b))
            //{
            //    case (5, 6) when a < b:
            //        Console.WriteLine("1");
            //        break;
            //}
            //int[] arr = {1,2, 3, 4, 5 };
            //int val=Array.Find(arr,a => a > 3);
            //Console.Write(val);

            List<int> list = new List<int>() { 1,2,3,4,5};
            int num = list.Find(l => l >= 3);
            Console.WriteLine(num);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Count(l => l < 5));
            
        }
      
       
    }
}
