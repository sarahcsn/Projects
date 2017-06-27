using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesExceptions
{
    class Exemple2_NiveauGlobal
    {
        internal static void Entree()
        {
            Fonction1();
            Console.ReadLine();
        }

        private static void Fonction1()
        {
            try
            {
                Fonction2();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("F2 Erreur Divisiion 0 Message : {0}\r\n Application : {1}, Fonction {2}", ex.Message, ex.Source, ex.TargetSite);

            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("F2 Erreur arithmétique autre que div 0 : {0}\r\n Application : {1}, Fonction {2}", ex.Message, ex.Source, ex.TargetSite);

            }
            catch (Exception ex)
            {
                Console.WriteLine("F2 Erreur autre Message : {0}\r\n Application : {1}, Fonction {2}", ex.Message, ex.Source, ex.TargetSite);

            }

        }

        private static void Fonction2()
        {
            int? resultat = Division(10, 0);

        }

        private static int? Division(int p1, int p2)
        {
          
                return p1 / p2;        
        }
    }
}
