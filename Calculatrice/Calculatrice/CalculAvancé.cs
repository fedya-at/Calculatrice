using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class CalculAvancé
    {
        public int Factoriel(int Valeur1,int Valeur2)
        {
            Valeur1 = 1;
            
            for (int i =1; i <Valeur2; i++)
            {
                Valeur1 = Valeur1 * i;
            }
            return Valeur1;
        }
        public double Mod (int Valeur1, int Valeur2)
        {
            return Valeur1%Valeur2;
        }

    }
}
