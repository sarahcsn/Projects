using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2a1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rep;
            Console.WriteLine("Entrez un mot");
            rep = Console.ReadLine();
            int i = 0;
            int j = (rep.Length) - 1;
            if (EstPalindrome(rep, i, j))
            {
                Console.WriteLine("{0} n’est pas un palindrome", rep);
            }
            else
            {
                Console.WriteLine("{0} est un palindrome", rep);
            }
            ;
            Console.ReadLine();
        }


        /// <summary>
        /// EstPalindrome compare les lettres du mot et dit si le mot est un palindrome ou non.
        /// </summary>
        /// <param name="chaine"></param>
        /// <returns></returns>
        static bool EstPalindrome(string mot,int x,int y)
        
        {
            
            while (x < y && mot[x].Equals(mot[y]))
            {
                x++;
               y--;
            }
            return (x<y);
        }



    }
}
