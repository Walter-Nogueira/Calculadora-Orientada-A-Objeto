using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOrientadaAObjeto
{
    internal class SquareRoot
    {
        public void userEntreSqRt()
        {
            Console.Write("\nEntre com o numero qual deseja obter a raiz quadrada: ");
            double squareRoot = Convert.ToDouble(Console.ReadLine());

            double result = Math.Sqrt(squareRoot);

            Console.WriteLine("Raiz quadrada de {0} = {1}", squareRoot, result);

        }
    }
}
