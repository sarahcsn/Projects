using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damier_Rouge_et_jaune
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Damier(8,100,Color.Yellow,Color.Tomato );
           
        }
        /// <summary>
        /// Damier crée un damier, vous pouvez choisir les couleurs. Attention dans la rédaction des
        /// arguments de la méthode Damier, pour définir les couleurs, celles-ci doivent être précédées
        /// de Color. .Exemple : Color.White
        /// </summary>
        public void Damier(int nbcases, int dimCarres, Color couleurPaire, Color couleurImpaire)
        {
            //définition de la taille de la fenêtre en fonction de la taille du Damier
            this.ClientSize = new Size(nbcases * dimCarres, nbcases * dimCarres);
            //définition de la taille de la fenêtre en fonction de la taille du Damier
            panel1.Size = new Size(nbcases * dimCarres, nbcases * dimCarres);

            //La boucle for permet de gérer toutes les cases en même temps,
            //on fait une bouble pour gérer les lignes et une pour gérer les colonnes.
            for (int ligne = 0; ligne < nbcases; ligne++)
            {
                for (int colonne = 0; colonne < nbcases; colonne++)
                {
                    //Création des carrés et définition de leur taille
                    Button bouton = new Button();
                    bouton.Size = new System.Drawing.Size(dimCarres, dimCarres);
                    bouton.Left = colonne * dimCarres;
                    bouton.Top = ligne * dimCarres;
                    
                    
                    //définition des couleurs des carrés en fonction de leurs positions
                    //%2 == 0 -> pair %2==1 -> impair

                    if ((colonne + ligne) % 2 == 0 && (colonne + ligne) % 2 == 0)
                    {
                        bouton.BackColor = couleurPaire;
                    }
                    else
                    {
                        bouton.BackColor = couleurImpaire;
                    }
                    panel1.Controls.Add(bouton);
                }
            }
        }
       

 
    }
}
