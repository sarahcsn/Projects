namespace TestNatureDesCaracteres
{
    partial class TestCaracteres
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
            this.consignesSaisirchn = new System.Windows.Forms.Label();
            this.consignePosChn = new System.Windows.Forms.Label();
            this._saisieChn = new System.Windows.Forms.TextBox();
            this._positionCar = new System.Windows.Forms.NumericUpDown();
            this.consigneRes = new System.Windows.Forms.Label();
            this._btn_CategorieCar = new System.Windows.Forms.Button();
            this._resultat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._positionCar)).BeginInit();
            this.SuspendLayout();
            // 
            // consignesSaisirchn
            // 
            this.consignesSaisirchn.AutoSize = true;
            this.consignesSaisirchn.Location = new System.Drawing.Point(26, 50);
            this.consignesSaisirchn.Name = "consignesSaisirchn";
            this.consignesSaisirchn.Size = new System.Drawing.Size(106, 13);
            this.consignesSaisirchn.TabIndex = 0;
            this.consignesSaisirchn.Text = "Saisissez un chaine :";
            // 
            // consignePosChn
            // 
            this.consignePosChn.AutoSize = true;
            this.consignePosChn.Location = new System.Drawing.Point(26, 102);
            this.consignePosChn.Name = "consignePosChn";
            this.consignePosChn.Size = new System.Drawing.Size(107, 13);
            this.consignePosChn.TabIndex = 1;
            this.consignePosChn.Text = "Position du caractère";
            // 
            // _saisieChn
            // 
            this._saisieChn.Location = new System.Drawing.Point(182, 50);
            this._saisieChn.Name = "_saisieChn";
            this._saisieChn.Size = new System.Drawing.Size(375, 20);
            this._saisieChn.TabIndex = 2;
            // 
            // _positionCar
            // 
            this._positionCar.Location = new System.Drawing.Point(182, 95);
            this._positionCar.Name = "_positionCar";
            this._positionCar.Size = new System.Drawing.Size(77, 20);
            this._positionCar.TabIndex = 1;
            this._positionCar.ValueChanged += new System.EventHandler(this.MaxPositionCaractere);
            // 
            // consigneRes
            // 
            this.consigneRes.AutoSize = true;
            this.consigneRes.Location = new System.Drawing.Point(26, 149);
            this.consigneRes.Name = "consigneRes";
            this.consigneRes.Size = new System.Drawing.Size(46, 13);
            this.consigneRes.TabIndex = 4;
            this.consigneRes.Text = "Résultat";
            // 
            // _btn_CategorieCar
            // 
            this._btn_CategorieCar.Location = new System.Drawing.Point(29, 187);
            this._btn_CategorieCar.Name = "_btn_CategorieCar";
            this._btn_CategorieCar.Size = new System.Drawing.Size(138, 23);
            this._btn_CategorieCar.TabIndex = 5;
            this._btn_CategorieCar.Text = "Catégorie du caractère";
            this._btn_CategorieCar.UseVisualStyleBackColor = true;
            this._btn_CategorieCar.Click += new System.EventHandler(this._Categorie_click);
            // 
            // _resultat
            // 
            this._resultat.Location = new System.Drawing.Point(182, 142);
            this._resultat.Name = "_resultat";
            this._resultat.ReadOnly = true;
            this._resultat.Size = new System.Drawing.Size(375, 20);
            this._resultat.TabIndex = 6;
            // 
            // TestCaracteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 261);
            this.Controls.Add(this._resultat);
            this.Controls.Add(this._btn_CategorieCar);
            this.Controls.Add(this.consigneRes);
            this.Controls.Add(this._positionCar);
            this.Controls.Add(this._saisieChn);
            this.Controls.Add(this.consignePosChn);
            this.Controls.Add(this.consignesSaisirchn);
            this.Name = "TestCaracteres";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._positionCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label consignesSaisirchn;
        private System.Windows.Forms.Label consignePosChn;
        private System.Windows.Forms.TextBox _saisieChn;
        private System.Windows.Forms.NumericUpDown _positionCar;
        private System.Windows.Forms.Label consigneRes;
        private System.Windows.Forms.Button _btn_CategorieCar;
        private System.Windows.Forms.TextBox _resultat;
    }
}

