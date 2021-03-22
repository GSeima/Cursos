using System;
using System.Globalization;
using TreinamentoDia5_Section11_146.Entities;
using TreinamentoDia5_Section11_146.Entities.Exceptions;

namespace TreinamentoDia5_Section11_146
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(amount);

                Console.WriteLine(account);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
