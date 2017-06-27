using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GestionDesExceptions
{
    class Exemple1_nongérée
    {
        internal static void Entree()
        {
            Console.ReadLine();
        }

        private static void Fonction1()
        {
            Fonction2();
        }

        private static void Fonction2()
        {
            int resultat = Division(10, 0);
        }

        private static int Division(int p1, int p2)
        {
            return p1 / p2;
        }
    }
}
