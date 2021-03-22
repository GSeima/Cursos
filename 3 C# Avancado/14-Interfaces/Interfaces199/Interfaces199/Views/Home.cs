using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Interfaces199.Entities;
using Interfaces199.Services;

namespace Interfaces199.Views
{
    class Home
    {
        public override string ToString()
        {
            Console.WriteLine("Enter contract data: ");

            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months);   

            Console.WriteLine("Installments: ");

            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }

            return "";
        }
    }
}
