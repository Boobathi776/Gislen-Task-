using System;
namespace Assignment;

public class CalculatorCalc
   {
    double total;
    double num;
    int i = 1;
    char haveExtraNumber = 'y';
    public void callCalculator()
    {
        Console.WriteLine("CALCULATOR");
        char choice ;
        showOption();

        //choice = Convert.ToChar(Console.ReadLine());
        choice=askOption();
      
        do
        {
            switch (choice)
            {
                case 'a':
                    Console.WriteLine("ADDITION");

                    do
                    {
                        Console.Write("Enter the " + i + " number : ");
                        try
                        {
                            num = Convert.ToInt32(Console.ReadLine());
                        }catch(Exception e)
                        {
                            //Console.WriteLine(e.Message);
                            Console.WriteLine("Please enter a valid number");
                        }

                        total += num;
                        haveExtraNumber = askYesOrNo();
                        i++;
                    } while ('y' == haveExtraNumber);

                    Console.WriteLine("The sum of given number is : " + total);
                    total = 0;
                    i = 1;
                    num = 0;
                    Console.WriteLine("=======================================================================");
                    showOption();
                    choice = askOption();
                    break;

                case 'b':
                    Console.WriteLine("SUBTRACTION");
                    do
                    {
                        Console.Write("Enter the " + i + " number : ");
                        try
                        {
                            num = Convert.ToInt32(Console.ReadLine());

                        }
                        catch (Exception e)
                        {
                            //Console.WriteLine(e.Message);
                            Console.WriteLine("Please enter a valid number");
                        }
                        if(i==1) total = num;
                        else total -= num;
                          
                        haveExtraNumber = askYesOrNo();
                        i++;
                    } while ('y' == haveExtraNumber);

                    Console.WriteLine("The subtraction of given numbers is : " + total);
                    total = 0;
                    i = 1;
                    num = 0;
                    Console.WriteLine("=======================================================================");
                    showOption();
                    choice = askOption();
                    break;

                case 'c':
                    Console.WriteLine("Multiplication");
                    total = 1;
                    do
                    {
                        Console.Write("Enter the " + i + " number : ");
                        try
                        {
                            num = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            //Console.WriteLine(e.Message);
                            Console.WriteLine("Please enter a valid number");
                        }

                        total *= num;
                        haveExtraNumber = askYesOrNo();
                        i++;
                    } while ('y' == haveExtraNumber);

                    Console.WriteLine("The Multiply of given numbers is : " + total);
                    total = 0;
                    i = 1;
                    num = 0;
                    Console.WriteLine("=======================================================================");
                    showOption();
                    choice = askOption();
                    break;

                case 'd':
                    Console.WriteLine("DIVISION");

                    do
                    {
                        Console.Write("Enter the " + i + " number : ");
                        try
                        {
                            num = Convert.ToInt32(Console.ReadLine());
                           
                        }
                        catch (Exception e)
                        {
                            //Console.WriteLine(e.Message);
                            Console.WriteLine("Please enter a valid number");
                        }

                        if (i == 1) total = num;
                        else if (num > 0) total /= num;
                        else Console.WriteLine("We can't divide the numbers with Zero");
                            haveExtraNumber = askYesOrNo();
                        i++;
                    } while ('y' == haveExtraNumber);

                    Console.WriteLine("The division of given number is : " + total);
                    total = 0;
                    i = 1;
                    num = 0;
                    Console.WriteLine("=======================================================================");
                    showOption();
                    choice = askOption();
                    break;

                case 'e':
                    Console.WriteLine("Square Root");

                    do
                    {
                        Console.Write("Enter the " + i + " number : ");
                        try
                        {
                            num = Convert.ToInt32(Console.ReadLine());

                        }
                        catch (Exception e)
                        {
                            //Console.WriteLine(e.Message);
                            Console.WriteLine("Please enter a valid number");
                        }

                        if (i == 1) { 
                            total = Math.Sqrt(num);
                        }
                        else
                        {
                            total += num;
                            total = Math.Sqrt(total);
                        }
                        
                        haveExtraNumber = askYesOrNo();
                        i++;
                    } while ('y' == haveExtraNumber);

                    Console.WriteLine("The Square Root  of given number is : " + total);
                    total = 0;
                    i = 1;
                    num = 0;
                    Console.WriteLine("=======================================================================");
                    showOption();
                    choice = askOption();
                    break;

                case 'f':
                    Console.WriteLine("POWER");
                    int num1=0;
                    int num2=0;
                   
                        //Console.Write("Enter the " + i + " number : ");
                        try
                        {
                            Console.Write("Enter the number 1 : ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the number 2 : ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            //Console.WriteLine(e.Message);
                            Console.WriteLine("Please enter a valid number");
                        }

                        total = Math.Pow(num1, num2);

                    Console.WriteLine($"{num1} Power {num2} is : " + total);
                    total = 0;
                    i = 1;
                    num = 0;
                    Console.WriteLine("=======================================================================");
                    showOption();
                    choice = askOption();
                    if (choice == 'g') Console.WriteLine("The Calculator is shutdown...");
                    break;


                case 'g':
                    Console.WriteLine("come again..");
                    break;

                default:
                    Console.WriteLine("wrong entry");
                    showOption();
                    choice = askOption();
                    break;
                
            }
        } while (choice != 'g');

    }

    void showOption()
    {
        Console.WriteLine("a. Addition");
        Console.WriteLine("b. subtraction");
        Console.WriteLine("c. multiplication");
        Console.WriteLine("d. division");
        Console.WriteLine("e. Square Root");
        Console.WriteLine("f. Power");
        Console.WriteLine("g. Exit");
    }

    char askOption()
    {
        Console.Write("Enter Your choice: ");
        string input = Console.ReadLine();

        if ( input.Length == 1 && input != " ")
        {
            return input.ToLower()[0]; 
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter exactly one character.");
            return askOption(); 
        }
    }

    char askYesOrNo()
    {
        Console.Write("if you have numbers to add then enter 'y' else 'n' : ");

        string input = Console.ReadLine();

        if (input.Length == 1 && input != " ")
        {
            return input.ToLower()[0]; 
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter exactly one character.");
            return askYesOrNo();
        }
    }


}
