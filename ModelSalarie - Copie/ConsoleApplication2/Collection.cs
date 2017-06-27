using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelSalarie;
using System.Collections;


namespace Collection
{
    class Collection
    {
        static void Main(string[] args)
        {
           Afficherliste();
           Console.ReadLine();

        }
        public static ArrayList CreerListeHeteroclite()
        {
            ArrayList bjets = new ArrayList();
            bjets.Add(1.3m);
            bjets.Add("chou");
            bjets.Add(9);
            Salarie salarie = new Salarie();
            salarie.Nom = "Jaques";
            bjets.Add(salarie);
            Salarie salarie2 = new Salarie();
            salarie2.Nom = "Henri";
            bjets.Add(salarie2);
            Commercial com1=(new Commercial());
            com1.Nom = "tata yoyo";
            bjets.Add(com1);


            return bjets;
        }


        public static void Afficherliste()
        {
            ArrayList liste =  CreerListeHeteroclite();
            foreach (object elements in liste)
            {
                if (elements.GetType() == typeof(int))
                {
                   Console.WriteLine("Entier {0}", elements.ToString());
                }
                if (elements.GetType() == typeof(string))
                {
                    Console.WriteLine("Chaine {0}", elements.ToString());
                }
                if (elements.GetType() == typeof(decimal))
                {
                  Console.WriteLine("decimal {0}", elements.ToString());
                }
                if (elements.GetType() == typeof(Salarie))
                {

                   Console.WriteLine("Salarié {0}", elements.ToString());
                }
                if (elements.GetType() == typeof(Commercial))
                {
                    Console.WriteLine("Commercial {0}", elements.ToString());
                }
            }
              Console.WriteLine(liste);
           
           
          
            
        }
       
        
    }
}
