namespace JeuxCaracteres
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
            this._lb_saisiechn = new System.Windows.Forms.Label();
            this._lb_portChn1 = new System.Windows.Forms.Label();
            this._lb_portRemp2 = new System.Windows.Forms.Label();
            this._lb_result = new System.Windows.Forms.Label();
            this._txtB_saisieChn = new System.Windows.Forms.TextBox();
            this._txtB_portChn1 = new System.Windows.Forms.TextBox();
            this._txtB_portRemp2 = new System.Windows.Forms.TextBox();
            this._txtB_Result = new System.Windows.Forms.TextBox();
            this._grB_choix = new System.Windows.Forms.GroupBox();
            this._rbtn_rempDerniereOccurence = new System.Windows.Forms.RadioButton();
            this._rbtn_rempPremiereOccurence = new System.Windows.Forms.RadioButton();
            this._rbtn_rempTtesOccurences1 = new System.Windows.Forms.RadioButton();
            this._rbtn_nbOccurences = new System.Windows.Forms.RadioButton();
            this._btn_jouer = new System.Windows.Forms.Button();
            this._grB_choix.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lb_saisiechn
            // 
            this._lb_saisiechn.AutoSize = true;
            this._lb_saisiechn.CausesValidation = false;
            this._lb_saisiechn.Location = new System.Drawing.Point(29, 42);
            this._lb_saisiechn.Name = "_lb_saisiechn";
            this._lb_saisiechn.Size = new System.Drawing.Size(112, 13);
            this._lb_saisiechn.TabIndex = 0;
            this._lb_saisiechn.Text = "Saisissez une chaine :";
            // 
            // _lb_portChn1
            // 
            this._lb_portChn1.AutoSize = true;
            this._lb_portChn1.CausesValidation = false;
            this._lb_portChn1.Location = new System.Drawing.Point(29, 84);
            this._lb_portChn1.Name = "_lb_portChn1";
            this._lb_portChn1.Size = new System.Drawing.Size(105, 13);
            this._lb_portChn1.TabIndex = 1;
            this._lb_portChn1.Text = "Portion de chaine 1 :";
            // 
            // _lb_portRemp2
            // 
            this._lb_portRemp2.AutoSize = true;
            this._lb_portRemp2.CausesValidation = false;
            this._lb_portRemp2.Location = new System.Drawing.Point(29, 127);
            this._lb_portRemp2.Name = "_lb_portRemp2";
            this._lb_portRemp2.Size = new System.Drawing.Size(139, 13);
            this._lb_portRemp2.TabIndex = 2;
            this._lb_portRemp2.Text = "Portion de remplacement 2 :";
            // 
            // _lb_result
            // 
            this._lb_result.AutoSize = true;
            this._lb_result.CausesValidation = false;
            this._lb_result.Location = new System.Drawing.Point(29, 169);
            this._lb_result.Name = "_lb_result";
            this._lb_result.Size = new System.Drawing.Size(46, 13);
            this._lb_result.TabIndex = 3;
            this._lb_result.Text = "Résultat";
            // 
            // _txtB_saisieChn
            // 
            this._txtB_saisieChn.Location = new System.Drawing.Point(202, 35);
            this._txtB_saisieChn.Name = "_txtB_saisieChn";
            this._txtB_saisieChn.Size = new System.Drawing.Size(339, 20);
            this._txtB_saisieChn.TabIndex = 4;
            // 
            // _txtB_portChn1
            // 
            this._txtB_portChn1.CausesValidation = false;
            this._txtB_portChn1.Location = new System.Drawing.Point(202, 81);
            this._txtB_portChn1.Name = "_txtB_portChn1";
            this._txtB_portChn1.Size = new System.Drawing.Size(339, 20);
            this._txtB_portChn1.TabIndex = 5;
            // 
            // _txtB_portRemp2
            // 
            this._txtB_portRemp2.CausesValidation = false;
            this._txtB_portRemp2.Location = new System.Drawing.Point(202, 124);
            this._txtB_portRemp2.Name = "_txtB_portRemp2";
            this._txtB_portRemp2.Size = new System.Drawing.Size(339, 20);
            this._txtB_portRemp2.TabIndex = 6;
            // 
            // _txtB_Result
            // 
            this._txtB_Result.CausesValidation = false;
            this._txtB_Result.Location = new System.Drawing.Point(202, 166);
            this._txtB_Result.Name = "_txtB_Result";
            this._txtB_Result.ReadOnly = true;
            this._txtB_Result.Size = new System.Drawing.Size(339, 20);
            this._txtB_Result.TabIndex = 7;
            // 
            // _grB_choix
            // 
            this._grB_choix.Controls.Add(this._rbtn_rempDerniereOccurence);
            this._grB_choix.Controls.Add(this._rbtn_rempPremiereOccurence);
            this._grB_choix.Controls.Add(this._rbtn_rempTtesOccurences1);
            this._grB_choix.Controls.Add(this._rbtn_nbOccurences);
            this._grB_choix.Location = new System.Drawing.Point(32, 247);
            this._grB_choix.Name = "_grB_choix";
            this._grB_choix.Size = new System.Drawing.Size(405, 130);
            this._grB_choix.TabIndex = 8;
            this._grB_choix.TabStop = false;
            this._grB_choix.Text = "Faites votre choix";
            // 
            // _rbtn_rempDerniereOccurence
            // 
            this._rbtn_rempDerniereOccurence.AutoSize = true;
            this._rbtn_rempDerniereOccurence.Location = new System.Drawing.Point(17, 97);
            this._rbtn_rempDerniereOccurence.Name = "_rbtn_rempDerniereOccurence";
            this._rbtn_rempDerniereOccurence.Size = new System.Drawing.Size(222, 17);
            this._rbtn_rempDerniereOccurence.TabIndex = 9;
            this._rbtn_rempDerniereOccurence.TabStop = true;
            this._rbtn_rempDerniereOccurence.Text = "Remplacer dernière occurence de 1 par 2";
            this._rbtn_rempDerniereOccurence.UseVisualStyleBackColor = true;
            this._rbtn_rempDerniereOccurence.Click += new System.EventHandler(this.RemplacerDerOccurence);
            // 
            // _rbtn_rempPremiereOccurence
            // 
            this._rbtn_rempPremiereOccurence.AutoSize = true;
            this._rbtn_rempPremiereOccurence.Location = new System.Drawing.Point(17, 75);
            this._rbtn_rempPremiereOccurence.Name = "_rbtn_rempPremiereOccurence";
            this._rbtn_rempPremiereOccurence.Size = new System.Drawing.Size(190, 17);
            this._rbtn_rempPremiereOccurence.TabIndex = 9;
            this._rbtn_rempPremiereOccurence.TabStop = true;
            this._rbtn_rempPremiereOccurence.Text = "Remplacer 1ere occurence 1 par 2";
            this._rbtn_rempPremiereOccurence.UseVisualStyleBackColor = true;
            this._rbtn_rempPremiereOccurence.Click += new System.EventHandler(this.Remplacer1occurence);
            // 
            // _rbtn_rempTtesOccurences1
            // 
            this._rbtn_rempTtesOccurences1.AutoSize = true;
            this._rbtn_rempTtesOccurences1.Location = new System.Drawing.Point(17, 52);
            this._rbtn_rempTtesOccurences1.Name = "_rbtn_rempTtesOccurences1";
            this._rbtn_rempTtesOccurences1.Size = new System.Drawing.Size(234, 17);
            this._rbtn_rempTtesOccurences1.TabIndex = 9;
            this._rbtn_rempTtesOccurences1.TabStop = true;
            this._rbtn_rempTtesOccurences1.Text = "Remplacer toutes les occurences de 1 par 2";
            this._rbtn_rempTtesOccurences1.UseVisualStyleBackColor = true;
            this._rbtn_rempTtesOccurences1.Click += new System.EventHandler(this.RemplacerTtesOccurences);
            // 
            // _rbtn_nbOccurences
            // 
            this._rbtn_nbOccurences.AutoSize = true;
            this._rbtn_nbOccurences.Location = new System.Drawing.Point(17, 29);
            this._rbtn_nbOccurences.Name = "_rbtn_nbOccurences";
            this._rbtn_nbOccurences.Size = new System.Drawing.Size(133, 17);
            this._rbtn_nbOccurences.TabIndex = 0;
            this._rbtn_nbOccurences.TabStop = true;
            this._rbtn_nbOccurences.Text = "Nombre occurrences 1";
            this._rbtn_nbOccurences.UseVisualStyleBackColor = true;
            this._rbtn_nbOccurences.Click += new System.EventHandler(this._click_nboccurences);
            // 
            // _btn_jouer
            // 
            this._btn_jouer.Location = new System.Drawing.Point(32, 413);
            this._btn_jouer.Name = "_btn_jouer";
            this._btn_jouer.Size = new System.Drawing.Size(75, 23);
            this._btn_jouer.TabIndex = 9;
            this._btn_jouer.Text = "Jouer";
            this._btn_jouer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 480);
            this.Controls.Add(this._btn_jouer);
            this.Controls.Add(this._grB_choix);
            this.Controls.Add(this._txtB_Result);
            this.Controls.Add(this._txtB_portRemp2);
            this.Controls.Add(this._txtB_portChn1);
            this.Controls.Add(this._txtB_saisieChn);
            this.Controls.Add(this._lb_result);
            this.Controls.Add(this._lb_portRemp2);
            this.Controls.Add(this._lb_portChn1);
            this.Controls.Add(this._lb_saisiechn);
            this.Name = "Form1";
            this.Text = "Form1";
            this._grB_choix.ResumeLayout(false);
            this._grB_choix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lb_saisiechn;
        private System.Windows.Forms.Label _lb_portChn1;
        private System.Windows.Forms.Label _lb_portRemp2;
        private System.Windows.Forms.Label _lb_result;
        private System.Windows.Forms.TextBox _txtB_saisieChn;
        private System.Windows.Forms.TextBox _txtB_portChn1;
        private System.Windows.Forms.TextBox _txtB_portRemp2;
        private System.Windows.Forms.TextBox _txtB_Result;
        private System.Windows.Forms.GroupBox _grB_choix;
        private System.Windows.Forms.RadioButton _rbtn_rempDerniereOccurence;
        private System.Windows.Forms.RadioButton _rbtn_rempPremiereOccurence;
        private System.Windows.Forms.RadioButton _rbtn_rempTtesOccurences1;
        private System.Windows.Forms.RadioButton _rbtn_nbOccurences;
        private System.Windows.Forms.Button _btn_jouer;
    }
}

