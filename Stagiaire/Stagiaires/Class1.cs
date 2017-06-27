using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stagiaires
{
    public class Stagiaire

    {
        string _nom = string.Empty;
        DateTime _dateNaissance;


        public DateTime DateNaissance
        {
            get
            {
                return _dateNaissance;
            }

            set
            {
                _dateNaissance = value;
            }
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Subtract(_dateNaissance).Days / 365;
            }
        }

        public string Nom
        {
            get
            {
                return _nom.ToUpper();
            }

            set
            {
                if (IsNomValide(value))
                {
                    _nom = value;
                }
                _nom = value;
            }
        }



        public static bool IsNomValide(string nom)
        {
            foreach (char item in nom)
            {
                if (!char.IsLetter(item)) ;
                {
                    return false;
                }
            }
            return true;
        }
    }
}
