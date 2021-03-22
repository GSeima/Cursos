using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Interfaces194.Entities;
using Interfaces194.Services;

namespace Interfaces194.View
{
    public class TelaInicial
    {
        public override string ToString()
        {
            Console.WriteLine("Enter rental data: \n");

            Console.Write("Car Model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");

            Console.Write(carRental.Invoice);

            return "";
        }
    }
}
