using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDia4_Section10_137.Entities
{
    class Person
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Person()
        {

        }

        public Person(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public virtual double Total()
        {
            return Total();
        }
    }
}
