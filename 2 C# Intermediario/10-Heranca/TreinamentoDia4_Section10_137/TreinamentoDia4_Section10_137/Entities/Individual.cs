using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDia4_Section10_137.Entities
{
    class Individual : Person
    {
        public double Expenditures { get; set; }

        Individual()
        {

        }

        public Individual(string name, double income, double expenditures) : base(name, income)
        {
            Expenditures = expenditures;
        }

        public override double Total()
        {
            if (Income < 20000)
            {
                return Income * 0.15 - (Expenditures * 0.5);
            }
            else
            {
                return Income * 0.25 - (Expenditures * 0.5);
            }
        }
    }
}
