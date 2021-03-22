using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDia2
{
    class ConversorDeMoeda
    {
        public static double Iof = 6;
        
        public static double Conversor(double cotacao, double quantidade) 
        {
            double total = cotacao * quantidade;
            return total + total * Iof / 100;
        }
    }
}
