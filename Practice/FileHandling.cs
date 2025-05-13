using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Practice;
internal class FileHandling
{

    //for store object data
    public void Handling()
    {
        //FileStream fs = new FileStream(@"D:\Workspace\File handling practice\newFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        try
        {
            using (StreamWriter writer = new StreamWriter(@"D:\New Folder\File.txt"))
            {
                int studentId = 1;
                string studentName = "Boobathi ";
                double[] marks = { 90.5, 85.0, 78.5, 45, 90 };
                string grade = "pass";
                writer.WriteLine($"{studentId},{studentName},{marks[0]}:{marks[1]}:{marks[2]}:{marks[3]}:{marks[4]},{grade}");
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            LogFile(e);
        }
        finally
        {
            Console.WriteLine("File created successfully");
        }
    }


    public void StoreLogFils()
    {
        try
        {
            int a = 10;
            int b = 0;
            int c = a / b;
            Console.WriteLine(c);
        }
        catch(ArithmeticException e)
        {
            Console.WriteLine(e.Message);
            LogFile(e);
        }
    }

    public void LogFile(Exception e)
    {
        using (StreamWriter writer = new StreamWriter($@"D:\Workspace\File handling practice\Error_Log_{DateTime.Now.ToString("dd-MM-yyyy")}.txt", true))
        {
            writer.WriteLine("========================================================");
            writer.WriteLine("Source: " + e.Source);
            writer.WriteLine("Message : " + e.Message);
            writer.WriteLine("StackTrace: \n" + e.StackTrace +"\n");
            writer.WriteLine("Date: " + DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss"));
            writer.WriteLine("=======================================================");
        }
    }
}
