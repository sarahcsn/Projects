namespace CheckBox_et_RadioButton
{
    partial class Policetext
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
            this.taper_txt = new System.Windows.Forms.TextBox();
            this.tapezTxt = new System.Windows.Forms.Label();
            this._choix = new System.Windows.Forms.GroupBox();
            this.choix_casse = new System.Windows.Forms.CheckBox();
            this.choix_caracteres_color = new System.Windows.Forms.CheckBox();
            this.choix_fond = new System.Windows.Forms.CheckBox();
            this._choixfond = new System.Windows.Forms.GroupBox();
            this._bleufd = new System.Windows.Forms.RadioButton();
            this._vertfd = new System.Windows.Forms.RadioButton();
            this._rougefd = new System.Windows.Forms.RadioButton();
            this._choixcaracteres = new System.Windows.Forms.GroupBox();
            this._noirCar = new System.Windows.Forms.RadioButton();
            this._blancCar = new System.Windows.Forms.RadioButton();
            this._rougeCar = new System.Windows.Forms.RadioButton();
            this._choixcasse = new System.Windows.Forms.GroupBox();
            this._majusCasse = new System.Windows.Forms.RadioButton();
            this._minusCasse = new System.Windows.Forms.RadioButton();
            this._message = new System.Windows.Forms.Label();
            this._choix.SuspendLayout();
            this._choixfond.SuspendLayout();
            this._choixcaracteres.SuspendLayout();
            this._choixcasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // taper_txt
            // 
            this.taper_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.taper_txt.Location = new System.Drawing.Point(43, 38);
            this.taper_txt.Name = "taper_txt";
            this.taper_txt.Size = new System.Drawing.Size(307, 20);
            this.taper_txt.TabIndex = 0;
            this.taper_txt.TextChanged += new System.EventHandler(this.taper_txt_TextChanged);
            // 
            // tapezTxt
            // 
            this.tapezTxt.AutoSize = true;
            this.tapezTxt.Location = new System.Drawing.Point(43, 13);
            this.tapezTxt.Name = "tapezTxt";
            this.tapezTxt.Size = new System.Drawing.Size(90, 13);
            this.tapezTxt.TabIndex = 1;
            this.tapezTxt.Text = "Tapez votre texte";
            // 
            // _choix
            // 
            this._choix.Controls.Add(this.choix_casse);
            this._choix.Controls.Add(this.choix_caracteres_color);
            this._choix.Controls.Add(this.choix_fond);
            this._choix.Location = new System.Drawing.Point(369, 30);
            this._choix.Name = "_choix";
            this._choix.Size = new System.Drawing.Size(162, 100);
            this._choix.TabIndex = 6;
            this._choix.TabStop = false;
            this._choix.Text = "Choix";
            // 
            // choix_casse
            // 
            this.choix_casse.AutoSize = true;
            this.choix_casse.Location = new System.Drawing.Point(17, 72);
            this.choix_casse.Name = "choix_casse";
            this.choix_casse.Size = new System.Drawing.Size(55, 17);
            this.choix_casse.TabIndex = 2;
            this.choix_casse.Text = "Casse";
            this.choix_casse.UseVisualStyleBackColor = true;
            this.choix_casse.CheckStateChanged += new System.EventHandler(this.choix_casse_CheckStateChanged);
            // 
            // choix_caracteres_color
            // 
            this.choix_caracteres_color.AutoSize = true;
            this.choix_caracteres_color.Location = new System.Drawing.Point(17, 49);
            this.choix_caracteres_color.Name = "choix_caracteres_color";
            this.choix_caracteres_color.Size = new System.Drawing.Size(135, 17);
            this.choix_caracteres_color.TabIndex = 1;
            this.choix_caracteres_color.Text = "Couleur des caractères";
            this.choix_caracteres_color.UseVisualStyleBackColor = true;
            this.choix_caracteres_color.CheckStateChanged += new System.EventHandler(this.choix_caracteres_color_CheckStateChanged);
            // 
            // choix_fond
            // 
            this.choix_fond.AutoSize = true;
            this.choix_fond.Location = new System.Drawing.Point(17, 23);
            this.choix_fond.Name = "choix_fond";
            this.choix_fond.Size = new System.Drawing.Size(104, 17);
            this.choix_fond.TabIndex = 0;
            this.choix_fond.Text = "Couleur du Fond";
            this.choix_fond.UseVisualStyleBackColor = true;
            this.choix_fond.CheckStateChanged += new System.EventHandler(this.choix_fond_CheckStateChanged);
            // 
            // _choixfond
            // 
            this._choixfond.Controls.Add(this._bleufd);
            this._choixfond.Controls.Add(this._vertfd);
            this._choixfond.Controls.Add(this._rougefd);
            this._choixfond.Location = new System.Drawing.Point(43, 140);
            this._choixfond.Name = "_choixfond";
            this._choixfond.Size = new System.Drawing.Size(105, 94);
            this._choixfond.TabIndex = 7;
            this._choixfond.TabStop = false;
            this._choixfond.Text = "Fond";
            // 
            // _bleufd
            // 
            this._bleufd.AutoSize = true;
            this._bleufd.BackColor = System.Drawing.Color.Transparent;
            this._bleufd.Location = new System.Drawing.Point(6, 65);
            this._bleufd.Name = "_bleufd";
            this._bleufd.Size = new System.Drawing.Size(46, 17);
            this._bleufd.TabIndex = 9;
            this._bleufd.TabStop = true;
            this._bleufd.Text = "Bleu";
            this._bleufd.UseVisualStyleBackColor = false;
            this._bleufd.CheckedChanged += new System.EventHandler(this._rougefd_CheckedChanged);
            // 
            // _vertfd
            // 
            this._vertfd.AutoSize = true;
            this._vertfd.BackColor = System.Drawing.Color.Transparent;
            this._vertfd.Location = new System.Drawing.Point(6, 42);
            this._vertfd.Name = "_vertfd";
            this._vertfd.Size = new System.Drawing.Size(44, 17);
            this._vertfd.TabIndex = 9;
            this._vertfd.TabStop = true;
            this._vertfd.Text = "Vert";
            this._vertfd.UseVisualStyleBackColor = false;
            this._vertfd.CheckedChanged += new System.EventHandler(this._rougefd_CheckedChanged);
            // 
            // _rougefd
            // 
            this._rougefd.AutoSize = true;
            this._rougefd.BackColor = System.Drawing.Color.Transparent;
            this._rougefd.Location = new System.Drawing.Point(6, 19);
            this._rougefd.Name = "_rougefd";
            this._rougefd.Size = new System.Drawing.Size(57, 17);
            this._rougefd.TabIndex = 8;
            this._rougefd.TabStop = true;
            this._rougefd.Text = "Rouge";
            this._rougefd.UseVisualStyleBackColor = false;
            this._rougefd.CheckedChanged += new System.EventHandler(this._rougefd_CheckedChanged);
            // 
            // _choixcaracteres
            // 
            this._choixcaracteres.Controls.Add(this._noirCar);
            this._choixcaracteres.Controls.Add(this._blancCar);
            this._choixcaracteres.Controls.Add(this._rougeCar);
            this._choixcaracteres.Location = new System.Drawing.Point(154, 140);
            this._choixcaracteres.Name = "_choixcaracteres";
            this._choixcaracteres.Size = new System.Drawing.Size(105, 94);
            this._choixcaracteres.TabIndex = 8;
            this._choixcaracteres.TabStop = false;
            this._choixcaracteres.Text = "Caractères";
            // 
            // _noirCar
            // 
            this._noirCar.AutoSize = true;
            this._noirCar.Location = new System.Drawing.Point(6, 65);
            this._noirCar.Name = "_noirCar";
            this._noirCar.Size = new System.Drawing.Size(44, 17);
            this._noirCar.TabIndex = 9;
            this._noirCar.TabStop = true;
            this._noirCar.Text = "Noir";
            this._noirCar.UseVisualStyleBackColor = true;
            this._noirCar.CheckedChanged += new System.EventHandler(this._rougeCar_CheckedChanged);
            // 
            // _blancCar
            // 
            this._blancCar.AutoSize = true;
            this._blancCar.Location = new System.Drawing.Point(6, 42);
            this._blancCar.Name = "_blancCar";
            this._blancCar.Size = new System.Drawing.Size(52, 17);
            this._blancCar.TabIndex = 9;
            this._blancCar.TabStop = true;
            this._blancCar.Text = "Blanc";
            this._blancCar.UseVisualStyleBackColor = true;
            this._blancCar.CheckedChanged += new System.EventHandler(this._rougeCar_CheckedChanged);
            // 
            // _rougeCar
            // 
            this._rougeCar.AutoSize = true;
            this._rougeCar.Location = new System.Drawing.Point(6, 19);
            this._rougeCar.Name = "_rougeCar";
            this._rougeCar.Size = new System.Drawing.Size(57, 17);
            this._rougeCar.TabIndex = 8;
            this._rougeCar.TabStop = true;
            this._rougeCar.Text = "Rouge";
            this._rougeCar.UseVisualStyleBackColor = true;
            this._rougeCar.CheckedChanged += new System.EventHandler(this._rougeCar_CheckedChanged);
            // 
            // _choixcasse
            // 
            this._choixcasse.Controls.Add(this._majusCasse);
            this._choixcasse.Controls.Add(this._minusCasse);
            this._choixcasse.Location = new System.Drawing.Point(266, 172);
            this._choixcasse.Name = "_choixcasse";
            this._choixcasse.Size = new System.Drawing.Size(135, 62);
            this._choixcasse.TabIndex = 9;
            this._choixcasse.TabStop = false;
            this._choixcasse.Text = "Casse";
            // 
            // _majusCasse
            // 
            this._majusCasse.AutoSize = true;
            this._majusCasse.Location = new System.Drawing.Point(7, 39);
            this._majusCasse.Name = "_majusCasse";
            this._majusCasse.Size = new System.Drawing.Size(78, 17);
            this._majusCasse.TabIndex = 10;
            this._majusCasse.TabStop = true;
            this._majusCasse.Text = "Majuscules";
            this._majusCasse.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this._majusCasse.UseVisualStyleBackColor = true;
            this._majusCasse.CheckedChanged += new System.EventHandler(this._minusCasse_CheckedChanged);
            // 
            // _minusCasse
            // 
            this._minusCasse.AutoSize = true;
            this._minusCasse.Location = new System.Drawing.Point(7, 20);
            this._minusCasse.Name = "_minusCasse";
            this._minusCasse.Size = new System.Drawing.Size(78, 17);
            this._minusCasse.TabIndex = 0;
            this._minusCasse.TabStop = true;
            this._minusCasse.Text = "Minuscules";
            this._minusCasse.UseVisualStyleBackColor = true;
            this._minusCasse.CheckedChanged += new System.EventHandler(this._minusCasse_CheckedChanged);
            // 
            // _message
            // 
            this._message.AutoSize = true;
            this._message.Location = new System.Drawing.Point(45, 82);
            this._message.Name = "_message";
            this._message.Size = new System.Drawing.Size(0, 13);
            this._message.TabIndex = 10;
            // 
            // Policetext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 261);
            this.Controls.Add(this._message);
            this.Controls.Add(this._choixcasse);
            this.Controls.Add(this._choixcaracteres);
            this.Controls.Add(this._choixfond);
            this.Controls.Add(this._choix);
            this.Controls.Add(this.tapezTxt);
            this.Controls.Add(this.taper_txt);
            this.Name = "Policetext";
            this.Text = "Form1";
            this._choix.ResumeLayout(false);
            this._choix.PerformLayout();
            this._choixfond.ResumeLayout(false);
            this._choixfond.PerformLayout();
            this._choixcaracteres.ResumeLayout(false);
            this._choixcaracteres.PerformLayout();
            this._choixcasse.ResumeLayout(false);
            this._choixcasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox taper_txt;
        private System.Windows.Forms.Label tapezTxt;
        private System.Windows.Forms.GroupBox _choix;
        private System.Windows.Forms.CheckBox choix_casse;
        private System.Windows.Forms.CheckBox choix_caracteres_color;
        private System.Windows.Forms.CheckBox choix_fond;
        private System.Windows.Forms.GroupBox _choixfond;
        private System.Windows.Forms.RadioButton _bleufd;
        private System.Windows.Forms.RadioButton _vertfd;
        private System.Windows.Forms.RadioButton _rougefd;
        private System.Windows.Forms.GroupBox _choixcaracteres;
        private System.Windows.Forms.RadioButton _noirCar;
        private System.Windows.Forms.RadioButton _blancCar;
        private System.Windows.Forms.RadioButton _rougeCar;
        private System.Windows.Forms.GroupBox _choixcasse;
        private System.Windows.Forms.RadioButton _majusCasse;
        private System.Windows.Forms.RadioButton _minusCasse;
        private System.Windows.Forms.Label _message;
    }
}

