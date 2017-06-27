using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_et_RadioButton
{
    public partial class Policetext : Form
    {
        public Policetext()
        {
            InitializeComponent();
            _choix.Visible = false;
            _choixcaracteres.Visible = false;
            _choixcasse.Visible = false;
            _choixfond.Visible = false;
        }
     

        private void taper_txt_TextChanged(object sender, EventArgs e)
        {
            if(taper_txt.Text.Length==0)
            {
                _choix.Visible=false;
            }else
            {
                _choix.Visible = true;
            }
            _message.Text = taper_txt.Text;
            
        }

        private void choix_fond_CheckStateChanged(object sender, EventArgs e)
        {
            _choixfond.Visible = (((CheckBox) sender).CheckState == CheckState.Checked);
            
        }

        private void choix_caracteres_color_CheckStateChanged(object sender, EventArgs e)
        {
            _choixcaracteres.Visible = (((CheckBox)sender).CheckState == CheckState.Checked);
        }

        private void choix_casse_CheckStateChanged(object sender, EventArgs e)
        {
            _choixcasse.Visible = (((CheckBox)sender).CheckState == CheckState.Checked);
        }

        private void _rougefd_CheckedChanged(object sender, EventArgs e)
        {
            if (_rougefd.Checked)
            {
                _message.BackColor = Color.Tomato;
            }
            else if (_vertfd.Checked)
            {
                _message.BackColor = Color.LightGreen;
            }
            else if (_bleufd.Checked)
            {
                _message.BackColor = Color.SkyBlue;
            }
            
        }

        private void _rougeCar_CheckedChanged(object sender, EventArgs e)
        {
            if (_rougeCar.Checked)
            {
                _message.ForeColor = Color.Red;
            }
            else if (_blancCar.Checked)
            {
                _message.ForeColor = Color.White;
            }
            else if (_noirCar.Checked)
            {
                _message.ForeColor = Color.Black;
            }
           
        }

        private void _minusCasse_CheckedChanged(object sender, EventArgs e)
        {
            if (_minusCasse.Checked) 
            {
                _message.Text=taper_txt.Text.ToLower();
            }else if (_majusCasse.Checked)
            {
                _message.Text = taper_txt.Text.ToUpper();
            }
        }
    }
}
