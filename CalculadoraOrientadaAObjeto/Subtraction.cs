using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOrientadaAObjeto
{
    internal class Subtraction
    {
        public void UserEntre()
        {
            Console.Write("First number: ");
            double numEntre1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second number: ");
            double numEntre2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} - {1} = {2}", numEntre1, numEntre2, Math.Round((numEntre1 - numEntre2), 2));
        }
    }
}
