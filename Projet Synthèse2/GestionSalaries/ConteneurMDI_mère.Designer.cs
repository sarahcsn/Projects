namespace GestionSalaraies
{
    partial class ConteneurMDI_mere
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.gestionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gestionDesSalariésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesUtilisateursToolStripMenuItem,
            this.gestionDesSalariésToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.MdiWindowListItem = this.gestionDesUtilisateursToolStripMenuItem;
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(441, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// gestionDesUtilisateursToolStripMenuItem
			// 
			this.gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
			this.gestionDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
			this.gestionDesUtilisateursToolStripMenuItem.Text = "Gestion des Utilisateurs";
			this.gestionDesUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.gestionDesUtilisateursToolStripMenuItem_Click);
			// 
			// gestionDesSalariésToolStripMenuItem
			// 
			this.gestionDesSalariésToolStripMenuItem.Name = "gestionDesSalariésToolStripMenuItem";
			this.gestionDesSalariésToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
			this.gestionDesSalariésToolStripMenuItem.Text = "Gestion des Salariés";
			this.gestionDesSalariésToolStripMenuItem.Click += new System.EventHandler(this.gestionDesSalariésToolStripMenuItem_Click);
			// 
			// ConteneurMDI_mere
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 261);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ConteneurMDI_mere";
			this.Text = "ConteneurMDI";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Modal_DialConnection);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesSalariésToolStripMenuItem;
    }
}