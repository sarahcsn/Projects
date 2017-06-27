//Afpa.S4.A2. Serialisation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ModelSalarie;


namespace PersitanceObjet
{
    class ManipulationFTxt
    {
        static void Main(string[] args)
        {
            //exercice 1
            //AcquisitionMots();
            //ExtractionAffichage();
            // Console.ReadLine();

            //exercice 2
            Serialisationv1();
            //Console.WriteLine("Veuillez entrer le matricule du salarié recherché");
            //string matricule = Console.ReadLine();
            //Salaries.Extraire(matricule);

            //a faire méthode 2.3

            Console.ReadLine();
        }
        #region Exercice 1 : Manipulation fichier texte
        static void AcquisitionMots()
        {
            //Je créé mon fichier avec FileMode.Create, j'autorise les opérations de lectures et d'écriture avec File.Access.ReadWrite
            //J'autorise le partage pour lecture et écriture avec File.Share.ReadWrite.
            FileStream EntrerAnimaux = new FileStream("FichierTexte.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(EntrerAnimaux);
            sw.WriteLine("chat");
            sw.WriteLine("chien");
            sw.WriteLine("lapin");
            sw.WriteLine("cochon d\'inde");
            sw.Close();



        }

        static void ExtractionAffichage()
        {
            FileStream SortieAnimaux = new FileStream("FichierTexte.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(SortieAnimaux);
            string animal = sr.ReadLine();
            while (animal != null)
            {
                Console.WriteLine(animal);
                animal = sr.ReadLine();

            }
            sr.Close();
        }
        #endregion
        public static void Serialisationv1()
        {
            #region Initialisation
            Salaries listesal = new Salaries();
            listesal.Add(new Salarie(new DateTime(1993, 11, 10), "12gty93", "CHESNE", "Sarah", 25000, 0.2));
            listesal.Add(new Salarie(new DateTime(1998, 08, 27), "12gty98", "CHESNE", "Emilie", 23000, 0.2));
            #endregion

            #region Exercice 2.1 CSV
            listesal.SaveText(@"C:\Users\CDI\Documents\Visual Studio 2015\Projects\PersitanceObjet\Salarie.csv");
            Salaries listesal2 = new Salaries();


            listesal2.LoadText(@"C:\Users\CDI\Documents\Visual Studio 2015\Projects\PersitanceObjet\Salarie.csv");
            foreach (Salarie sal in listesal2)
            {
                Console.WriteLine(sal.ToString());
            }
            #endregion

            #region XML
            listesal.SaveXML(@"C:\Users\CDI\Documents\Visual Studio 2015\Projects\PersitanceObjet\Salarie.xml");
            Salaries listesal3 = new Salaries();

            listesal3.LoadXML(@"C:\Users\CDI\Documents\Visual Studio 2015\Projects\PersitanceObjet\Salarie.xml");
            foreach (Salarie sal2 in listesal3)
            {
                Console.WriteLine(sal2.ToString());
            }
            #endregion

            #region Binaire

            listesal.SaveBinary(@"C:\Users\CDI\Documents\Visual Studio 2015\Projects\PersitanceObjet\Salarie.dat");
            Salaries listesal4 = new Salaries();
            listesal4.LoadBinary(@"C:\Users\CDI\Documents\Visual Studio 2015\Projects\PersitanceObjet\Salarie.dat");
            foreach (Salarie sal3 in listesal4)
            {
                Console.WriteLine(sal3.ToString());
            }
            #endregion

            

        }





    }
}
}
