using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 10000;

            Console.WriteLine("Welcome to Virtual Bank");
            bankLoop(balance);
        }
        public static void bankLoop(int balance)
        {
            string userInput;
            string action;

            Console.WriteLine("V - View Balance         D - Make Deposit");
            Console.WriteLine("W - Make Withdrawal      E - Exit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();
            action = userInput.ToLower();

            if (action == "v" || action == "d" || action == "w")
                transaction(action, balance);
            else if (action != "e")
            {
                Console.WriteLine();
                Console.WriteLine("I did not understand that.");
                Console.WriteLine();
                bankLoop(balance);
            }
        }
        public static void transaction(string action, int balance)
        {
            int amount;

            if (action == "d")
            {
                Console.Write("Enter an amount: ");
                amount = Convert.ToInt32(Console.ReadLine());
                balance = balance + amount;
                Console.WriteLine("Your account balance is " + "{0:C}", balance);   // 2nd print for debugging purpose
                Console.WriteLine("Your account balance is " + "{0:C}", balance);   // to change value in locals window
                Console.WriteLine();                                                
                bankLoop(balance);
            }
            else if (action == "w")
            {
                Console.Write("Enter an amount: ");
                amount = Convert.ToInt32(Console.ReadLine());
                balance = balance - amount;
                Console.WriteLine("Your account balance is " + "{0:C}", balance);
                Console.WriteLine();
                bankLoop(balance);
            }
            else
            {
                Console.WriteLine("Your account balance is " + "{0:C}", balance);
                Console.WriteLine();
                bankLoop(balance);
            }
        }
    }
}
