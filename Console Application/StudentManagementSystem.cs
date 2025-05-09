using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Console_Application;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual void DisplayStudentDetails()
    {
        Console.WriteLine($"Student: {Id}, {Name}");
    }
}
 public class RegularStudent : Student
{
    public string Grade { get; set; }
    public override void DisplayStudentDetails()
    {
        Console.WriteLine($"Regular Student: {Id}, {Name}, {Grade}");
    }
}

public class  ExchangeStudent : Student
{
    public string Grade { get; set; }
    public override void DisplayStudentDetails()
    {
        Console.WriteLine($"Exchange Student: {Id}, {Name}, {Grade}");
    }
}
public  class StudentManagementSystem 
{
    List<Student> students = new List<Student>()
    {
        new RegularStudent { Id = 1, Name = "John Doe", Grade = "A" },
        new RegularStudent { Id = 2, Name = "Jane Smith", Grade = "B" },
        new ExchangeStudent { Id = 3, Name = "Alice Johnson", Grade = "A" },
        new ExchangeStudent { Id = 4, Name = "Bob Brown", Grade = "C" }
    };



    public void RemoveStudent()
    {

        foreach (var student1 in students)
        {
            if (student1 is RegularStudent regularStudent)
            {
                student1.DisplayStudentDetails();
            }
            else if (student1 is ExchangeStudent exchangeStudent)
            {
                student1.DisplayStudentDetails();
            }
        }


        int id = 0;
        Console.WriteLine("Enter the student id that you want to remove : ");
        try
        {
            id = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("The given input is not correct : ");
        }
        var student = students.FirstOrDefault(student => student.Id == id);
        students.Remove(student);
      

        foreach(var student1 in students)
        {
            if (student1 is RegularStudent regularStudent)
            {
                student1.DisplayStudentDetails();
            }
            else if (student1 is ExchangeStudent exchangeStudent)
            {
                student1.DisplayStudentDetails();
            }
        }
    }
}
