using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDia4_Section10_137.Entities
{
    class Company : Person
    {
        public int Employees { get; set; }

        public Company()
        {

        }

        public Company(string name, double income, int employees) : base(name, income)
        {
            Employees = employees;
        }

        public override double Total()
        {
            if (Employees > 10)
            {
                return Income * 0.14;
            }
            else
            {
                return Income * 0.16;
            }
        }
    }
}
