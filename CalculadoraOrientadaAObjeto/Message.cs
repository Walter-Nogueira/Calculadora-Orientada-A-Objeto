using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOrientadaAObjeto
{
    internal class Message
    {
        public void MessageStart()
        {
            Console.WriteLine("Calculadora\n");
            Console.WriteLine("Escolha a operacao");
            Console.WriteLine("\n1. Soma\n2. Subtracao\n3. Divisao\n4. Multiplicacao\n5. Raiz quadrada");
            Console.Write("\nDigite o numero da operacao: ");
        }

        public void MessageRepeat()
        {
            Console.WriteLine("\ne agora?");
            Console.WriteLine("\n0. Sair\n1. Soma\n2. Subtracao\n3. Divisao\n4. Multiplicacao\n5. Raiz quadrada");
            Console.Write("\nDigite o numero da operacao: ");
        }
        
    }
}
