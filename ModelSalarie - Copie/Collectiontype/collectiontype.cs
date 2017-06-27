using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelSalarie;


namespace Collectiontype
{
    class collectiontype
    {
        static void Main(string[] args)
        {
            Salaries listeSalaries = new Salaries();
            listeSalaries.Add(new Salarie() { Matricule = "12XXX12", Nom = "Bost", Prenom = "Vincent" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX13", Nom = "Tartempion", Prenom = "Gilbert" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX12", Nom = "Bost", Prenom = "Vincent" });
            Console.WriteLine("attendu true {0}", 2== listeSalaries.Count);
            Salarie salASupprimer = listeSalaries.Extraire("12XXX13");       
            listeSalaries.Remove(salASupprimer);
            Console.WriteLine("attendu true {0}", 1 == listeSalaries.Count);
            Salarie salASupprimer2 = listeSalaries.Extraire("12XXX12");
            listeSalaries.Remove(salASupprimer2);
            listeSalaries.Remove()
            Console.WriteLine("attendu true {0}", 0 == listeSalaries.Count);
            Console.ReadLine();
        }
    }
}
