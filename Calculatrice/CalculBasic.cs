using System;

namespace Calculatrice
{
    public class CalculBasic 
    {
        
        public static int Multiplication(int Valeur1, int Valeur2)
        {
            return Valeur1 * Valeur2;
            
        }
        public static int Addition(int Valeur1, int Valeur2)
        {
            return Valeur1 + Valeur2;
        }
        public static int Soustraction(int Valeur1, int Valeur2)
        {
            return Valeur1 - Valeur2;
        }
        public static int Division(int Valeur1, int Valeur2)
        {
            return Valeur1 / Valeur2;
        }
        public static int Mod(int Valeur1, int Valeur2)
        {
            return Valeur1 % Valeur2;
        }
    }
}
