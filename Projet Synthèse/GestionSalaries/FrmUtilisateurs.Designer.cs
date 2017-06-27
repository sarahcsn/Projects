namespace GestionSalaraies
{
    partial class FrmUtilisateurs
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
            this.btn_Nouveau = new System.Windows.Forms.Button();
            this.cb_Utilisateurs = new System.Windows.Forms.ComboBox();
            this.lb_choixuser = new System.Windows.Forms.Label();
            this.gbDetailUtilisateur = new System.Windows.Forms.GroupBox();
            this.chkCompteBloque = new System.Windows.Forms.CheckBox();
            this.pnl_Boutons = new System.Windows.Forms.Panel();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.cb_Roles = new System.Windows.Forms.ComboBox();
            this.txtB_Nom = new System.Windows.Forms.TextBox();
            this.txtB_mdp = new System.Windows.Forms.TextBox();
            this.lb_role = new System.Windows.Forms.Label();
            this.lb_Nom = new System.Windows.Forms.Label();
            this.lb_mdp = new System.Windows.Forms.Label();
            this.txtB_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.epUtilisateur = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gbDetailUtilisateur.SuspendLayout();
            this.pnl_Boutons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUtilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.Location = new System.Drawing.Point(317, 49);
            this.btn_Nouveau.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Size = new System.Drawing.Size(74, 20);
            this.btn_Nouveau.TabIndex = 0;
            this.btn_Nouveau.Text = "Nouveau";
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            // 
            // cb_Utilisateurs
            // 
            this.cb_Utilisateurs.FormattingEnabled = true;
            this.cb_Utilisateurs.Location = new System.Drawing.Point(141, 49);
            this.cb_Utilisateurs.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Utilisateurs.Name = "cb_Utilisateurs";
            this.cb_Utilisateurs.Size = new System.Drawing.Size(166, 21);
            this.cb_Utilisateurs.TabIndex = 1;
            this.cb_Utilisateurs.SelectedIndexChanged += new System.EventHandler(this.cbUtilisateurs_SelectedIndexChanged);
            // 
            // lb_choixuser
            // 
            this.lb_choixuser.AutoSize = true;
            this.lb_choixuser.Location = new System.Drawing.Point(30, 54);
            this.lb_choixuser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_choixuser.Name = "lb_choixuser";
            this.lb_choixuser.Size = new System.Drawing.Size(106, 13);
            this.lb_choixuser.TabIndex = 2;
            this.lb_choixuser.Text = "Choisir un utilisateur :";
            // 
            // gbDetailUtilisateur
            // 
            this.gbDetailUtilisateur.Controls.Add(this.chkCompteBloque);
            this.gbDetailUtilisateur.Controls.Add(this.pnl_Boutons);
            this.gbDetailUtilisateur.Controls.Add(this.cb_Roles);
            this.gbDetailUtilisateur.Controls.Add(this.txtB_Nom);
            this.gbDetailUtilisateur.Controls.Add(this.txtB_mdp);
            this.gbDetailUtilisateur.Controls.Add(this.lb_role);
            this.gbDetailUtilisateur.Controls.Add(this.lb_Nom);
            this.gbDetailUtilisateur.Controls.Add(this.lb_mdp);
            this.gbDetailUtilisateur.Controls.Add(this.txtB_id);
            this.gbDetailUtilisateur.Controls.Add(this.lb_id);
            this.gbDetailUtilisateur.Location = new System.Drawing.Point(32, 119);
            this.gbDetailUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.gbDetailUtilisateur.Name = "gbDetailUtilisateur";
            this.gbDetailUtilisateur.Padding = new System.Windows.Forms.Padding(2);
            this.gbDetailUtilisateur.Size = new System.Drawing.Size(359, 312);
            this.gbDetailUtilisateur.TabIndex = 3;
            this.gbDetailUtilisateur.TabStop = false;
            this.gbDetailUtilisateur.Text = "Détails Utilisateur";
            // 
            // chkCompteBloque
            // 
            this.chkCompteBloque.AutoSize = true;
            this.chkCompteBloque.Location = new System.Drawing.Point(89, 132);
            this.chkCompteBloque.Margin = new System.Windows.Forms.Padding(2);
            this.chkCompteBloque.Name = "chkCompteBloque";
            this.chkCompteBloque.Size = new System.Drawing.Size(97, 17);
            this.chkCompteBloque.TabIndex = 4;
            this.chkCompteBloque.Text = "Compte bloqué";
            this.chkCompteBloque.UseVisualStyleBackColor = true;
            // 
            // pnl_Boutons
            // 
            this.pnl_Boutons.Controls.Add(this.btn_Valider);
            this.pnl_Boutons.Controls.Add(this.btn_Annuler);
            this.pnl_Boutons.Controls.Add(this.btn_Modifier);
            this.pnl_Boutons.Location = new System.Drawing.Point(16, 232);
            this.pnl_Boutons.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Boutons.Name = "pnl_Boutons";
            this.pnl_Boutons.Size = new System.Drawing.Size(325, 60);
            this.pnl_Boutons.TabIndex = 3;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(203, 18);
            this.btn_Valider.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(56, 23);
            this.btn_Valider.TabIndex = 0;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(132, 18);
            this.btn_Annuler.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(56, 23);
            this.btn_Annuler.TabIndex = 0;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(57, 18);
            this.btn_Modifier.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(56, 23);
            this.btn_Modifier.TabIndex = 0;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // cb_Roles
            // 
            this.cb_Roles.FormattingEnabled = true;
            this.cb_Roles.Location = new System.Drawing.Point(91, 179);
            this.cb_Roles.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Roles.Name = "cb_Roles";
            this.cb_Roles.Size = new System.Drawing.Size(130, 21);
            this.cb_Roles.TabIndex = 2;
            // 
            // txtB_Nom
            // 
            this.txtB_Nom.Location = new System.Drawing.Point(88, 98);
            this.txtB_Nom.Margin = new System.Windows.Forms.Padding(2);
            this.txtB_Nom.Name = "txtB_Nom";
            this.txtB_Nom.Size = new System.Drawing.Size(132, 20);
            this.txtB_Nom.TabIndex = 1;
            // 
            // txtB_mdp
            // 
            this.txtB_mdp.Location = new System.Drawing.Point(88, 57);
            this.txtB_mdp.Margin = new System.Windows.Forms.Padding(2);
            this.txtB_mdp.Name = "txtB_mdp";
            this.txtB_mdp.PasswordChar = '*';
            this.txtB_mdp.Size = new System.Drawing.Size(132, 20);
            this.txtB_mdp.TabIndex = 1;
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Location = new System.Drawing.Point(16, 184);
            this.lb_role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(35, 13);
            this.lb_role.TabIndex = 0;
            this.lb_role.Text = "Role :";
            // 
            // lb_Nom
            // 
            this.lb_Nom.AutoSize = true;
            this.lb_Nom.Location = new System.Drawing.Point(14, 102);
            this.lb_Nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Nom.Name = "lb_Nom";
            this.lb_Nom.Size = new System.Drawing.Size(35, 13);
            this.lb_Nom.TabIndex = 0;
            this.lb_Nom.Text = "Nom :";
            // 
            // lb_mdp
            // 
            this.lb_mdp.AutoSize = true;
            this.lb_mdp.Location = new System.Drawing.Point(14, 59);
            this.lb_mdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mdp.Name = "lb_mdp";
            this.lb_mdp.Size = new System.Drawing.Size(77, 13);
            this.lb_mdp.TabIndex = 0;
            this.lb_mdp.Text = "Mot de passe :";
            // 
            // txtB_id
            // 
            this.txtB_id.Location = new System.Drawing.Point(89, 20);
            this.txtB_id.Margin = new System.Windows.Forms.Padding(2);
            this.txtB_id.Name = "txtB_id";
            this.txtB_id.Size = new System.Drawing.Size(132, 20);
            this.txtB_id.TabIndex = 1;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(14, 24);
            this.lb_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(59, 13);
            this.lb_id.TabIndex = 0;
            this.lb_id.Text = "Identifiant :";
            // 
            // epUtilisateur
            // 
            this.epUtilisateur.ContainerControl = this;
            // 
            // FrmUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 457);
            this.Controls.Add(this.gbDetailUtilisateur);
            this.Controls.Add(this.lb_choixuser);
            this.Controls.Add(this.cb_Utilisateurs);
            this.Controls.Add(this.btn_Nouveau);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUtilisateurs";
            this.Text = "Gestion des utilisateurs";
            this.Load += new System.EventHandler(this.FrmUtilisateurs_Load);
            this.gbDetailUtilisateur.ResumeLayout(false);
            this.gbDetailUtilisateur.PerformLayout();
            this.pnl_Boutons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epUtilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nouveau;
        private System.Windows.Forms.ComboBox cb_Utilisateurs;
        private System.Windows.Forms.Label lb_choixuser;
        private System.Windows.Forms.GroupBox gbDetailUtilisateur;
        private System.Windows.Forms.Panel pnl_Boutons;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.ComboBox cb_Roles;
        private System.Windows.Forms.TextBox txtB_Nom;
        private System.Windows.Forms.TextBox txtB_mdp;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.Label lb_Nom;
        private System.Windows.Forms.Label lb_mdp;
        private System.Windows.Forms.TextBox txtB_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.CheckBox chkCompteBloque;
        private System.Windows.Forms.ErrorProvider epUtilisateur;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}