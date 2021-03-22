using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TreinamentoDia2
{
    class Aluno
    {
        public static string Nome;
        public static double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double PrecisaNota()
        {
            return 60 - NotaFinal();
        }

        public override string ToString()
        {
            return "Nota Final = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
