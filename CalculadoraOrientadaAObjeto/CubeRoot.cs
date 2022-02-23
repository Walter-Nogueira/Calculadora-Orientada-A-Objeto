using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOrientadaAObjeto
{
    internal class CubeRoot
    {
        public void UserCubeRoot()
        {
            Console.Write("\nEntre com o numero qual deseja obter a raiz cubica: ");
            double cubeRoot = Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow(cubeRoot, (double)1/3);
            Console.WriteLine(result);
        }
    }
}
