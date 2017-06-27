using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damier
{
    public partial class Damier : Form
    {
        public Damier()
        {
            int dimension = 8;
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(dimension*50, dimension*50);
            for (int ligne = 0; ligne <dimension; ligne++)
            {
                for (int colonne = 0; colonne < dimension; colonne++)
                {
                    Button bouton = new Button();
                    bouton.Size = new System.Drawing.Size(50, 50);
                    bouton.Left = colonne * 50;
                    bouton.Top = ligne * 50;

                    if ((colonne%2 == 0 && ligne%2==0)||(ligne%2==1 && colonne%2==1))
                    {
                        bouton.BackColor = Color.Black;
                    }else
                    {
                        bouton.BackColor = Color.White;
                    }
                    this.Controls.Add(bouton);

                    //Solution de Thomas
                    //if ((colonne+ligne) % 2 == 0 && (colonne+ligne) % 2 == 0)
                    //{
                    //    bouton.BackColor = Color.Black;
                    //}
                    //else
                    //{
                    //    bouton.BackColor = Color.White;
                    //}
                    //this.Controls.Add(bouton);
                }
            }
        }
        
       
    }
}
