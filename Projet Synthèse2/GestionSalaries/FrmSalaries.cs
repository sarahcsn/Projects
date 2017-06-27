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
using Utilitaires;
using GestionSalaraies.Properties;
using System.Globalization;
namespace GestionSalaraies
{
    public partial class FrmSalaries : Form
    {

        Salarie salarie;
        Salaries salaries;
        private static int coche;
        private static int creation;


        public FrmSalaries()
        {
            InitializeComponent();
        }
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
        void GestionnaireContextes(Contextes contexte)

        {

            switch (contexte)
            {
                case Contextes.Initial:
                    //état initial du formulaire
                    cb_ChoixSalarie.Enabled = (cb_ChoixSalarie.Items.Count > 0);
                    btn_NouveauSalarie.Enabled = true;
                    gb_DetailSalarie.Visible = false;
                    break;
                case Contextes.Consultation:
                    //Je rend le groupebox "détail Salarié Visible" au clic sur consultation
                    gb_DetailSalarie.Visible = true;

                    //J'autorise(true) ou non (false) l'utilisateur à cliquer sur les boutons
                    btn_NouveauSalarie.Enabled = true;
                    pnl_Boutons.Enabled = true; // plus le panel pour autoriser l'accès
                    btn_Modifier.Enabled = true;
                    btn_Annuler.Enabled = false;
                    btn_Valider.Enabled = false;
                    chb_IsACommercial.Enabled = false;
                    btn_Annuler.Visible = false; // et je rend les boutons dont je n'ai pas besoin invisible
                    btn_Valider.Visible = false;


                    // J'autorise la modification (false) ou la lecture(true) des champs de Salariés
                    //dans gb_DetailSalarie
                    txtB_Matricule.ReadOnly = true;
                    txtB_Nom.ReadOnly = true;
                    txtB_Prenom.ReadOnly = true;
                    mTxtB_DateDeNaissance.ReadOnly = true;
                    txtB_SalaireBrut.ReadOnly = true;
                    mTxtB_TauxCS.ReadOnly = true;
                    txtB_SalaireNet.ReadOnly = true;

                    //dans Panel pn_Commercial
                    if (IsPanelVisible(Pn_commercial) == true && Pn_commercial.Visible == true)
                    {
                        txtB_TauxCom_Commercial.ReadOnly = true;
                        txtB_TauxCom_Commercial.Visible = true;
                        txtB_CA__commercial.ReadOnly = true;
                        txtB_CA__commercial.Visible = true;
                    }
                    else
                    {
                        Pn_commercial.Visible = false;
                    }
                    break;


                case Contextes.ModificationInitiale:
                    {


                        //Je rend le groupebox "détail Salarié Visible" au clic sur consultation
                        gb_DetailSalarie.Visible = true;

                        //J'autorise(true) ou non (false) l'utilisateur à cliquer sur les boutons
                        btn_NouveauSalarie.Enabled = false;
                        cb_ChoixSalarie.Enabled = false;
                        pnl_Boutons.Enabled = true; // plus le panel pour autoriser l'accès
                        btn_Modifier.Enabled = false;
                        btn_Annuler.Enabled = true;
                        btn_Valider.Enabled = true;
                        btn_Annuler.Visible = true; // je rend mes boutons visibles
                        btn_Valider.Visible = true;
                        chb_IsACommercial.Enabled = true;

                        // J'autorise la modification (false) ou la lecture(true) des champs de Salariés
                        //dans gb_DetailSalarie
                        txtB_Matricule.ReadOnly = false;
                        txtB_Nom.ReadOnly = false;
                        txtB_Prenom.ReadOnly = false;
                        mTxtB_DateDeNaissance.ReadOnly = false;
                        txtB_SalaireBrut.ReadOnly = false;
                        mTxtB_TauxCS.ReadOnly = false;
                        txtB_SalaireNet.ReadOnly = true;


                        //dans Panel pn_Commercial

                        if (IsPanelVisible(Pn_commercial) == true)
                        {
                            txtB_TauxCom_Commercial.ReadOnly = false;
                            txtB_CA__commercial.ReadOnly = false;
                        }
                        break;
                    }
                case Contextes.ModificationAnnuler:

                    GestionnaireContextes(Contextes.Consultation);
                    break;
                case Contextes.ModificationValider:
                    GestionnaireContextes(Contextes.ModificationInitiale);

                    break;
                case Contextes.AjoutInitial:

                    
                    //Je rend le groupebox "détail Salarié Visible" au clic sur consultation
                    gb_DetailSalarie.Visible = true;

                    //J'autorise(true) ou non (false) l'utilisateur à cliquer sur les boutons
                    btn_NouveauSalarie.Enabled = true;
                    cb_ChoixSalarie.Enabled = false;
                    pnl_Boutons.Enabled = true; // plus le panel pour autoriser l'accès
                    btn_Annuler.Visible = true; // je rend mes boutons invisibles
                    btn_Annuler.Enabled = true;
                    btn_Valider.Enabled = true;
                    btn_Valider.Visible = true;
                    btn_Modifier.Visible = false;
                    chb_IsACommercial.Enabled = true;

                    // J'autorise la modification (false) ou la lecture(true) des champs de Salariés
                    //dans gb_DetailSalarie
                    txtB_Matricule.ReadOnly = false;
                    txtB_Nom.ReadOnly = false;
                    txtB_Prenom.ReadOnly = false;
                    mTxtB_DateDeNaissance.ReadOnly = false;
                    txtB_SalaireBrut.ReadOnly = false;
                    mTxtB_TauxCS.ReadOnly = false;
                    txtB_SalaireNet.ReadOnly = true;


                    //dans Panel pn_Commercial

                    if (IsPanelVisible(Pn_commercial) == true)
                    {
                        txtB_TauxCom_Commercial.ReadOnly = false;
                        txtB_CA__commercial.ReadOnly = false;
                    }
                    break;
                case Contextes.AjoutValider:
                    GestionnaireContextes(Contextes.AjoutInitial);
                    break;

                default:
                    break;
            }

        }
        private void ChargerValeursSalarie()
        {
            txtB_Matricule.Text = salarie.Matricule;
            txtB_Nom.Text = salarie.Nom;
            txtB_Prenom.Text = salarie.Prenom;
            mTxtB_DateDeNaissance.Text = salarie.DateNaissance.ToString();
            txtB_SalaireBrut.Text = salarie.SalaireBrut.ToString();
            mTxtB_TauxCS.Text = salarie.TauxCS.ToString();

            //chargement si commercial
            if (IsPanelVisible(Pn_commercial) == true)
            {
                txtB_TauxCom_Commercial.Text = ((Commercial)salarie).Commission.ToString();
                txtB_CA__commercial.Text = ((Commercial)salarie).ChiffreAffaire.ToString();
                txtB_SalaireNet.Text = ((Commercial)salarie).SalaireNet.ToString();
            }
            else

                txtB_SalaireNet.Text = salarie.SalaireNet.ToString();
        }
        private void ChargerSalaries() // nouveau salarié
        {
            salaries = new Salaries();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            salaries.Load(serialiseur, Properties.Settings.Default.AppData);
            foreach (Salarie item in salaries)
            {
                cb_ChoixSalarie.Items.Add(item.Matricule);
            }
        }
        private void SaveSalaries()
        {

            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            salaries.Save(serialiseur, Properties.Settings.Default.AppData);
        }

