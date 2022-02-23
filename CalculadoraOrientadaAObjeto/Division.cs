using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOrientadaAObjeto
{
    internal class Division
    {
        public void UserEntre()
        {
            Console.Write("First number: ");
            double numEntre1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second number: ");
            double numEntre2 = Convert.ToDouble(Console.ReadLine());

            if(numEntre1 == 0 || numEntre2 == 0)
            {
                Console.WriteLine("Nao é possível fazer divisao por zero");
            }else
            {
                Console.WriteLine("{0} / {1} = {2}",
                numEntre1, numEntre2, Math.Round((numEntre1 / numEntre2), 2));
            }
            
        }
    }
}
