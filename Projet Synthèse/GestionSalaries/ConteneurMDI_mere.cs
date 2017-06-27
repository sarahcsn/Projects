using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSalaraies
{
    public partial class ConteneurMDI_mere : Form
    {
        public ConteneurMDI_mere()
        {
            InitializeComponent();
            
        }

        private void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUtilisateurs gestionDesUtilisateurs = new FrmUtilisateurs();
            gestionDesUtilisateurs.MdiParent = this;
            gestionDesUtilisateurs.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void gestionDesSalariésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalaries gestionDesSalaries = new FrmSalaries();
            gestionDesSalaries.MdiParent = this;
            gestionDesSalaries.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void lklb_Connection_click(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
