using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalariesDll;
using Utilitaires;
using GestionSalaraies.Properties;

namespace GestionSalaraies 
{
    public partial class DialConnexion : Form
    {
        Utilisateurs utilisateurs;
        Utilisateur utilisateur;
        Roles roles;
        Role role;
        
        public DialConnexion()
        {
            InitializeComponent();
            ChargerUtilisateur();
            
        }

        private void ChargerUtilisateur()
        {
            utilisateurs = new Utilisateurs();
            roles = new Roles();
            utilisateurs.Load(MonApplication.DispositifSauvegarde, Settings.Default.AppData);
        }
        #region Gestionnaires Evenements Validation

        /// <summary>
        /// Validation ID Utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIdentifiant_Validating(object sender, CancelEventArgs e)
        {
            epUtilisateur.SetError(txtMDP, String.Empty);
            if (IsIdCorrect(txtIdentifiant.Text))
            {
                epUtilisateur.SetError(txtIdentifiant, String.Empty);
            }
            else
            {
                epUtilisateur.SetError(txtIdentifiant, "Identifiant invalide");
            }

        }
        /// <summary>
        /// Interception du traitement de la touche
        /// Assignation de dialogResult Cancel sur Escap
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
				this.DialogResult = DialogResult.Cancel;
				 return base.ProcessDialogKey(keyData);
        }

        /// <summary>
        /// Vérification du mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMDP_Validating(object sender, CancelEventArgs e)
        {
            epUtilisateur.SetError(txtMDP, String.Empty);
            if (IsMotPasseCorrect(txtMDP.Text, txtIdentifiant.Text) )
            {
                epUtilisateur.SetError(txtMDP, String.Empty);
            }
            else
            {
                epUtilisateur.SetError(txtMDP, "Mot de passe incorrect");
                e.Cancel = true;
            }

        }
        #endregion



        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
        }

        private bool IsIdCorrect(string id)
        {
            
           
            utilisateur = utilisateurs.UtilisateurByMatricule(id);
             if (utilisateur==null)
            {
                epUtilisateur.SetError(txtIdentifiant,"Vous n'êtes pas inscrit dans notre base de données");
                return false;
            }
            if (!Utilisateur.IsIdentifiantValide(id))
            {
                return false;
            }
            //role = roles.RechercherRole(id);

            if (utilisateur.Role == null)
            {
                MessageBox.Show("Vous n'êtes pas habilité", "Habilitation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
		

        private bool IsMotPasseCorrect(string motPasse, string id)
        {
            if (String.IsNullOrEmpty(motPasse)) return false;
            if (motPasse.Length < 5) return false;

            
            return true;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            ConnectionResult connectionResult = utilisateur.Connecter(txtMDP.Text);
            utilisateurs.Save(MonApplication.DispositifSauvegarde, Settings.Default.AppData);
            switch (connectionResult)
                {
                    case ConnectionResult.CompteBloqué:
                        this.DialogResult = DialogResult.Abort;
                        break;
                    case ConnectionResult.Connecté:
                        this.DialogResult = DialogResult.OK;
                        break;
                    case ConnectionResult.MotPasseInvalide:
                        epUtilisateur.SetError(btnConnexion, string.Format("mot de passe invalide, nb d'essai restant : {0}", 3-utilisateur.NombreEchecsConsecutifs));
                        break;
                }
        }
    }
}

