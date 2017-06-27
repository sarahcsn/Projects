using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalariesDll;
using GestionSalaraies.Properties;
using Utilitaires;


namespace GestionSalaraies
{
    
    public partial class FrmUtilisateurs : Form
    {
        Utilisateurs utilisateurs;
        Roles roles;
        Utilisateur utilisateur;
        Salarie salarie;



        enum Contextes
        {
            Initial = 0,
            Consultation = 1,
            ModificationInitiale = 2,
            ModificationAnnuler = 3,
            ModificationValider = 4,
            AjoutInitial = 5,
            AjoutValider = 6

        }
        public FrmUtilisateurs()
        {
            InitializeComponent();

        }

        void GestionnaireContextes(Contextes contexte)

        {

            switch (contexte)
            {
                case Contextes.Initial:
                    cb_Utilisateurs.Enabled = (cb_Utilisateurs.Items.Count > 0);
                    btn_Nouveau.Enabled = true;
                    gbDetailUtilisateur.Visible = false;
                    break;

                case Contextes.Consultation:
                    //je rend le groupbox visible
                    gbDetailUtilisateur.Visible = true;

                    //Je rend les boutons accessibles ou non
                    btn_Nouveau.Enabled = true;
                    pnl_Boutons.Enabled = true;
                    btn_Modifier.Enabled = true;
                    btn_Annuler.Enabled = false;
                    btn_Valider.Enabled = false;

                    // Acces en lecture seule(true) ou acces pour modification(false)
                    txtB_id.ReadOnly = true;
                    txtB_mdp.ReadOnly = true;
                    txtB_Nom.ReadOnly = true;
                    chkCompteBloque.Enabled = false;
                    cb_Roles.Enabled = false;
                    break;

                case Contextes.ModificationInitiale:
                    //je rend le groupbox visible
                    gbDetailUtilisateur.Visible = true;

                    //Je rend les boutons accessibles ou non
                    btn_Nouveau.Enabled = false;
                    cb_Utilisateurs.Enabled = false;
                    pnl_Boutons.Enabled = true;
                    btn_Modifier.Enabled = false;
                    btn_Annuler.Enabled = true;
                    btn_Valider.Enabled = true;

                    // Acces en lecture seule(true) ou acces pour modification(false)
                    txtB_id.ReadOnly = true;
                    txtB_mdp.ReadOnly = false;
                    txtB_Nom.ReadOnly = false;
                    chkCompteBloque.Enabled = true;
                    cb_Roles.Enabled = true;
                    break;
                case Contextes.ModificationAnnuler:
                    GestionnaireContextes(Contextes.Consultation);
                    break;
                case Contextes.ModificationValider:
                    GestionnaireContextes(Contextes.ModificationInitiale);
                    break;
                case Contextes.AjoutInitial:
                    //je rend le groupbox visible
                    gbDetailUtilisateur.Visible = true;

                    //Je rend les boutons accessibles ou non
                    btn_Nouveau.Enabled = true;
                    cb_Utilisateurs.Enabled = false;
                    pnl_Boutons.Enabled = true;
                    btn_Modifier.Enabled = false;
                    btn_Annuler.Enabled = true;
                    btn_Valider.Enabled = true;

                    // Acces en lecture seule(true) ou acces pour modification(false)
                    txtB_id.ReadOnly = false;
                    txtB_mdp.ReadOnly = false;
                    txtB_Nom.ReadOnly = false;
                    chkCompteBloque.Enabled = false;
                    cb_Roles.Enabled = true;
                    break;

                case Contextes.AjoutValider:
                    GestionnaireContextes(Contextes.AjoutInitial);
                    break;
                default:
                    break;
            }

        }

        private void ChargerValeursUtilisateur()
        {
            txtB_id.Text = utilisateur.Identifiant;
            txtB_mdp.Text = utilisateur.MotDePasse;
            txtB_Nom.Text = utilisateur.Nom;
            chkCompteBloque.Checked = utilisateur.CompteBloque;
            foreach (var item in cb_Roles.Items)
            {
                if (item.ToString() == utilisateur.Role.Identifiant)
                {
                    cb_Roles.SelectedItem = item;
                    break;
                }
            }
        }
        private void ModifierUtilisateur()
        {

            if (IsValidChamps())
            {
                try
                {
                    utilisateur.Identifiant = txtB_id.Text;
                    utilisateur.MotDePasse = txtB_mdp.Text;
                    txtB_Nom.Text = utilisateur.Nom;
                    chkCompteBloque.Checked = utilisateur.CompteBloque;

                }
                catch (Exception)
                {

                    epUtilisateur.SetError(gbDetailUtilisateur, "Les champs entrés ne sont pas valides");
                }


            }
        }

        private bool IsValidChamps()
        {
            bool valid = true;

            if (!Utilisateur.IsIdentifiantValide(txtB_id.Text))
            {
                valid = false;
                epUtilisateur.SetError(txtB_id, "L'identifiant n'est pas valide");

            }
            if (!Utilisateur.IsMotPasseValide(txtB_mdp.Text))
            {
                valid = false;
                epUtilisateur.SetError(txtB_mdp, "Le mot de passe n'est pas valide");
            }
            //if(utilisateur.Nom != salarie.Nom)
            //{

            //}
            else
            {
                epUtilisateur.SetError(txtB_id, string.Empty);
            }

           
           


            return valid;
        }


        private void ChargerRoles()
        {
            roles = new Roles();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            roles.Load(serialiseur, Properties.Settings.Default.AppData);

            foreach (Role item in roles)
            {
                cb_Roles.Items.Add(item.Identifiant);
            }
        }

        private void ChargerUtilisateurs()
        {
            utilisateurs = new Utilisateurs();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            utilisateurs.Load(serialiseur, Properties.Settings.Default.AppData);
            foreach (Utilisateur item in utilisateurs)
            {
                cb_Utilisateurs.Items.Add(item.Identifiant);
            }
        }
        private void CreerUtilisateur()
        {
            
            utilisateur = new Utilisateur()
            {
                Nom = txtB_Nom.Text,
                Identifiant = txtB_id.Text,
                MotDePasse = txtB_mdp.Text,
                CompteBloque = false,
                Role = roles.RechercherRole(cb_Roles.Text)
            };
        }
        private void SauverUtilisateur()
        { 
           

            utilisateurs.Add(utilisateur);
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            utilisateurs.Load(serialiseur, Properties.Settings.Default.AppData);
            foreach (Utilisateur item in utilisateurs)
            {
                cb_Utilisateurs.Items.Add(item.Identifiant);
            }
        }

    private void FrmUtilisateurs_Load(object sender, EventArgs e)
        {
            ChargerUtilisateurs();
            ChargerRoles();
            GestionnaireContextes(Contextes.Initial);
        }

        private void cbUtilisateurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            utilisateur = utilisateurs.UtilisateurByMatricule(cb_Utilisateurs.Items[cb_Utilisateurs.SelectedIndex].ToString());
            ChargerValeursUtilisateur();
            GestionnaireContextes(Contextes.Consultation);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.ModificationInitiale);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.ModificationAnnuler);
        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.AjoutInitial);
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.AjoutValider);
            CreerUtilisateur();
            SauverUtilisateur();
        }
    }
}
