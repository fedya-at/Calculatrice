using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfaceCalculatrice
{
    public abstract class ICalculBasic  
    {
        public static int Multiplication(int Valeur1, int Valeur2);
        public static int Addition(int Valeur1, int Valeur2);
        public static int Soustraction(int Valeur1, int Valeur2);
        public static int Division(int Valeur1, int Valeur2);

    }
}
