namespace DialogueModal
{
    partial class FenInvocation
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
            this.btn_appel = new System.Windows.Forms.Button();
            this.txtB_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_appel
            // 
            this.btn_appel.Location = new System.Drawing.Point(34, 35);
            this.btn_appel.Name = "btn_appel";
            this.btn_appel.Size = new System.Drawing.Size(164, 23);
            this.btn_appel.TabIndex = 0;
            this.btn_appel.Text = "Appel dialogue modal";
            this.btn_appel.UseVisualStyleBackColor = true;
            this.btn_appel.Click += new System.EventHandler(this.appeldialmod_click);
            // 
            // txtB_Result
            // 
            this.txtB_Result.Location = new System.Drawing.Point(230, 35);
            this.txtB_Result.Name = "txtB_Result";
            this.txtB_Result.ReadOnly = true;
            this.txtB_Result.Size = new System.Drawing.Size(153, 20);
            this.txtB_Result.TabIndex = 1;
            // 
            // FenInvocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 86);
            this.Controls.Add(this.txtB_Result);
            this.Controls.Add(this.btn_appel);
            this.Name = "FenInvocation";
            this.Text = "Fenêtre invocation du dialogue modal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_appel;
        private System.Windows.Forms.TextBox txtB_Result;
    }
}

