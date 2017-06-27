using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesExceptions
{
    class Exemple2_niveaulocal
    {
        internal static void Entree()
        {
            Fonction1();
            Console.ReadLine();
        }

        private static void Fonction1()
        {
            Fonction2();
        }

        private static void Fonction2()
        {
            int? resultat = Division(10, 0);

        }

        private static int? Division(int p1, int p2)
        {
            try
            {
                return p1 / p2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message : {0}\r\n Application : {1}, Fonction {2}", ex.Message, ex.Source, ex.TargetSite);
                return null;

            }

        }

    }
}
