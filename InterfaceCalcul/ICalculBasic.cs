using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalcul
{
    public abstract class ICalculBasic
    {
        public abstract int Addition(int Valeur1, int Valeur2);
        public abstract int Multiplication(int Valeur1, int Valeur2);
        public abstract int Soustraction(int Valeur1, int Valeur2);
        public abstract int Division(int Valeur1, int Valeur2);
        public abstract int Mod(int Valeur1, int Valeur2);

    }
}
