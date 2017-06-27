using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNatureDesCaracteres
{
    public partial class TestCaracteres : Form
    {
       
        public TestCaracteres()
        {
            InitializeComponent();
        }
        
        private void MaxPositionCaractere(object sender, EventArgs e)
        {            
                _positionCar.Maximum = (_saisieChn.Text.Length) -1;
            
        }

        private void _Categorie_click(object sender, EventArgs e)
        {
           
            {
                if (string.IsNullOrEmpty(_saisieChn.Text))
                {
                    _resultat.Text = "Veuillez saisir une chaine pour obtenir un résultat";
                }
                else if (char.IsLetter(_saisieChn.Text[(int)_positionCar.Value]))
                {
                    _resultat.Text = "Lettre";
                }
                else if (char.IsDigit(_saisieChn.Text[(int)_positionCar.Value]))
                {
                    _resultat.Text = "Nombre";
                }
                else if (char.IsWhiteSpace(_saisieChn.Text[(int)_positionCar.Value]))
                {
                    _resultat.Text = "Espace";
                } else if (char.IsSymbol(_saisieChn.Text[(int)_positionCar.Value]))
                {
                    _resultat.Text = "Symbole";
                } else if (char.IsPunctuation(_saisieChn.Text[(int)_positionCar.Value]))
                {
                    _resultat.Text = "Ponctuation";
                } else
                {
                    _resultat.Text = "Je n'ai pas compris";
                }
            }
        }


        

    }




}