        private void NouveauSalarie()
        {
            salarie = new Salarie()
            {
                Matricule = txtB_Matricule.Text,
                Nom = txtB_Nom.Text,
                Prenom = txtB_Prenom.Text,
                DateNaissance = Convert.ToDateTime(mTxtB_DateDeNaissance.Text),
                SalaireBrut = Convert.ToDecimal(txtB_SalaireBrut.Text),
                TauxCS = Convert.ToDecimal(mTxtB_TauxCS.Text)
            };
            if (Pn_commercial.Visible == true)
            {
                ((Commercial)salarie).Commission = Convert.ToDecimal(txtB_TauxCom_Commercial.Text);
                ((Commercial)salarie).ChiffreAffaire = Convert.ToDecimal(txtB_CA__commercial.Text);
            }
            salaries.Add(salarie);
            ChargerSalaries();

        }
        private void ModifierSalarie()
        {

            if (IsValidChampsSalarie())
            {
                try
                {
                    ep_Salarie.SetError(gb_DetailSalarie, string.Empty);
                    salarie.Matricule = txtB_Matricule.Text;
                    salarie.Nom = txtB_Nom.Text;
                    salarie.Prenom = txtB_Prenom.Text;
                    salarie.DateNaissance = Convert.ToDateTime(mTxtB_DateDeNaissance.Text);
                    salarie.SalaireBrut = Convert.ToDecimal(txtB_SalaireBrut.Text);
                    salarie.TauxCS = Convert.ToDecimal(mTxtB_TauxCS.Text);
                    if (Pn_commercial.Visible == true)
                    {
                        ((Commercial)salarie).Commission = Convert.ToDecimal(txtB_TauxCom_Commercial.Text);
                        ((Commercial)salarie).ChiffreAffaire = Convert.ToDecimal(txtB_CA__commercial.Text);
                       //txtB_SalaireNet.Text = ((Commercial)salarie).SalaireNet.ToString();
                    }else
                    {
                        //txtB_SalaireNet.Text = salarie.SalaireNet.ToString();
                    }
                }
                catch (Exception)
                {

                   ep_Salarie.SetError(gb_DetailSalarie, "Les champs renseignés ne sont pas valides");
                }


            }
        }

