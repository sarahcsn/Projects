using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afpa.S2.A3.ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercice1();
             argumentValeurReference();
             argumentValeur();
             Console.WriteLine("Veuillez entrer une chaine a de type string");
             string a = Console.ReadLine();
             Console.WriteLine("Veuillez entrer une chaine b de type string");
             string b = Console.ReadLine();
             TraitementChaineParValeur(a, b);
             Console.WriteLine("Dans Main, Par valeur : a={0} et b={1}", a, b);
             TraitementChaineParValeurRef(ref a, ref b);
             Console.WriteLine("Dans Main, Par ref : a={0} et b={1}", a, b);
             */
            Console.Write("Please write a number");
            string rep=Console.ReadLine();
            int number = Convert.ToInt32(rep);
            int paire;
            if (IsitEven(number, out paire))
            {
                Console.WriteLine("{0} est un nombre pair", rep);
            }
            else
            {
                Console.WriteLine("{0} est un nombre impair", rep);
            }
            Console.ReadLine();
        }


        private static void Exercice1()
        {
            int a;
            int b;
            a = 2;
            b = a;
            b = b + 2;
            Console.Write("a= {0},b={1}", a, b);
            int[] TabA, TabB;
            TabA = new int[3] { 2, 5, 4 };
            TabB = TabA;
            TabB[0] = 55;
            Console.Write("TabA[0]={0}, TabB[0]={1}", TabB[0], TabA[0]);
        }


        private static void argumentValeurReference()
        {
            int s = 3;
            Console.WriteLine("ArgumentValeurref Valeur avant appel méthode modification{0}", s);
            modifierValeurReference(ref s);
            Console.WriteLine("ArgumentValeurref Valeur après appel méthode modification{0}", s);
            
        }
        private static void modifierValeurReference(ref int o)
        {
            o = 4;
        }

        private static void argumentValeur()
        {
            int[] tabS = new int[3] { 1, 4, 6 };
            Console.WriteLine("argumentValeur Valeur avant appel méthode modification valeur {0}", tabS[0]);
            modifierTabValeur(tabS);
            Console.WriteLine("modiftabvaleur Valeur après appel méthode modification valeur {0}", tabS[0]);
            modifierTabValeur2(tabS);
            Console.WriteLine("modiftabvaleur2Valeur après appel méthode 2eme modification valeur {0}", tabS[0]);
            modifierTabValeur2Ref(ref tabS);
            Console.WriteLine("modiftabvaleur2refValeur Valeur après appel méthode 2eme modification valeur {0}", tabS[0]);
        }

        private static void modifierTabValeur(int[] tabO)
        {
        tabO[0]=8;
        }

        private static void modifierTabValeur2(int[]tabO)
        {
            tabO[0] = 8;
            tabO = new int[] { 9, 10, 11 };
            Console.WriteLine("tabO[0]={0} et tabO[1]={1}",tabO[0], tabO[1]);
           
        }
        private static void modifierTabValeur2Ref(ref int[] tabO)
        {
            tabO[0] = 8;
            tabO = new int[] { 9, 10, 11 };
            Console.WriteLine("tabO[0]={0} et tabO[1]={1}", tabO[0], tabO[1]);

        }

        private static void TraitementChaineParValeur(string x, string y)
        {
            string j = x;
            x = y;
            y = j;
            Console.WriteLine("Niveau local, Par valeur : a={0} et b={1}", x, y);

        }
        private static void TraitementChaineParValeurRef(ref string x, ref string y)
        {
            string j = x.Substring(0,(x.Length));
            x = y.Substring(0,(y.Length));
            y = j;
            Console.WriteLine("Niveau local, Par ref : a={0} et b={1}", x, y);
        }

        private static bool IsitEven(int w, out int z)
        {
           
           if (w%2==0)
            {
               z = w / 2;
                return true;
            }
            else
            {
                z = 0;
                return false;
            }
              

        }
    }
  
}
