namespace WFControlDisBonjour
{
    partial class UC_DisBonjour
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxRepNom = new TextBox();
            label_Nom = new Label();
            SuspendLayout();
            // 
            // textBoxRepNom
            // 
            textBoxRepNom.Location = new Point(118, 26);
            textBoxRepNom.Name = "textBoxRepNom";
            textBoxRepNom.Size = new Size(100, 23);
            textBoxRepNom.TabIndex = 0;
            textBoxRepNom.TextChanged += textBoxRepNom_TextChanged;
            // 
            // label_Nom
            // 
            label_Nom.AutoSize = true;
            label_Nom.Location = new Point(16, 29);
            label_Nom.Name = "label_Nom";
            label_Nom.Size = new Size(64, 15);
            label_Nom.TabIndex = 1;
            label_Nom.Text = "Qui es-tu ?";
            // 
            // UC_DisBonjour
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_Nom);
            Controls.Add(textBoxRepNom);
            Name = "UC_DisBonjour";
            Size = new Size(272, 99);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxRepNom;
        private Label label_Nom;
    }
}
