using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment;
class ATMmenu
{
    decimal balance;

    public void showOption()
    {
        Console.WriteLine("a.Check Balance");
        Console.WriteLine("b.Deposit");
        Console.WriteLine("c.Withdraw");
        Console.WriteLine("d.Exit");
        Console.Write("Enter your choice : ");
    }

    public char getOption()
    {
        char choice;
        char.TryParse(Console.ReadLine(), out choice);
        return choice;
    }

   
    public void banking()
    {
        Console.WriteLine("ATM machine");
        char choice;
        decimal deposit_amount;
        decimal withdraw_amount;
        do {
            Console.WriteLine("===========================================================");
        showOption();
        choice = getOption();
            switch (choice)
            {
                case 'a':
                    Console.WriteLine($"The available balance in you account is {balance}");
                    break;
                case 'b':
                    Console.Write("Enter the amount that you want to deposit : ");
                    decimal.TryParse(Console.ReadLine(), out deposit_amount);
                    balance += deposit_amount;
                    Console.WriteLine("your about is credited to your account");
                    goto case 'a';
                    break;
                case 'c':
                    Console.WriteLine($"The available balance in you account is {balance}");
                    Console.Write("Enter the amount that you want to withdraw : ");
                    decimal.TryParse(Console.ReadLine(), out withdraw_amount);
                    if (balance > withdraw_amount)
                    {
                        balance -= withdraw_amount;
                        Console.WriteLine("The amount is debited successfully..");
                        goto case 'a';
                    }
                    else
                        Console.WriteLine("You don't have a suffiecient amount to withdraw");
                        break;
                case 'd':
                    Console.WriteLine("Thanks for do the banking");
                    break;
            }
        } while (choice != 'd');
    }
}
