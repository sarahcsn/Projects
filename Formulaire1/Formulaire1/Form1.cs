using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaire1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void recopier_Click(object sender, EventArgs e)
        {
            reponse.Text = textBox1.Text;
            textBox1.Clear();
            textBox1.Focus();
        }

       

      

        private void quitter_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void effacer_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
