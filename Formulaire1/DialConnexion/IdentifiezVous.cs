using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialConnexion
{
    public partial class IdentifiezVous : Form
    {
        public IdentifiezVous()
        {
            InitializeComponent();
            this.AcceptButton = btn_connection;
            this.CancelButton = btn_quitter;
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_connection_Click(object sender, EventArgs e)
        {
            if (IsIDValide(txtB_ID) && IsMdpValide(txB_mdp, txtB_ID))
            {
                this.DialogResult = DialogResult.OK;
                //else
                // {
                //      this.DialogResult = DialogResult.None; 
                // si propriété Dialog result = None inutile
                //}
            }
            

        }





        private void txtB_ID_Validating(object sender, CancelEventArgs e)
        {
            if (IsIDValide(txtB_ID) == false)
            {
                e.Cancel = true;
            } else
            {
                e.Cancel = false;
            }


            //On a la possibilité de mettre directement les errorProvider au sein du Validating
            #region errorprovider au sein du validating
            //errorProvider1.SetError(txtB_ID, string.Empty);
            //if (txtB_ID.Text == string.Empty || txtB_ID.Text == null)
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txtB_ID, "Vous devez renseigner un identifiant pour vous connecter");
            //} else if(txtB_ID.Text.Length>0 && txtB_ID.Text.Length<5)
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txtB_ID, "La longueur de l'identifiant ne peut être inférieure à 5 caractères");
            //} else
            //for (int i = 0; i < txtB_ID.TextLength; i++)
            //{
            //    if (!char.IsLetterOrDigit(txtB_ID.Text[i]))
            //    {
            //        e.Cancel = true;
            //        errorProvider1.SetError(txtB_ID, "L'identifiant ne peut contenir que des caractères alpha et des caractères numériques");
            //    }
            //    if (!char.IsLetter(txtB_ID.Text[0]))
            //    {
            //        e.Cancel = true;
            //        errorProvider1.SetError(txtB_ID, "Le premier caractère de l'identifiant doit obligatoirement être une lettre");
            //    }

            //}

            #endregion

        }

        private void txB_mdp_Validating(object sender, CancelEventArgs e)
        {

            if (IsMdpValide(txB_mdp,txtB_ID) == false)
            {
                e.Cancel = true;
            }
            else
                e.Cancel = false;

            //On a la possibilité de mettre directement les errorProvider au sein du Validating
            #region errorProvider au sein du Validating
            //errorProvider1.SetError(txB_mdp, string.Empty);
            //if(txB_mdp.Text == string.Empty || txB_mdp.Text == null)
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txB_mdp, "Vous devez renseigner un mot de passe pour vous connecter");
            //}
            //else if(txB_mdp.Text.Length<5)
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txB_mdp, "Le mot de passe saisie est incorect, sa longueur ne peut être inférieur à 5 caractères");
            //} else if(txB_mdp.Text!=txtB_ID.Text)
            //{
            //    e.Cancel = true; 
            //    errorProvider1.SetError(txB_mdp, "Le mot de passe est incorect, celui-ci doit être égal à l'identifiant");
            //}
            #endregion  
        }
        #region Mes petites méthodes de warrior :)
        /// <summary>
        /// Petite méthode qui qui va vérifier la validité de la saisie d'un identifiant dans une TextBox. 
        /// L'intérêt est de pouvoir la réutiliser par la suite
        /// </summary>
        /// <param name="mdp"></param>
        /// <param name="tupeuxpassortir"></param>
        /// <returns></returns>
        public bool IsMdpValide(Control mdp,Control id)
        {
            if (mdp.Text == string.Empty || mdp == null)
            {
                 errorProvider1.SetError(mdp, "Vous devez renseigner un mot de passe pour vous connecter");
                return false;
            }
            else if (mdp.Text.Length < 5)
            {
                errorProvider1.SetError(mdp, "Le mot de passe saisie est incorect, sa longueur ne peut être inférieur à 5 caractères");
                return false;
            }
            else if (mdp.Text != id.Text)
            {
               errorProvider1.SetError(mdp, "Le mot de passe est incorect, celui-ci doit être égal à l'identifiant");
               return false;
            }
            return true;
        }

        /// <summary>
        /// Petite méthode qui qui va vérifier la validité de la saisie d'un mot de passe dans une TextBox. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tupeuxpassortir"></param>
        /// <returns></returns>
        public bool IsIDValide(Control id)
        {
            errorProvider1.SetError(id, string.Empty);
            if (id.Text == string.Empty || id.Text == null)
            {
               errorProvider1.SetError(id, "Vous devez renseigner un identifiant pour vous connecter");
                return false;
            }  if (id.Text.Length > 0 && id.Text.Length < 5)
            {
                errorProvider1.SetError(id, "La longueur de l'identifiant ne peut être inférieure à 5 caractères");
                return false;
            }
            for (int i = 0; i < id.Text.Length; i++)
            {
                if (!char.IsLetterOrDigit(id.Text[i]))
                {
                    errorProvider1.SetError(id, "L'identifiant ne peut contenir que des caractères alpha et des caractères numériques");
                    return false;
                } 
                if (!char.IsLetter(id.Text[0]))
                {
                     errorProvider1.SetError(id, "Le premier caractère de l'identifiant doit obligatoirement être une lettre");
                    return false;
                }

            }
           
            return true;
        }
        #endregion

      
    }



}
