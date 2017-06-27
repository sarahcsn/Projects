using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace ModelSalarie
{

    [Serializable()]
    public class Salarie
    {

        #region Champs
        private string _matricule = string.Empty;
        private string _nom = string.Empty;
        private string _prenom = string.Empty;
        private double _salaireBrut = 0;
        private double _tauxCS;
        DateTime _dateNaissance;
        #endregion

        #region Méthodes
        private bool IsMatriculeValide(string valeur)
        {
            if (string.IsNullOrEmpty(valeur) || valeur.Trim().Length != 7)
            {
                return false;
            }


            for (int i = 0; i < valeur.Length; i++)
            {
                //version corrigée :
                if (i < 2 || i > 4)
                {
                    if (!char.IsDigit(valeur[i]))
                    {
                        return false;
                    }


                    if (i > 1 && i < 5)
                    {
                        if (!char.IsLetter(valeur[i]))
                        {
                            return false;
                        }
                    }
                }

            }
            return true;
        }

        /* Ma version :
         //On fait une première boucle pour voir si les deux premiers sont bien des chiffres

        for (int i = 0; i < 2; i++)
    {
        if (char.IsDigit(valeur[i]))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //On fait une première boucle pour voir si les trois suivants sont bien des lettres
    for (int i=2;i<5;i++)
    {
        if (char.IsLetter(valeur[i]))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //On fait une première boucle pour voir si les deux derniers sont bien des chiffres
    for (int i=5;i<valeur.Trim().Length;i++)
    {
        if (char.IsDigit(valeur[i]))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
   return false;
}
*/
        private bool IsNomPrenomValide(string valeur)
        {
            if (valeur == null || valeur.Trim().Length < 3 || valeur.Length > 30)
            {
                return false;
            }

            foreach (char c in valeur)
            {
                if (!char.IsLetter(c) & !char.IsWhiteSpace(c) & c != '-')
                {
                    return false;
                }
            }
            return true;
        }
        private bool DateNaissanceValide(DateTime valeur)
        {
            return (valeur >= new DateTime(1900, 01, 01) && valeur < DateTime.Now.AddYears(15));
        }


        private bool IsTauxCSvalide(double valeur)
        {
            return (valeur >= 0 && valeur < 0.6);
        }

        private double CalculSalaireNet()
        {

            double salaireNet = this._salaireBrut - (this._salaireBrut * _tauxCS);
            return salaireNet;
        }

        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            Salarie sal = obj as Salarie;
            //sal est un salarié avec qui on compare l'objet.

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            if (this.Matricule == sal.Matricule)
            {
                return true;
            }

            return Matricule.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return Matricule.GetHashCode();
        }

        //public override string ToString()
        //{
        //    return string.Format(@"Nom : {0}, Prenom : {1}, Matricule :{2}, date de Naissance : {3}, Salaire Brut : {4}, Taux de Charges Sociales : {5}, Salaire Net : {6}", this.Nom, this.Prenom, this.Matricule, this.DateNaissance, this.SalaireBrut, this.TauxCS, this.SalaireNet);
        //}

        public override string ToString()
        {
            return string.Format(@"{0};{1};{2};{3};{4};{5};{6}", this.Nom, this.Prenom, this.Matricule, this.DateNaissance.ToShortDateString(), this.SalaireBrut, this.TauxCS, this.SalaireNet);
        }


        #endregion




        #region Propriétés

        public string Matricule
        {
            get
            {
                return _matricule;
            }

            set
            {
                if (IsMatriculeValide(value))
                {
                    _matricule = value;
                }
                else
                {
                    throw new Exception(string.Format("Le matricule {0} n'est pas valide", value));
                }
            }
        }
        public string Nom
        {
            get
            {
                return (this._nom);
            }

            set
            {
                if (!IsNomPrenomValide(value))
                {
                    throw new Exception(string.Format("Le nom {0} n'est pas valide", value));
                }
                else
                {
                    this._nom = string.Format("{0} {1}", value.Trim().Substring(0, 1).ToUpper(), value.Trim().Substring(1, value.Trim().Length - 1).ToLower());
                }
                _nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                if (!IsNomPrenomValide(value))
                {
                    throw new Exception(string.Format("Le prénom {0} n'est pas valide", value));
                }
                else
                {
                    this._prenom = string.Format("{0} {1}", value.Trim().Substring(0, 1).ToUpper(), value.Trim().Substring(1, value.Trim().Length - 1).ToLower());
                }
                _prenom = value;
            }
        }
        public DateTime DateNaissance
        {
            get
            {
                return _dateNaissance;
            }

            set
            {

                if (!DateNaissanceValide(value))
                {
                    throw new Exception(string.Format("Votre date de naissance {0} semble erronée", _dateNaissance));
                }

                _dateNaissance = value;
            }
        }
        public double SalaireBrut
        {
            get
            {
                return _salaireBrut;
            }

            set
            {
                _salaireBrut = value;
            }
        }

        public double TauxCS
        {
            get
            {
                return _tauxCS;
            }

            set
            {
                if (!IsTauxCSvalide(value))
                {
                    throw new Exception(string.Format("Le Taux de charge Social {0} n'est pas valide, celui-ci est généralement compris entre 0 et 0.6", _tauxCS));
                }
                _tauxCS = value;
            }
        }

        /// <summary>
        /// Méthode qui calcule le Salaire Net à partir du Taux de charges sociales et du Salaire Brut
        ///L'exactitude de la méthode de calcul a été mis de côté pour permettre la compréhension du cours.
        /// </summary>
        public virtual double SalaireNet
        {
            get
            {
                return CalculSalaireNet();

            }


        }

        #endregion




        #region constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public  Salarie()
        {

        }

        public Salarie(string maTricule, string name, string firstname):this()

        {
            this.Matricule = maTricule;
            this.Nom = name;
            this.Prenom = firstname;
        }



        //public Salarie(DateTime dateNaissance, string maTricule, string name, string fistname, double sBrut, double taux2CS) : this()
        //{
        //    this.DateNaissance = dateNaissance;
        //    this.Matricule = maTricule;
        //    this.Nom = name;
        //    this.Prenom = fistname;
        //    this.SalaireBrut = sBrut;
        //    this.TauxCS = taux2CS;
        //}

        public  Salarie(DateTime dateNaissance, string maTricule, string name, string fistname, double sBrut, double taux2CS) : this(maTricule,name,fistname)
        {
            this.DateNaissance = dateNaissance;
            this.SalaireBrut = sBrut;
            this.TauxCS = taux2CS;
        }


        /// <summary>
        /// constructeur de recopie, il utilise l'un des constructeurs(des modèles) et passe en arguments les propriétés du Salarié Groot
        /// </summary>
        /// <param name="Groot"></param>
        public Salarie(Salarie Groot)
           : this(Groot.DateNaissance,Groot.Matricule,Groot.Nom,Groot.Prenom,Groot.SalaireBrut,Groot.TauxCS)
        {

        }

        /// <summary>
        /// Calcul du Salaire Net en fonction du Salaire brut et du Taux de charges sociales. (Calcul très résumé pour les besoins du cours)
        /// </summary>
        /// <returns></returns>

        // override object.Equals

        #endregion
    }
}
