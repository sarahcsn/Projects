namespace Formulaire1
{
    partial class additionneur
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
            this.zero = new System.Windows.Forms.Button();
            this.un = new System.Windows.Forms.Button();
            this.deux = new System.Windows.Forms.Button();
            this.trois = new System.Windows.Forms.Button();
            this.quatre = new System.Windows.Forms.Button();
            this.neuf = new System.Windows.Forms.Button();
            this.huit = new System.Windows.Forms.Button();
            this.sept = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.cinq = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.affichage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(27, 132);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(41, 32);
            this.zero.TabIndex = 0;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_click);
            // 
            // un
            // 
            this.un.Location = new System.Drawing.Point(74, 132);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(41, 32);
            this.un.TabIndex = 1;
            this.un.Text = "1";
            this.un.UseVisualStyleBackColor = true;
            this.un.Click += new System.EventHandler(this.button1_Click);
            // 
            // deux
            // 
            this.deux.Location = new System.Drawing.Point(121, 132);
            this.deux.Name = "deux";
            this.deux.Size = new System.Drawing.Size(41, 32);
            this.deux.TabIndex = 2;
            this.deux.Text = "2";
            this.deux.UseVisualStyleBackColor = true;
            // 
            // trois
            // 
            this.trois.Location = new System.Drawing.Point(168, 132);
            this.trois.Name = "trois";
            this.trois.Size = new System.Drawing.Size(41, 32);
            this.trois.TabIndex = 3;
            this.trois.Text = "3";
            this.trois.UseVisualStyleBackColor = true;
            // 
            // quatre
            // 
            this.quatre.Location = new System.Drawing.Point(215, 132);
            this.quatre.Name = "quatre";
            this.quatre.Size = new System.Drawing.Size(41, 32);
            this.quatre.TabIndex = 4;
            this.quatre.Text = "4";
            this.quatre.UseVisualStyleBackColor = true;
            this.quatre.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // neuf
            // 
            this.neuf.Location = new System.Drawing.Point(215, 170);
            this.neuf.Name = "neuf";
            this.neuf.Size = new System.Drawing.Size(41, 32);
            this.neuf.TabIndex = 9;
            this.neuf.Text = "9";
            this.neuf.UseVisualStyleBackColor = true;
            // 
            // huit
            // 
            this.huit.Location = new System.Drawing.Point(168, 170);
            this.huit.Name = "huit";
            this.huit.Size = new System.Drawing.Size(41, 32);
            this.huit.TabIndex = 8;
            this.huit.Text = "8";
            this.huit.UseVisualStyleBackColor = true;
            // 
            // sept
            // 
            this.sept.Location = new System.Drawing.Point(121, 170);
            this.sept.Name = "sept";
            this.sept.Size = new System.Drawing.Size(41, 32);
            this.sept.TabIndex = 7;
            this.sept.Text = "7";
            this.sept.UseVisualStyleBackColor = true;
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(74, 170);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(41, 32);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            // 
            // cinq
            // 
            this.cinq.Location = new System.Drawing.Point(27, 170);
            this.cinq.Name = "cinq";
            this.cinq.Size = new System.Drawing.Size(41, 32);
            this.cinq.TabIndex = 5;
            this.cinq.Text = "5";
            this.cinq.UseVisualStyleBackColor = true;
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(27, 220);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(101, 23);
            this.btnVider.TabIndex = 10;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(155, 220);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(101, 23);
            this.btnCalculer.TabIndex = 11;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            // 
            // affichage
            // 
            this.affichage.Location = new System.Drawing.Point(27, 24);
            this.affichage.Multiline = true;
            this.affichage.Name = "affichage";
            this.affichage.ReadOnly = true;
            this.affichage.Size = new System.Drawing.Size(229, 102);
            this.affichage.TabIndex = 12;
            this.affichage.TextChanged += new System.EventHandler(this.affichage_TextChanged);
            // 
            // additionneur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.affichage);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.neuf);
            this.Controls.Add(this.huit);
            this.Controls.Add(this.sept);
            this.Controls.Add(this.six);
            this.Controls.Add(this.cinq);
            this.Controls.Add(this.quatre);
            this.Controls.Add(this.trois);
            this.Controls.Add(this.deux);
            this.Controls.Add(this.un);
            this.Controls.Add(this.zero);
            this.Name = "additionneur";
            this.Text = "additionneur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button un;
        private System.Windows.Forms.Button deux;
        private System.Windows.Forms.Button trois;
        private System.Windows.Forms.Button quatre;
        private System.Windows.Forms.Button neuf;
        private System.Windows.Forms.Button huit;
        private System.Windows.Forms.Button sept;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button cinq;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.TextBox affichage;
    }
}