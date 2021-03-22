using System;
using TreinamentoDia4_Heranca.Entities;

namespace TreinamentoDia4_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account acc = new Account(1001, "Alex", 0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Ana", 0, 500);

            //// UPCASTING

            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0, 200);
            //Account acc3 = new SavingsAccount(1004, "Maria", 0, 0.01);

            //// DOWNCASTING

            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100);

            ////BusinessAccount acc5 = (BusinessAccount)acc3;

            //if(acc3 is BusinessAccount)
            //{
            //    BusinessAccount acc5 = acc3 as BusinessAccount; // = BusinessAccount acc5 = (BusinessAccount)acc3;
            //    acc5.Loan(200);
            //    Console.WriteLine("Loan!");
            //}

            //if(acc3 is SavingsAccount)
            //{
            //    SavingsAccount acc5 = acc3 as SavingsAccount; // = SavingsAccount acc5 = (SavingsAccount)acc3;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Update!");
            //}

            // Sobreposição

            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingsAccount(1002, "Ana", 500, 0.01);

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
