namespace DialConnexion
{
    partial class IdentifiezVous
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grB_ParamID = new System.Windows.Forms.GroupBox();
            this.txB_mdp = new System.Windows.Forms.TextBox();
            this.txtB_ID = new System.Windows.Forms.TextBox();
            this.lb_mdp = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.btn_connection = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grB_ParamID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grB_ParamID
            // 
            this.grB_ParamID.Controls.Add(this.txB_mdp);
            this.grB_ParamID.Controls.Add(this.txtB_ID);
            this.grB_ParamID.Controls.Add(this.lb_mdp);
            this.grB_ParamID.Controls.Add(this.lb_ID);
            this.grB_ParamID.Location = new System.Drawing.Point(12, 23);
            this.grB_ParamID.Name = "grB_ParamID";
            this.grB_ParamID.Size = new System.Drawing.Size(390, 151);
            this.grB_ParamID.TabIndex = 0;
            this.grB_ParamID.TabStop = false;
            this.grB_ParamID.Text = "Paramètres d\'authentification";
            // 
            // txB_mdp
            // 
            this.txB_mdp.Location = new System.Drawing.Point(82, 80);
            this.txB_mdp.Name = "txB_mdp";
            this.txB_mdp.PasswordChar = '*';
            this.txB_mdp.Size = new System.Drawing.Size(289, 20);
            this.txB_mdp.TabIndex = 3;
            this.txB_mdp.Validating += new System.ComponentModel.CancelEventHandler(this.txB_mdp_Validating);
            // 
            // txtB_ID
            // 
            this.txtB_ID.Location = new System.Drawing.Point(82, 40);
            this.txtB_ID.Name = "txtB_ID";
            this.txtB_ID.Size = new System.Drawing.Size(289, 20);
            this.txtB_ID.TabIndex = 2;
            this.txtB_ID.Validating += new System.ComponentModel.CancelEventHandler(this.txtB_ID_Validating);
            // 
            // lb_mdp
            // 
            this.lb_mdp.AutoSize = true;
            this.lb_mdp.Location = new System.Drawing.Point(10, 83);
            this.lb_mdp.Name = "lb_mdp";
            this.lb_mdp.Size = new System.Drawing.Size(65, 13);
            this.lb_mdp.TabIndex = 1;
            this.lb_mdp.Text = "Motdepasse";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(10, 43);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(65, 13);
            this.lb_ID.TabIndex = 0;
            this.lb_ID.Text = "ID utilisateur";
            // 
            // btn_connection
            // 
            this.btn_connection.Location = new System.Drawing.Point(70, 194);
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Size = new System.Drawing.Size(124, 23);
            this.btn_connection.TabIndex = 1;
            this.btn_connection.Text = "Se connecter";
            this.btn_connection.UseVisualStyleBackColor = true;
            this.btn_connection.Click += new System.EventHandler(this.btn_connection_Click);
            
            // 
            // btn_quitter
            // 
            this.btn_quitter.CausesValidation = false;
            this.btn_quitter.Location = new System.Drawing.Point(219, 194);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(124, 23);
            this.btn_quitter.TabIndex = 2;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // IdentifiezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 261);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_connection);
            this.Controls.Add(this.grB_ParamID);
            this.Name = "IdentifiezVous";
            this.Text = "Identifiez-vous";
            this.grB_ParamID.ResumeLayout(false);
            this.grB_ParamID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grB_ParamID;
        private System.Windows.Forms.Button btn_connection;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.TextBox txB_mdp;
        private System.Windows.Forms.TextBox txtB_ID;
        private System.Windows.Forms.Label lb_mdp;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

