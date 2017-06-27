using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;

namespace ModelSalarie
{
    [Serializable()]
    public class Salaries : List<Salarie>
    {
        public new void Add(Salarie sal)
        {
            //if(!Exist(salarie))
            //{
            //base.Add(salarie);
            //}

            if (!Contains(sal))
            {
                base.Add(sal);
            }
        }


        //le contains remplace Cette méthode :        
        //private bool IfExits(Salarie sal)
        //        {


        //            foreach (Salarie item in this)
        //            {
        //                if (item.Equals(sal))
        //                {
        //                    return true;
        //                }
        //                return false;
        //            }
        //        }
        //    }
        //}

        public Salarie Extraire(string matricule)
        {
            foreach (Salarie item in this)
            {
                if (item.Matricule == matricule)
                {
                    return item;
                }
            }
            return null;
        }

        /// <summary>
        /// Méthode qui supprime l'élément dont le matricule est fourni.
        /// </summary>
        /// <param name="matricule"></param>
        public void Remove(string matricule)
        {
            base.Remove(Extraire(matricule));
        }


        //}
        //public class Salaries : HashSet<Salarie>
        //{
        //    public Salarie Extraire(string matricule)
        //    {
        //        foreach (Salarie item in this)
        //        {
        //            if (item.Matricule == matricule)
        //            {
        //                return item;
        //            }
        //        }
        //        return null;
        //    }

        //    /// <summary>
        //    /// Méthode qui supprime l'élément dont le matricule est fourni.
        //    /// </summary>
        //    /// <param name="matricule"></param>
        //    public void Remove(string matricule)
        //    {
        //        base.Remove(Extraire(matricule));
        //    }



        #region Exercice 2 : Assurer la persistance des états de vos objets

        #region Serialisation csv
        public void SaveText(string path)
        {
            FileStream fStream = new FileStream(path, FileMode.Truncate, FileAccess.Write);

            StreamWriter sWriter = new StreamWriter(fStream);
            foreach (Salarie sal in this)
            {
                sWriter.WriteLine(sal.ToString());
            }

            sWriter.Close();
            fStream.Close();
        }

        public void LoadText(string path)
        {
            FileStream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sReader = new StreamReader(fStream);

            string lecture = sReader.ReadLine();

            while (!string.IsNullOrEmpty(lecture))
            {
                string[] tab = lecture.Split(';');
                //méthode qui fonctionne qu'en format français
                //    string[] tabdate = tab[3].Split('/');
                //    DateTime date = new DateTime(int.Parse(tabdate[2]), int.Parse(tabdate[1]), int.Parse(tabdate[0]));
                //méthode qui fonctionne dans toutes les cultures
                DateTime date = DateTime.Parse(tab[3], CultureInfo.CurrentCulture);
               //à faire : this.Add pour le commercial avec la précision dans le programme de si c'est un Commercial ou Salarié.
                this.Add(new Salarie(date, tab[2], tab[0], tab[1], double.Parse(tab[4]), double.Parse(tab[5])));
                lecture = sReader.ReadLine();


            }
            sReader.Close();
            fStream.Close();
        }
        #endregion

        #region SerialisationXML
        public void SaveXML(string cheminXml)
        {
            FileStream fichierStream = new FileStream(cheminXml, FileMode.Create, FileAccess.Write);
            XmlTextWriter xmlW = new XmlTextWriter(fichierStream, Encoding.UTF8);
            XmlSerializer xmlS = new XmlSerializer(this.GetType());
            xmlS.Serialize(xmlW, this);
            xmlW.Close();
            fichierStream.Close();

        }

        public void LoadXML(string cheminBinary)
        {
            FileStream fichierStream;
            XmlTextReader xmlR;
            XmlSerializer xmlS;
            fichierStream = new FileStream(cheminBinary, FileMode.Open, FileAccess.Read);
            xmlR = new XmlTextReader(fichierStream);
            xmlS = new XmlSerializer(this.GetType());
            this.AddRange(xmlS.Deserialize(xmlR) as Salaries);
            xmlR.Close();
            fichierStream.Close();
        }
        #endregion
        #region Serialisation binaire
        public void SaveBinary(string cheminBinary)
        {
            FileStream fichierStream = new FileStream(cheminBinary, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fichierStream, this);
            fichierStream.Close();
        }

        public void LoadBinary(string cheminBinary)
        {
            FileStream fs = new FileStream(cheminBinary, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            this.AddRange(bf.Deserialize(fs)as Salaries);
            fs.Close();
        }

            

            #endregion
            #endregion
        }
}