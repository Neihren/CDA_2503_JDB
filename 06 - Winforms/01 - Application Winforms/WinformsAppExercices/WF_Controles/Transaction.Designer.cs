namespace WF_Controles
{
    partial class Transaction
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_nom = new Label();
            label_date = new Label();
            label_montant = new Label();
            label_codePostal = new Label();
            textBox_nom = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label_dateFormat = new Label();
            btn_valider = new Button();
            btn_effacer = new Button();
            SuspendLayout();
            // 
            // label_nom
            // 
            label_nom.AutoSize = true;
            label_nom.Location = new Point(23, 40);
            label_nom.Name = "label_nom";
            label_nom.Size = new Size(34, 15);
            label_nom.TabIndex = 0;
            label_nom.Text = "Nom";
            // 
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.Location = new Point(23, 69);
            label_date.Name = "label_date";
            label_date.Size = new Size(31, 15);
            label_date.TabIndex = 1;
            label_date.Text = "Date";
            // 
            // label_montant
            // 
            label_montant.AutoSize = true;
            label_montant.Location = new Point(23, 98);
            label_montant.Name = "label_montant";
            label_montant.Size = new Size(53, 15);
            label_montant.TabIndex = 2;
            label_montant.Text = "Montant";
            // 
            // label_codePostal
            // 
            label_codePostal.AutoSize = true;
            label_codePostal.Location = new Point(23, 127);
            label_codePostal.Name = "label_codePostal";
            label_codePostal.Size = new Size(70, 15);
            label_codePostal.TabIndex = 3;
            label_codePostal.Text = "Code Postal";
            // 
            // textBox_nom
            // 
            textBox_nom.Location = new Point(99, 37);
            textBox_nom.Name = "textBox_nom";
            textBox_nom.Size = new Size(191, 23);
            textBox_nom.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // label_dateFormat
            // 
            label_dateFormat.AutoSize = true;
            label_dateFormat.Location = new Point(238, 69);
            label_dateFormat.Name = "label_dateFormat";
            label_dateFormat.Size = new Size(87, 15);
            label_dateFormat.TabIndex = 8;
            label_dateFormat.Text = "(JJ/MM/AAAA)";
            // 
            // btn_valider
            // 
            btn_valider.Location = new Point(250, 123);
            btn_valider.Name = "btn_valider";
            btn_valider.Size = new Size(75, 23);
            btn_valider.TabIndex = 9;
            btn_valider.Text = "Valider";
            btn_valider.UseVisualStyleBackColor = true;
            // 
            // btn_effacer
            // 
            btn_effacer.Location = new Point(250, 152);
            btn_effacer.Name = "btn_effacer";
            btn_effacer.Size = new Size(75, 23);
            btn_effacer.TabIndex = 10;
            btn_effacer.Text = "Effacer";
            btn_effacer.UseVisualStyleBackColor = true;
            // 
            // Controles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 198);
            Controls.Add(btn_effacer);
            Controls.Add(btn_valider);
            Controls.Add(label_dateFormat);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox_nom);
            Controls.Add(label_codePostal);
            Controls.Add(label_montant);
            Controls.Add(label_date);
            Controls.Add(label_nom);
            Name = "Controles";
            Text = "Les contrôles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_nom;
        private Label label_date;
        private Label label_montant;
        private Label label_codePostal;
        private TextBox textBox_nom;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label_dateFormat;
        private Button btn_valider;
        private Button btn_effacer;
    }
}
