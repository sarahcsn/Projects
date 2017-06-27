using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelSalarie;


namespace ModelSalarie
{
    class SalarieTest
    {
        static void Main(string[] args)
        {
            Test();
            
            Collection();
            //ProgHashSet();                                                                                                          

        }

        static void Test()
        {
            //Salarie bob = new Salarie();
            //bob.Nom = "Labeille";
            //bob.Prenom = "Maya";
            //bob.Matricule = "25dyf62";
            //bob.SalaireBrut = 24000;
            //bob.TauxCS = 0.5;
            //bob.DateNaissance = new DateTime(1993, 11, 11);

            //Console.WriteLine(bob.SalaireNet);
            //Console.WriteLine(bob.Nom);
            //Console.WriteLine(bob.Prenom);
            //Console.WriteLine(bob.Matricule);
            //Console.WriteLine(bob.TauxCS);

            //Console.ReadLine();


            //Salarie leponge = new Salarie();
            //leponge.Nom = "Carré";
            //leponge.Prenom = "Bob";
            //leponge.Matricule = "25dyf62";
            //leponge.SalaireBrut = 24000;
            //leponge.TauxCS = 0.5;
            //leponge.DateNaissance = new DateTime(1993, 1, 4);

            //Console.WriteLine(leponge.SalaireNet);
            //Console.WriteLine(leponge.Nom);
            //Console.WriteLine(leponge.Prenom);
            //Console.WriteLine(leponge.Matricule);
            //Console.WriteLine(leponge.TauxCS);


            Commercial roger = new Commercial();
            roger.SalaireBrut = 2000;
            roger.Prenom = "Roger";
            roger.TauxCS = 0.1;
            roger.Commission = 0.2;
            roger.ChiffreAffaire = 8000;
            Console.WriteLine("Le salaire net de {0} est de {1}euros", roger.Prenom, roger.SalaireNet);
            Console.WriteLine(roger.ToString());
            


            Salarie sal1 = new Salarie();
            sal1.Nom = "Lexploratrice";
            sal1.Prenom = "Dora";
            sal1.Matricule = "01DOR10";
            sal1.SalaireBrut = 5000;
            sal1.TauxCS = 0.15;
            sal1.DateNaissance = new DateTime(2003, 09, 11);
            Console.WriteLine(sal1.ToString());

            Salarie sal2 = new Salarie();
            sal2.Nom = "Macron";
            sal2.Prenom = "Emmanuel";
            sal2.Matricule = "01PRE01";
            sal2.SalaireBrut = 100000;
            sal2.TauxCS = 0.15;
            sal2.DateNaissance = new DateTime(1977, 12, 21);
            Console.WriteLine(sal2.ToString());

            Commercial com1 = new Commercial();
            com1.Nom = "Mélenchon";
            com1.Prenom = "Jean-Luc";
            com1.Matricule = "01PER01";
            com1.SalaireBrut = 1500;
            com1.TauxCS = 0.15;
            com1.DateNaissance = new DateTime(1951, 08, 19);
            com1.ChiffreAffaire = 3000;
            com1.Commission = 0.1;
            Console.WriteLine(com1.ToString());


            Console.WriteLine("Appuyez sur entrer pour passer à la suite");
            Console.ReadLine();
            
        }

        static void Collection()
        {
            Salaries listeSalaries = new Salaries();
            listeSalaries.Add(new Salarie() { Matricule = "12XXX12", Nom = "Bost", Prenom = "Vincent" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX13", Nom = "Tartempion", Prenom = "Gilbert" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX12", Nom = "Bost", Prenom = "Vincent" });
            Console.WriteLine("attendu true {0}", 2 == listeSalaries.Count);

            Salarie salASupprimer = listeSalaries.Extraire("12XXX13");
            listeSalaries.Remove(salASupprimer);
            Console.WriteLine("attendu true {0}", 1 == listeSalaries.Count);

            Salarie salASupprimer2 = listeSalaries.Extraire("12XXX12");
            listeSalaries.Remove(salASupprimer2);
            listeSalaries.Remove(salASupprimer2);


            Console.WriteLine("attendu true {0}", 0 == listeSalaries.Count);
            Console.ReadLine();
        }

        //static void ProgHashSet()
        //{
        //    SalarieHS listeSalaries = new SalarieHS();
        //    listeSalaries.Add(new Salarie() { Matricule = "12XXX12", Nom = "Bost", Prenom = "Vincent" });
        //    listeSalaries.Add(new Salarie() { Matricule = "12XXX13", Nom = "Tartempion", Prenom = "Gilbert" });
        //    listeSalaries.Add(new Salarie() { Matricule = "12XXX12", Nom = "Bost", Prenom = "Vincent" });
        //    Console.WriteLine("attendu true {0}", 2 == listeSalaries.Count);

        //    Salarie salASupprimer = listeSalaries.Extraire("12XXX13");
        //    listeSalaries.Remove(salASupprimer);
        //    Console.WriteLine("attendu true {0}", 1 == listeSalaries.Count);

        //    Salarie salASupprimer2 = listeSalaries.Extraire("12XXX12");
        //    listeSalaries.Remove(salASupprimer2);
        //    listeSalaries.Remove(salASupprimer2);
        //    Console.WriteLine("attendu true {0}", 0 == listeSalaries.Count);


        //    Console.WriteLine("Appuyez sur entrer pour passer à la suite");
        //    Console.ReadLine();
        //}
    }
}
