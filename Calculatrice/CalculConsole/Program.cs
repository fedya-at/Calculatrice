using Calculatrice;
using System;

namespace CalculConsole
{
    class Program
    {
        /*delegate int OperationDelegate(int x, int y, int Valeur1, int Valeur2);
        static OperationDelegate operation1;
        static OperationDelegate operation2;*/
        static void Main(string[] args)
        {
            CalculBasic c = new CalculBasic();
            String Input;
            int Result, Opp, Valeur1, Valeur2;

            Console.WriteLine("choose your Operation :\n 1 - Multiplication \n 2 - Addition \n 3 - Soustraction \n 4 - Division");
            int.TryParse(Console.ReadLine(), out Opp);

            switch (Opp)
            {
                //Multiplication
                case 1:
                    Console.WriteLine("Multiplication !!");
                    // saisie valeur 1
                    Console.WriteLine("input valeur 1");
                    Input = Console.ReadLine();
                    int.TryParse(Input, out Valeur1);

                    // saisie valeur 2
                    Console.WriteLine("input valeur 2");
                    Input = Console.ReadLine();
                    int.TryParse(Input, out Valeur2);
                    Result = Multiplication(Valeur1,Valeur2);
                    Console.WriteLine("le resultat de\n {0} * {1} = {2} ", Valeur1, Valeur2, Result);

                    break;
                //Addition
                case 2:
                    Console.WriteLine("Addition !!");
                    // saisie valeur 1
                    Console.WriteLine("input valeur 1");
                    Input = Console.ReadLine();
                    int.TryParse(Input, out Valeur1);

                    // saisie valeur 2
                    Console.WriteLine("input valeur 2");
                    Input = Console.ReadLine();
                    int.TryParse(Input, out Valeur2);
                    Result = Addition(Valeur1, Valeur2);
                    Console.WriteLine("le resultat de\n {0} + {1} = {2} ", Valeur1, Valeur2, Result);

                    break;
                //Soustraction*/
                case 3:
                    Console.WriteLine("Soustraction !!");
                    // saisie valeur 1
                    Console.WriteLine("input valeur 1");
                    Input = Console.ReadLine();
                    int.TryParse(Input, out Valeur1);

                    // saisie valeur 2
                    Console.WriteLine("input valeur 2");
                    Input = Console.ReadLine();
                    int.TryParse(Input, out Valeur2);
                    Result = Soustraction(Valeur1, Valeur2);
                    Console.WriteLine("le resultat de\n {0} - {1} = {2} ", Valeur1, Valeur2, Result);

                    break;
                //Division
                case 4:
                    Console.WriteLine("Division  !!");
                    // saisie valeur 1
                    Console.WriteLine("input valeur 1");
                    Input = Console.ReadLine();
                    int.TryParse(Input, out Valeur1);

                    // saisie valeur 2
                    Console.WriteLine("input valeur 2");
                    Input = Console.ReadLine();
                    int.TryParse(Input, out Valeur2);
                    Result = Division(Valeur1, Valeur2);
                    Console.WriteLine("le resultat de\n {0} / {1} = {2} ", Valeur1, Valeur2, Result);
                    System.Threading.Thread.Sleep(4000);
                    break;
            }
            // Wait for the user to respond before closing
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        
    }
    }
}
