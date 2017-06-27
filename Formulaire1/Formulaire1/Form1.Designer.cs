namespace Formulaire1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Original = new System.Windows.Forms.Label();
            this.Copie = new System.Windows.Forms.Label();
            this.quitter = new System.Windows.Forms.Button();
            this.effacer = new System.Windows.Forms.Button();
            this.recopier = new System.Windows.Forms.Button();
            this.reponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Original
            // 
            this.Original.AutoSize = true;
            this.Original.Location = new System.Drawing.Point(12, 36);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(48, 13);
            this.Original.TabIndex = 1;
            this.Original.Text = "Original :";
          
            // 
            // Copie
            // 
            this.Copie.AutoSize = true;
            this.Copie.Location = new System.Drawing.Point(12, 138);
            this.Copie.Name = "Copie";
            this.Copie.Size = new System.Drawing.Size(40, 13);
            this.Copie.TabIndex = 2;
            this.Copie.Text = "Copie :";
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(329, 100);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(88, 25);
            this.quitter.TabIndex = 5;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // effacer
            // 
            this.effacer.Location = new System.Drawing.Point(329, 69);
            this.effacer.Name = "effacer";
            this.effacer.Size = new System.Drawing.Size(88, 25);
            this.effacer.TabIndex = 6;
            this.effacer.Text = "Effacer";
            this.effacer.UseVisualStyleBackColor = true;
            this.effacer.Click += new System.EventHandler(this.effacer_Click);
            // 
            // recopier
            // 
            this.recopier.Location = new System.Drawing.Point(329, 38);
            this.recopier.Name = "recopier";
            this.recopier.Size = new System.Drawing.Size(88, 25);
            this.recopier.TabIndex = 7;
            this.recopier.Text = "Recopier";
            this.recopier.UseVisualStyleBackColor = true;
            this.recopier.Click += new System.EventHandler(this.recopier_Click);
            // 
            // reponse
            // 
            this.reponse.AutoSize = true;
            this.reponse.Location = new System.Drawing.Point(87, 138);
            this.reponse.Name = "reponse";
            this.reponse.Size = new System.Drawing.Size(0, 13);
            this.reponse.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 261);
            this.Controls.Add(this.reponse);
            this.Controls.Add(this.recopier);
            this.Controls.Add(this.effacer);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.Copie);
            this.Controls.Add(this.Original);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Original;
        private System.Windows.Forms.Label Copie;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Button effacer;
        private System.Windows.Forms.Button recopier;
        private System.Windows.Forms.Label reponse;
    }
}

