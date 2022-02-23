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

            if (choice < 0 || choice > 5)
            {
                Console.WriteLine("\nERRO");
                Environment.Exit(0);
            }

            while (choice != 0)
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
                    case 5:
                        SquareRoot squareRoot = new SquareRoot();
                        squareRoot.userEntreSqRt();
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
