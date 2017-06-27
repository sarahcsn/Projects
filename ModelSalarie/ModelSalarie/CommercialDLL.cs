//Notions héritage
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
   
    [Serializable]
    [XmlInclude(typeof(Commercial))]
    /// <summary>
    /// Commercial est la classe dérivée de Salarie
    /// Elle stocke les données concernant le salarié et permet de calculer son salaire
    /// </summary>
    public class Commercial : Salarie

    {
        double _chiffreAffaire;
        double _Commission;

        public double ChiffreAffaire
        {
            get
            {
                return _chiffreAffaire;
            }

            set
            {
                _chiffreAffaire = value;
            }
        }

        public double Commission
        {
            get
            {
                return _Commission;
            }

            set
            {
                _Commission = value;
            }
        }

        public Commercial() : base()
        {

        }
        public Commercial(Commercial commercialobjet) : base(commercialobjet)
        {
            _chiffreAffaire = commercialobjet._chiffreAffaire;
            _Commission = commercialobjet._Commission;
        }

        public override double SalaireNet
        {
            get
            {
                double _salairenet = (base.SalaireNet) + (Commission * ChiffreAffaire);
                return _salairenet;

            }

        }
        public override string ToString()
        {
            return string.Format("{0}, CA={1}, Com={2}", base.ToString(), _chiffreAffaire, _Commission);
        }

    }
}

    
