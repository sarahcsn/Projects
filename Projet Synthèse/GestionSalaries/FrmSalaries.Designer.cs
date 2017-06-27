namespace GestionSalaraies
{
    partial class FrmSalaries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb_DetailSalarie = new System.Windows.Forms.GroupBox();
            this.txtB_SalaireBrut = new System.Windows.Forms.TextBox();
            this.txtB_SalaireNet = new System.Windows.Forms.TextBox();
            this.lb_salaireNet = new System.Windows.Forms.Label();
            this.mTxtB_TauxCS = new System.Windows.Forms.MaskedTextBox();
            this.lb_TxCS = new System.Windows.Forms.Label();
            this.lb_DateNaissance = new System.Windows.Forms.Label();
            this.mTxtB_DateDeNaissance = new System.Windows.Forms.MaskedTextBox();
            this.pnl_Boutons = new System.Windows.Forms.Panel();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.txtB_Prenom = new System.Windows.Forms.TextBox();
            this.txtB_Nom = new System.Windows.Forms.TextBox();
            this.lb_SalaireBrut = new System.Windows.Forms.Label();
            this.lb_prenom = new System.Windows.Forms.Label();
            this.lb_nom = new System.Windows.Forms.Label();
            this.txtB_Matricule = new System.Windows.Forms.TextBox();
            this.lb_matricule = new System.Windows.Forms.Label();
            this.Pn_commercial = new System.Windows.Forms.Panel();
            this.txtB_TauxCom_Commercial = new System.Windows.Forms.MaskedTextBox();
            this.txtB_CA__commercial = new System.Windows.Forms.TextBox();
            this.lb_TxCommission = new System.Windows.Forms.Label();
            this.lb_CA = new System.Windows.Forms.Label();
            this.lb_choixsalarie = new System.Windows.Forms.Label();
            this.cb_ChoixSalarie = new System.Windows.Forms.ComboBox();
            this.btn_NouveauSalarie = new System.Windows.Forms.Button();
            this.ep_Salarie = new System.Windows.Forms.ErrorProvider(this.components);
            this.chb_IsACommercial = new System.Windows.Forms.CheckBox();
            this.gb_DetailSalarie.SuspendLayout();
            this.pnl_Boutons.SuspendLayout();
            this.Pn_commercial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Salarie)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_DetailSalarie
            // 
            this.gb_DetailSalarie.Controls.Add(this.chb_IsACommercial);
            this.gb_DetailSalarie.Controls.Add(this.txtB_SalaireBrut);
            this.gb_DetailSalarie.Controls.Add(this.txtB_SalaireNet);
            this.gb_DetailSalarie.Controls.Add(this.lb_salaireNet);
            this.gb_DetailSalarie.Controls.Add(this.mTxtB_TauxCS);
            this.gb_DetailSalarie.Controls.Add(this.lb_TxCS);
            this.gb_DetailSalarie.Controls.Add(this.lb_DateNaissance);
            this.gb_DetailSalarie.Controls.Add(this.mTxtB_DateDeNaissance);
            this.gb_DetailSalarie.Controls.Add(this.pnl_Boutons);
            this.gb_DetailSalarie.Controls.Add(this.txtB_Prenom);
            this.gb_DetailSalarie.Controls.Add(this.txtB_Nom);
            this.gb_DetailSalarie.Controls.Add(this.lb_SalaireBrut);
            this.gb_DetailSalarie.Controls.Add(this.lb_prenom);
            this.gb_DetailSalarie.Controls.Add(this.lb_nom);
            this.gb_DetailSalarie.Controls.Add(this.txtB_Matricule);
            this.gb_DetailSalarie.Controls.Add(this.lb_matricule);
            this.gb_DetailSalarie.Controls.Add(this.Pn_commercial);
            this.gb_DetailSalarie.Location = new System.Drawing.Point(24, 74);
            this.gb_DetailSalarie.Margin = new System.Windows.Forms.Padding(2);
            this.gb_DetailSalarie.Name = "gb_DetailSalarie";
            this.gb_DetailSalarie.Padding = new System.Windows.Forms.Padding(2);
            this.gb_DetailSalarie.Size = new System.Drawing.Size(359, 495);
            this.gb_DetailSalarie.TabIndex = 7;
            this.gb_DetailSalarie.TabStop = false;
            this.gb_DetailSalarie.Text = "Détails Salarié";
            // 
            // txtB_SalaireBrut
            // 
            this.txtB_SalaireBrut.Location = new System.Drawing.Point(213, 172);
            this.txtB_SalaireBrut.Margin = new System.Windows.Forms.Padding(2);
            this.txtB_SalaireBrut.Name = "txtB_SalaireBrut";
            this.txtB_SalaireBrut.ReadOnly = true;
            this.txtB_SalaireBrut.Size = new System.Drawing.Size(132, 20);
            this.txtB_SalaireBrut.TabIndex = 17;
            this.txtB_SalaireBrut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB_SalaireNet
            // 
            this.txtB_SalaireNet.Location = new System.Drawing.Point(206, 375);
            this.txtB_SalaireNet.Name = "txtB_SalaireNet";
            this.txtB_SalaireNet.ReadOnly = true;
            this.txtB_SalaireNet.Size = new System.Drawing.Size(133, 20);
            this.txtB_SalaireNet.TabIndex = 10;
            this.txtB_SalaireNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_salaireNet
            // 
            this.lb_salaireNet.AutoSize = true;
            this.lb_salaireNet.Location = new System.Drawing.Point(21, 382);
            this.lb_salaireNet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_salaireNet.Name = "lb_salaireNet";
            this.lb_salaireNet.Size = new System.Drawing.Size(62, 13);
            this.lb_salaireNet.TabIndex = 9;
            this.lb_salaireNet.Text = "SalaireNet :";
            // 
            // mTxtB_TauxCS
            // 
            this.mTxtB_TauxCS.Location = new System.Drawing.Point(213, 209);
            this.mTxtB_TauxCS.Mask = "00.00%";
            this.mTxtB_TauxCS.Name = "mTxtB_TauxCS";
            this.mTxtB_TauxCS.ReadOnly = true;
            this.mTxtB_TauxCS.Size = new System.Drawing.Size(132, 20);
            this.mTxtB_TauxCS.TabIndex = 8;
            this.mTxtB_TauxCS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_TxCS
            // 
            this.lb_TxCS.AutoSize = true;
            this.lb_TxCS.Location = new System.Drawing.Point(16, 216);
            this.lb_TxCS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TxCS.Name = "lb_TxCS";
            this.lb_TxCS.Size = new System.Drawing.Size(137, 13);
            this.lb_TxCS.TabIndex = 7;
            this.lb_TxCS.Text = "Taux de Charges Sociales :";
            // 
            // lb_DateNaissance
            // 
            this.lb_DateNaissance.AutoSize = true;
            this.lb_DateNaissance.Location = new System.Drawing.Point(16, 142);
            this.lb_DateNaissance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_DateNaissance.Name = "lb_DateNaissance";
            this.lb_DateNaissance.Size = new System.Drawing.Size(104, 13);
            this.lb_DateNaissance.TabIndex = 5;
            this.lb_DateNaissance.Text = "Date de Naissance :";
            // 
            // mTxtB_DateDeNaissance
            // 
            this.mTxtB_DateDeNaissance.Location = new System.Drawing.Point(213, 135);
            this.mTxtB_DateDeNaissance.Mask = "00/00/0000";
            this.mTxtB_DateDeNaissance.Name = "mTxtB_DateDeNaissance";
            this.mTxtB_DateDeNaissance.ReadOnly = true;
            this.mTxtB_DateDeNaissance.Size = new System.Drawing.Size(132, 20);
            this.mTxtB_DateDeNaissance.TabIndex = 4;
            this.mTxtB_DateDeNaissance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mTxtB_DateDeNaissance.ValidatingType = typeof(System.DateTime);
            // 
            // pnl_Boutons
            // 
            this.pnl_Boutons.Controls.Add(this.btn_Valider);
            this.pnl_Boutons.Controls.Add(this.btn_Annuler);
            this.pnl_Boutons.Controls.Add(this.btn_Modifier);
            this.pnl_Boutons.Location = new System.Drawing.Point(19, 415);
            this.pnl_Boutons.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Boutons.Name = "pnl_Boutons";
            this.pnl_Boutons.Size = new System.Drawing.Size(325, 60);
            this.pnl_Boutons.TabIndex = 3;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(235, 17);
            this.btn_Valider.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(56, 23);
            this.btn_Valider.TabIndex = 0;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(130, 17);
            this.btn_Annuler.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(56, 23);
            this.btn_Annuler.TabIndex = 0;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(32, 17);
            this.btn_Modifier.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(56, 23);
            this.btn_Modifier.TabIndex = 0;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // txtB_Prenom
            // 
            this.txtB_Prenom.Location = new System.Drawing.Point(212, 91);
            this.txtB_Prenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtB_Prenom.Name = "txtB_Prenom";
            this.txtB_Prenom.ReadOnly = true;
            this.txtB_Prenom.Size = new System.Drawing.Size(132, 20);
            this.txtB_Prenom.TabIndex = 1;
            this.txtB_Prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB_Nom
            // 
            this.txtB_Nom.Location = new System.Drawing.Point(213, 50);
            this.txtB_Nom.Margin = new System.Windows.Forms.Padding(2);
            this.txtB_Nom.Name = "txtB_Nom";
            this.txtB_Nom.ReadOnly = true;
            this.txtB_Nom.Size = new System.Drawing.Size(132, 20);
            this.txtB_Nom.TabIndex = 1;
            this.txtB_Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_SalaireBrut
            // 
            this.lb_SalaireBrut.AutoSize = true;
            this.lb_SalaireBrut.Location = new System.Drawing.Point(16, 179);
            this.lb_SalaireBrut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_SalaireBrut.Name = "lb_SalaireBrut";
            this.lb_SalaireBrut.Size = new System.Drawing.Size(67, 13);
            this.lb_SalaireBrut.TabIndex = 0;
            this.lb_SalaireBrut.Text = "Salaire Brut :";
            // 
            // lb_prenom
            // 
            this.lb_prenom.AutoSize = true;
            this.lb_prenom.Location = new System.Drawing.Point(16, 98);
            this.lb_prenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_prenom.Name = "lb_prenom";
            this.lb_prenom.Size = new System.Drawing.Size(49, 13);
            this.lb_prenom.TabIndex = 0;
            this.lb_prenom.Text = "Prénom :";
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Location = new System.Drawing.Point(16, 57);
            this.lb_nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(35, 13);
            this.lb_nom.TabIndex = 0;
            this.lb_nom.Text = "Nom :";
            // 
            // txtB_Matricule
            // 
            this.txtB_Matricule.Location = new System.Drawing.Point(213, 13);
            this.txtB_Matricule.Margin = new System.Windows.Forms.Padding(2);
            this.txtB_Matricule.Name = "txtB_Matricule";
            this.txtB_Matricule.ReadOnly = true;
            this.txtB_Matricule.Size = new System.Drawing.Size(132, 20);
            this.txtB_Matricule.TabIndex = 1;
            this.txtB_Matricule.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_matricule
            // 
            this.lb_matricule.AutoSize = true;
            this.lb_matricule.Location = new System.Drawing.Point(16, 20);
            this.lb_matricule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_matricule.Name = "lb_matricule";
            this.lb_matricule.Size = new System.Drawing.Size(50, 13);
            this.lb_matricule.TabIndex = 0;
            this.lb_matricule.Text = "Matricule";
            // 
            // Pn_commercial
            // 
            this.Pn_commercial.Controls.Add(this.txtB_TauxCom_Commercial);
            this.Pn_commercial.Controls.Add(this.txtB_CA__commercial);
            this.Pn_commercial.Controls.Add(this.lb_TxCommission);
            this.Pn_commercial.Controls.Add(this.lb_CA);
            this.Pn_commercial.Location = new System.Drawing.Point(15, 274);
            this.Pn_commercial.Name = "Pn_commercial";
            this.Pn_commercial.Size = new System.Drawing.Size(330, 86);
            this.Pn_commercial.TabIndex = 16;
            this.Pn_commercial.Visible = false;
            // 
            // txtB_TauxCom_Commercial
            // 
            this.txtB_TauxCom_Commercial.Location = new System.Drawing.Point(188, 16);
            this.txtB_TauxCom_Commercial.Mask = "00.00%";
            this.txtB_TauxCom_Commercial.Name = "txtB_TauxCom_Commercial";
            this.txtB_TauxCom_Commercial.ReadOnly = true;
            this.txtB_TauxCom_Commercial.Size = new System.Drawing.Size(132, 20);
            this.txtB_TauxCom_Commercial.TabIndex = 9;
            this.txtB_TauxCom_Commercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtB_TauxCom_Commercial.Visible = false;
            // 
            // txtB_CA__commercial
            // 
            this.txtB_CA__commercial.Location = new System.Drawing.Point(187, 56);
            this.txtB_CA__commercial.Name = "txtB_CA__commercial";
            this.txtB_CA__commercial.ReadOnly = true;
            this.txtB_CA__commercial.Size = new System.Drawing.Size(133, 20);
            this.txtB_CA__commercial.TabIndex = 15;
            this.txtB_CA__commercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_TxCommission
            // 
            this.lb_TxCommission.AutoSize = true;
            this.lb_TxCommission.Location = new System.Drawing.Point(12, 23);
            this.lb_TxCommission.Name = "lb_TxCommission";
            this.lb_TxCommission.Size = new System.Drawing.Size(110, 13);
            this.lb_TxCommission.TabIndex = 12;
            this.lb_TxCommission.Text = "Taux de Commission :";
            // 
            // lb_CA
            // 
            this.lb_CA.AutoSize = true;
            this.lb_CA.Location = new System.Drawing.Point(12, 56);
            this.lb_CA.Name = "lb_CA";
            this.lb_CA.Size = new System.Drawing.Size(89, 13);
            this.lb_CA.TabIndex = 13;
            this.lb_CA.Text = "Chiffre d\'Affaires :";
            // 
            // lb_choixsalarie
            // 
            this.lb_choixsalarie.AutoSize = true;
            this.lb_choixsalarie.Location = new System.Drawing.Point(22, 35);
            this.lb_choixsalarie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_choixsalarie.Name = "lb_choixsalarie";
            this.lb_choixsalarie.Size = new System.Drawing.Size(92, 13);
            this.lb_choixsalarie.TabIndex = 6;
            this.lb_choixsalarie.Text = "Choisir un salarié :";
            // 
            // cb_ChoixSalarie
            // 
            this.cb_ChoixSalarie.FormattingEnabled = true;
            this.cb_ChoixSalarie.Location = new System.Drawing.Point(133, 30);
            this.cb_ChoixSalarie.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ChoixSalarie.Name = "cb_ChoixSalarie";
            this.cb_ChoixSalarie.Size = new System.Drawing.Size(166, 21);
            this.cb_ChoixSalarie.TabIndex = 5;
            this.cb_ChoixSalarie.SelectedIndexChanged += new System.EventHandler(this.cb_ChoixSalarie_SelectedIndexChanged);
            // 
            // btn_NouveauSalarie
            // 
            this.btn_NouveauSalarie.Location = new System.Drawing.Point(309, 30);
            this.btn_NouveauSalarie.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NouveauSalarie.Name = "btn_NouveauSalarie";
            this.btn_NouveauSalarie.Size = new System.Drawing.Size(74, 20);
            this.btn_NouveauSalarie.TabIndex = 4;
            this.btn_NouveauSalarie.Text = "Nouveau";
            this.btn_NouveauSalarie.UseVisualStyleBackColor = true;
            this.btn_NouveauSalarie.Click += new System.EventHandler(this.btn_NouveauSalarie_Click);
            // 
            // ep_Salarie
            // 
            this.ep_Salarie.ContainerControl = this;
            // 
            // chb_IsACommercial
            // 
            this.chb_IsACommercial.AutoSize = true;
            this.chb_IsACommercial.Location = new System.Drawing.Point(19, 251);
            this.chb_IsACommercial.Name = "chb_IsACommercial";
            this.chb_IsACommercial.Size = new System.Drawing.Size(120, 17);
            this.chb_IsACommercial.TabIndex = 18;
            this.chb_IsACommercial.Text = "C\'est un commercial";
            this.chb_IsACommercial.UseVisualStyleBackColor = true;
            this.chb_IsACommercial.CheckedChanged += new System.EventHandler(this.chb_IsCommercial_CheckedChanged);
            // 
            // FrmSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 580);
            this.Controls.Add(this.gb_DetailSalarie);
            this.Controls.Add(this.lb_choixsalarie);
            this.Controls.Add(this.cb_ChoixSalarie);
            this.Controls.Add(this.btn_NouveauSalarie);
            this.Name = "FrmSalaries";
            this.Text = "FrmSalaries";
            this.Load += new System.EventHandler(this.FrmSalaries_Load);
            this.gb_DetailSalarie.ResumeLayout(false);
            this.gb_DetailSalarie.PerformLayout();
            this.pnl_Boutons.ResumeLayout(false);
            this.Pn_commercial.ResumeLayout(false);
            this.Pn_commercial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Salarie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_DetailSalarie;
        private System.Windows.Forms.Label lb_CA;
        private System.Windows.Forms.Label lb_TxCommission;
        private System.Windows.Forms.TextBox txtB_SalaireNet;
        private System.Windows.Forms.Label lb_salaireNet;
        private System.Windows.Forms.MaskedTextBox mTxtB_TauxCS;
        private System.Windows.Forms.Label lb_TxCS;
        private System.Windows.Forms.Label lb_DateNaissance;
        private System.Windows.Forms.MaskedTextBox mTxtB_DateDeNaissance;
        private System.Windows.Forms.Panel pnl_Boutons;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.TextBox txtB_Prenom;
        private System.Windows.Forms.Label lb_SalaireBrut;
        private System.Windows.Forms.Label lb_prenom;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.TextBox txtB_Matricule;
        private System.Windows.Forms.Label lb_matricule;
        private System.Windows.Forms.Label lb_choixsalarie;
        private System.Windows.Forms.ComboBox cb_ChoixSalarie;
        private System.Windows.Forms.Button btn_NouveauSalarie;
        private System.Windows.Forms.TextBox txtB_CA__commercial;
        private System.Windows.Forms.Panel Pn_commercial;
        private System.Windows.Forms.TextBox txtB_SalaireBrut;
        private System.Windows.Forms.MaskedTextBox txtB_TauxCom_Commercial;
        private System.Windows.Forms.ErrorProvider ep_Salarie;
        private System.Windows.Forms.CheckBox chb_IsACommercial;
        private System.Windows.Forms.TextBox txtB_Nom;
    }
}