        private bool IsValidChampsSalarie()
        {
           
            bool valid = true;
            ep_Salarie.SetError(txtB_Matricule, string.Empty);
            ep_Salarie.SetError(txtB_Nom, string.Empty);
            ep_Salarie.SetError(txtB_Prenom, string.Empty);
            ep_Salarie.SetError(mTxtB_DateDeNaissance, string.Empty);


            if (!Salarie.IsMatriculeValide(txtB_Matricule.Text))
            {
                valid = false;
                ep_Salarie.SetError(txtB_Matricule, "Le matricule n'est pas valide");

            }
            else if (!Salarie.IsNomPrenomValide(txtB_Nom.Text))
            {
                valid = false;
                ep_Salarie.SetError(txtB_Nom, "Le nom n'est pas valide");

            }
            else if (!Salarie.IsNomPrenomValide(txtB_Prenom.Text))
            {
                valid = false;
                ep_Salarie.SetError(txtB_Prenom, "Le prénom n'est pas valide");

            }
            
            else if (!Salarie.IsDateNaissanceValide(DateTime.Parse(mTxtB_DateDeNaissance.Text)))
            {
                valid = false;
                ep_Salarie.SetError(mTxtB_DateDeNaissance, "La date de naissance n'est pas valide");

            }


            else
            {
                ep_Salarie.SetError(txtB_Matricule, string.Empty);
                ep_Salarie.SetError(txtB_Nom, string.Empty);
                ep_Salarie.SetError(txtB_Prenom, string.Empty);
                ep_Salarie.SetError(mTxtB_DateDeNaissance, string.Empty);
            }



            return valid;
        }

        private void FrmSalaries_Load(object sender, EventArgs e)
        {
            ChargerSalaries();
            GestionnaireContextes(Contextes.Initial);
        }

        private void cb_ChoixSalarie_SelectedIndexChanged(object sender, EventArgs e)
        {
            salarie = salaries.ExtraireSalarie(cb_ChoixSalarie.Items[cb_ChoixSalarie.SelectedIndex].ToString());
            ChargerValeursSalarie();
            GestionnaireContextes(Contextes.Consultation);

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.ModificationInitiale);
            creation = 0;




        }
        private void NettoyerSalarie()
        {
            txtB_Matricule.Clear();
            txtB_Nom.Clear();
            txtB_Prenom.Clear();
            mTxtB_DateDeNaissance.Clear();
            txtB_SalaireBrut.Clear();
            mTxtB_TauxCS.Clear();
            txtB_TauxCom_Commercial.Clear();
            txtB_CA__commercial.Clear();
            txtB_SalaireNet.Clear();
            chb_IsACommercial.CheckState = CheckState.Unchecked;
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            if (creation != 1)
            {
                GestionnaireContextes(Contextes.ModificationAnnuler);
                ChargerValeursSalarie();
            }
            else
            {
                NettoyerSalarie();
                GestionnaireContextes(Contextes.Consultation);
                cb_ChoixSalarie.Enabled = true;
               

            }


        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if (creation == 1)
            {
                GestionnaireContextes(Contextes.AjoutValider);
                ModifierSalarie();
                SaveSalaries();
                
            }
            else
            if (IsValidChampsSalarie() == true)
            {
                GestionnaireContextes(Contextes.ModificationValider);
                ModifierSalarie();
                SaveSalaries();
                
            }
        }

        private void btn_NouveauSalarie_Click(object sender, EventArgs e)
        {

            GestionnaireContextes(Contextes.AjoutInitial);
            NettoyerSalarie();
            creation = 1;

        }

        private bool IsPanelVisible(Control panel)
        {
            if (salarie is Commercial || coche == 1)
            {
                panel.Visible = true;
                return panel.Visible;
            }

            panel.Visible = false;
            return panel.Visible;
        }


        private void chb_IsCommercial_CheckedChanged(object sender, EventArgs e)
        {
            Pn_commercial.Visible = (((CheckBox)sender).CheckState == CheckState.Checked);
            coche = 1;
        }
    }
}
