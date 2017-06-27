using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afpa.seance2.atelier3.exercice1
{
    class Program
    {
        static void Main(string[] args)
        {

            int x=0;
            short y=0;
            long z=0;
            Convertit(x,y,z);
            Console.ReadLine();
        }
        static void Convertit(int a, short b, long c)
        {
            Console.WriteLine("Veuillez entrer un entier");
            string entier = Console.ReadLine();
            a = int.Parse(entier);
            b = (short)a++;
            c = (long)++a;
            Console.WriteLine("{0} convertit en type int devient {1}", entier, a);
            Console.WriteLine("{0} post-incrémentée de 1 et convertit en type short devient {1}", a, b);
            Console.WriteLine("{0} pré-incrémentée de 1 et convertit en type short devient {1}", a, c);
            
        }
    }
}
