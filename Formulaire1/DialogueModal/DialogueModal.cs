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
    public partial class DialogueModal : Form
    {
        public DialogueModal()
        {
            InitializeComponent();
            this.AcceptButton = btn_ok;
            this.AcceptButton = btn_abandon;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_abandon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            Close();
        }
    }
}
