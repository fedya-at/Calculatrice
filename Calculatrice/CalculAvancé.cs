using System;
using System.Collections.Generic;
using System.Text;

namespace Calculatrice
{
    public class CalculAvancé
    {
        public int Factoriel(int Valeur1, int Valeur2)
        {
            Valeur1 = 1;

            for (int i = 1; i < Valeur2; i++)
            {
                Valeur1 = Valeur1 * i;
            }
            return Valeur1;
        }

    }
}
