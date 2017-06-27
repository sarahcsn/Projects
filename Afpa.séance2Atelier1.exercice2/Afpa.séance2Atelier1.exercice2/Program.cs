using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afpa.séance2Atelier1.exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables de récupération du mot
            string rep;  
            

            //Récupérer le mot
            Console.WriteLine("Entrez un mot");
            rep = Console.ReadLine();


            //Variables du test palindrome
            int j = (rep.Length) - 1;
            int i = 0;
            bool egalite;

            //test palindrome
            do
            {

                if (egalite = i.Equals(j))
                {
                    Console.WriteLine("D'après la {0} comparaison, {1} ressemble à un palindrome",i,rep);
                }
                else
                    i++;
                    j--;

            } while (i >= j && !egalite);
            if (!egalite)
            {
                Console.WriteLine("ceci n'est pas un palindrome");
            }
            else
            {
                Console.WriteLine("Ceci n'est pas un palindrome");
            }
            Console.ReadLine();
        }
    }
}
