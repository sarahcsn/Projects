//s5 A2 exercice 3
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuxCaracteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _click_nboccurences(object sender, EventArgs e)
        {

            int pos = 0;
            int nbOcurrences = 0;
            while (pos != -1 && pos< _txtB_saisieChn.Text.Length && _txtB_portChn1.Text!=string.Empty)
            {
                pos = _txtB_saisieChn.Text.IndexOf(_txtB_portChn1.Text,pos);
                if(pos != -1 )
                {
                    nbOcurrences++;
                    pos += (_txtB_portChn1.Text.Length) ;
                }
            }
           _txtB_Result.Text=nbOcurrences.ToString();
            
        }

        private void RemplacerTtesOccurences(object sender, EventArgs e)
        {
            _txtB_Result.Text = _txtB_saisieChn.Text.Replace(_txtB_portChn1.Text, _txtB_portRemp2.Text);
        }

        private void Remplacer1occurence(object sender, EventArgs e)
        {
            int pos = _txtB_saisieChn.Text.IndexOf(_txtB_portChn1.Text);
            _txtB_Result.Text = (pos == -1 || _txtB_portRemp2.Text==string.Empty) 
                ? _txtB_saisieChn.Text
                :_txtB_saisieChn.Text.Remove(pos,_txtB_portRemp2.Text.Length-1).Insert(pos, _txtB_portRemp2.Text);
        }

        private void RemplacerDerOccurence(object sender, EventArgs e)
        {
            int pos = _txtB_saisieChn.Text.LastIndexOf(_txtB_portChn1.Text);
            _txtB_Result.Text = (pos == -1 || _txtB_portRemp2.Text == string.Empty)
                ? _txtB_saisieChn.Text
                : _txtB_saisieChn.Text.Remove(pos, _txtB_portRemp2.Text.Length - 1).Insert(pos, _txtB_portRemp2.Text);
        }
    }
}
