using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afpa.S2.A5
{
    class Program
    {
        static void Main(string[] args)
        {
            ChoixTris();
            Console.ReadLine();
        }
        private static void ChoixTris()
        {
            string repchoix = "Z";
            Console.WriteLine("Exercices d'Algorithmiques : Test");
            Console.WriteLine("---------------------");
            do
            {
                Console.WriteLine("Choisissez un mode de tris :");
                Console.WriteLine("Tapez B pour choisir le tris Bulle");
                Console.WriteLine("Tapez S pour choisir le tris par Sélection");
                Console.WriteLine("Tapez F pour sortir du programme");
                string choixconsole = (Console.ReadLine()).ToUpper();
                Console.WriteLine(choixconsole);
              
                switch (choixconsole)
                {
                    case "B":
                        TrisBulle();
                        repchoix = choixconsole;
                        break;
                    case "S":
                        TrisSelection();
                        repchoix = choixconsole;
                        break;
                    case "F":
                        Console.WriteLine("Au revoir");
                        repchoix = choixconsole;
                        break;
                    default:
                        Console.WriteLine("Je ne comprend pas votre saisie");
                        repchoix = choixconsole;
                        break;
                }
            } while (repchoix != "B" && repchoix != "S" && repchoix != "F");
            
        }

            private static void TrisBulle()
        {
            Console.WriteLine("Bienvenue dans le tris Bulle");

            
        }

        private static void TrisSelection()
        {
            Console.WriteLine("Bienvenue dans le tris Bulle");
        }
        private static void EntrerTab()
        {
            int tableauEntiers = [52, 10, 1, 25, 62, 3, 8, 55, 3, 23];
           
            /*début de réflexion comment utiliser des entrées utilisateur dans un tableau
             * Console.WriteLine("Veuillez entrer des valeurs");
            string entreeutilisateur=Console.ReadLine();
            int TabEntier = new int [Convert.ToInt32(entreeutilisateur)]{};*/

        }
        }
        }
       
       
    }

