namespace DisquetuveuxApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxArticles = new System.Windows.Forms.ComboBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.lblEditeur = new System.Windows.Forms.Label();
            this.txtEditeur = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.fichierToolStripMenuItem
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            //
            // fichierToolStripMenuItem
            //
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.quitterToolStripMenuItem
            });
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Text = "Fichier";
            //
            // quitterToolStripMenuItem
            //
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            //
            // comboBoxArticles
            //
            this.comboBoxArticles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArticles.FormattingEnabled = true;
            this.comboBoxArticles.Location = new System.Drawing.Point(20, 40);
            this.comboBoxArticles.Name = "comboBoxArticles";
            this.comboBoxArticles.Size = new System.Drawing.Size(350, 21);
            this.comboBoxArticles.TabIndex = 1;
            this.comboBoxArticles.SelectedIndexChanged += new System.EventHandler(this.comboBoxArticles_SelectedIndexChanged);
            //
            // lblTitre
            //
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(20, 80);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Text = "Titre";
            //
            // txtTitre
            //
            this.txtTitre.Location = new System.Drawing.Point(100, 77);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(270, 20);
            //
            // lblAuteur
            //
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(20, 115);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Text = "Auteur";
            //
            // txtAuteur
            //
            this.txtAuteur.Location = new System.Drawing.Point(100, 112);
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.Size = new System.Drawing.Size(270, 20);
            //
            // lblPrix
            //
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(20, 150);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Text = "Prix";
            //
            // txtPrix
            //
            this.txtPrix.Location = new System.Drawing.Point(100, 147);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(270, 20);
            //
            // lblEditeur
            //
            this.lblEditeur.AutoSize = true;
            this.lblEditeur.Location = new System.Drawing.Point(20, 185);
            this.lblEditeur.Name = "lblEditeur";
            this.lblEditeur.Text = "Éditeur";
            //
            // txtEditeur
            //
            this.txtEditeur.Location = new System.Drawing.Point(100, 182);
            this.txtEditeur.Name = "txtEditeur";
            this.txtEditeur.Size = new System.Drawing.Size(270, 20);
            //
            // btnModifier
            //
            this.btnModifier.Location = new System.Drawing.Point(20, 220);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 30);
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            //
            // btnAjouter
            //
            this.btnAjouter.Location = new System.Drawing.Point(140, 220);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 30);
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            //
            // btnConfirmer
            //
            this.btnConfirmer.Location = new System.Drawing.Point(270, 220);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(100, 30);
            this.btnConfirmer.Text = "Confirmer Ajout";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            //
            // Form1
            //
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.comboBoxArticles);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.txtAuteur);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.lblEditeur);
            this.Controls.Add(this.txtEditeur);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Disquetuveux";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxArticles;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.TextBox txtAuteur;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label lblEditeur;
        private System.Windows.Forms.TextBox txtEditeur;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnConfirmer;
    }
}