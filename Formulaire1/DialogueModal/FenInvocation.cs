using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueModal
{
    public partial class FenInvocation : Form
    {
        public FenInvocation()
        {
            InitializeComponent();
        }

        private void appeldialmod_click(object sender, EventArgs e)
        {
            DialogueModal dialogueModal = new DialogueModal();
            DialogResult resultat = dialogueModal.ShowDialog();

            switch (resultat)
            {
                case DialogResult.OK:
                    txtB_Result.Text = "ok";
                    break;
                case DialogResult.Abort:
                    txtB_Result.Text = "Abandon";
                    break;
                case DialogResult.Cancel:
                    txtB_Result.Text = "Annulation";
                    break;
            }

        }
    }
}
