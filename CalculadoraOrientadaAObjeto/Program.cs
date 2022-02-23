using System;

namespace CalculadoraOrientadaAObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculator

            Message messageOpen = new Message();
            messageOpen.MessageStart();
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice < 0 || choice > 6)
            {
                Console.WriteLine("\nERROR");
                Environment.Exit(0);
            }

            while (choice != 0) // enquanto for diferente de 0, o programa continua sendo executado
            {
                Message messageAgain = new Message();

                switch (choice)
                {
                    case 1: // Soma
                        Addition sum = new Addition();
                        sum.UserEntre();
                        messageAgain.MessageRepeat();
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2: // Subitracao
                        Subtraction subtraction = new Subtraction();
                        subtraction.UserEntre();
                        messageAgain.MessageRepeat();
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3: // Divisao
                        Division division = new Division();
                        division.UserEntre();
                        messageAgain.MessageRepeat();
                        choice = Convert.ToInt32((Console.ReadLine()));
                        break;
                    case 4: // Multiplicacao
                        Multiplication multiplication = new Multiplication();
                        multiplication.UserEntre();
                        messageAgain.MessageRepeat();
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5: // Raiz quadrada
                        SquareRoot squareRoot = new SquareRoot();
                        squareRoot.UserEntreSqRt();
                        messageAgain.MessageRepeat();
                        choice = Convert.ToInt32((Console.ReadLine()));
                        break;
                    case 6: // Raiz cubica
                        CubeRoot cubeRoot = new CubeRoot();
                        cubeRoot.UserCubeRoot();
                        messageAgain.MessageRepeat();
                        choice = Convert.ToInt32((Console.ReadLine()));
                        break;
                }
            }

            Console.WriteLine("\nCalculador encerrada");
            Environment.Exit(0);
            Console.ReadLine();
        }
    }
}
