using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace additionneur
{
    public partial class Additionneur : Form
    {
        int somme = 0;

        public int Somme
        {
            get
            {
                return somme;
            }

            set
            {
                this.somme = value;
            }
        }

        public  Additionneur()
        {
            InitializeComponent();
        }

        private void btn_vider_Click(object sender, EventArgs e)
        {
            affichage.Clear();
            Somme = 0;
        }


        //button1 = bouton additionner impossible de renommer
        private void button1_Click(object sender, EventArgs e)
        {

            affichage.Text += string.Format("={0}+", Somme);
 
        }

      
        

        private void btn_click(object sender, EventArgs e)
        {
            int val = int.Parse(((Button)sender).Text);
            Somme += val;
            affichage.Text += string.Format("{0}+", val);
        }
    }
}
