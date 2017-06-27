namespace ModificationSalaire
{
    partial class Form1
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
            this._lb_oldsalary = new System.Windows.Forms.Label();
            this._txtB_oldSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _lb_oldsalary
            // 
            this._lb_oldsalary.AutoSize = true;
            this._lb_oldsalary.Location = new System.Drawing.Point(36, 54);
            this._lb_oldsalary.Name = "_lb_oldsalary";
            this._lb_oldsalary.Size = new System.Drawing.Size(103, 13);
            this._lb_oldsalary.TabIndex = 0;
            this._lb_oldsalary.Text = "Ancien Salaire Brut :";
            // 
            // _txtB_oldSalary
            // 
            this._txtB_oldSalary.Location = new System.Drawing.Point(158, 47);
            this._txtB_oldSalary.Name = "_txtB_oldSalary";
            this._txtB_oldSalary.ReadOnly = true;
            this._txtB_oldSalary.Size = new System.Drawing.Size(100, 20);
            this._txtB_oldSalary.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 382);
            this.Controls.Add(this._txtB_oldSalary);
            this.Controls.Add(this._lb_oldsalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lb_oldsalary;
        private System.Windows.Forms.TextBox _txtB_oldSalary;
    }
}

