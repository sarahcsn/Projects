using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelSalarie;

namespace ModificationSalaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Salarie sal;

        private void Form1_Load(object sender, EventArgs e)
        {
            sal = new Salarie() { Nom = "csn", Prenom = "Sarah", DateNaissance = new DateTime(1993, 11, 11), Matricule = "12PPP35", SalaireBrut = 2000, TauxCS = 0.1 };
            sal.ChangementSalary_EventHandler += Sal_ChangementSalary_EventHandler;
            sal.SalaireBrut = 3000;
        }

        private void Sal_ChangementSalary_EventHandler(object sender, ChangeSalaireEventArgs e)
        {
            _txtB_oldSalary.Text = sal.SalaireBrut.ToString();
        }
    }
}
   

    

