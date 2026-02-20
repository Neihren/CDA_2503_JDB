namespace WF_TrouveEmploi
{
    partial class Form_TrouveEmploi
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
            components = new System.ComponentModel.Container();
            label_Nom = new Label();
            label_DateInscription = new Label();
            groupBox_Niveau = new GroupBox();
            radioButton_SupBacPlus5 = new RadioButton();
            radioButton_BacPlus5 = new RadioButton();
            radioButton_BacPlus2 = new RadioButton();
            radioButton_Bac = new RadioButton();
            radioButton_InfBac = new RadioButton();
            textBox_Nom = new TextBox();
            textBox_DateInscription = new TextBox();
            label_Titre = new Label();
            button_Modifier = new Button();
            button_Valider = new Button();
            button_Annuler = new Button();
            errorProvider_Nom = new ErrorProvider(components);
            errorProvider_Date = new ErrorProvider(components);
            groupBox_Niveau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Nom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Date).BeginInit();
            SuspendLayout();
            // 
            // label_Nom
            // 
            label_Nom.AutoSize = true;
            label_Nom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Nom.Location = new Point(22, 78);
            label_Nom.Name = "label_Nom";
            label_Nom.Size = new Size(45, 21);
            label_Nom.TabIndex = 0;
            label_Nom.Text = "Nom";
            // 
            // label_DateInscription
            // 
            label_DateInscription.AutoSize = true;
            label_DateInscription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_DateInscription.Location = new Point(22, 126);
            label_DateInscription.Name = "label_DateInscription";
            label_DateInscription.Size = new Size(132, 21);
            label_DateInscription.TabIndex = 1;
            label_DateInscription.Text = "Date d'inscription";
            // 
            // groupBox_Niveau
            // 
            groupBox_Niveau.Controls.Add(radioButton_SupBacPlus5);
            groupBox_Niveau.Controls.Add(radioButton_BacPlus5);
            groupBox_Niveau.Controls.Add(radioButton_BacPlus2);
            groupBox_Niveau.Controls.Add(radioButton_Bac);
            groupBox_Niveau.Controls.Add(radioButton_InfBac);
            groupBox_Niveau.Enabled = false;
            groupBox_Niveau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_Niveau.Location = new Point(15, 174);
            groupBox_Niveau.Name = "groupBox_Niveau";
            groupBox_Niveau.Size = new Size(302, 189);
            groupBox_Niveau.TabIndex = 3;
            groupBox_Niveau.TabStop = false;
            groupBox_Niveau.Text = "Niveau de formation (Maximum acquis)";
            // 
            // radioButton_SupBacPlus5
            // 
            radioButton_SupBacPlus5.AutoSize = true;
            radioButton_SupBacPlus5.Location = new Point(13, 152);
            radioButton_SupBacPlus5.Name = "radioButton_SupBacPlus5";
            radioButton_SupBacPlus5.Size = new Size(152, 25);
            radioButton_SupBacPlus5.TabIndex = 4;
            radioButton_SupBacPlus5.TabStop = true;
            radioButton_SupBacPlus5.Text = "Supérieur Bac + 5";
            radioButton_SupBacPlus5.UseVisualStyleBackColor = true;
            // 
            // radioButton_BacPlus5
            // 
            radioButton_BacPlus5.AutoSize = true;
            radioButton_BacPlus5.Location = new Point(13, 121);
            radioButton_BacPlus5.Name = "radioButton_BacPlus5";
            radioButton_BacPlus5.Size = new Size(80, 25);
            radioButton_BacPlus5.TabIndex = 3;
            radioButton_BacPlus5.TabStop = true;
            radioButton_BacPlus5.Text = "Bac + 5";
            radioButton_BacPlus5.UseVisualStyleBackColor = true;
            // 
            // radioButton_BacPlus2
            // 
            radioButton_BacPlus2.AutoSize = true;
            radioButton_BacPlus2.Location = new Point(13, 90);
            radioButton_BacPlus2.Name = "radioButton_BacPlus2";
            radioButton_BacPlus2.Size = new Size(80, 25);
            radioButton_BacPlus2.TabIndex = 2;
            radioButton_BacPlus2.TabStop = true;
            radioButton_BacPlus2.Text = "Bac + 2";
            radioButton_BacPlus2.UseVisualStyleBackColor = true;
            // 
            // radioButton_Bac
            // 
            radioButton_Bac.AutoSize = true;
            radioButton_Bac.Location = new Point(13, 59);
            radioButton_Bac.Name = "radioButton_Bac";
            radioButton_Bac.Size = new Size(52, 25);
            radioButton_Bac.TabIndex = 1;
            radioButton_Bac.TabStop = true;
            radioButton_Bac.Text = "Bac";
            radioButton_Bac.UseVisualStyleBackColor = true;
            // 
            // radioButton_InfBac
            // 
            radioButton_InfBac.AutoSize = true;
            radioButton_InfBac.Location = new Point(13, 28);
            radioButton_InfBac.Name = "radioButton_InfBac";
            radioButton_InfBac.Size = new Size(115, 25);
            radioButton_InfBac.TabIndex = 0;
            radioButton_InfBac.TabStop = true;
            radioButton_InfBac.Text = "Inférieur Bac";
            radioButton_InfBac.UseVisualStyleBackColor = true;
            // 
            // textBox_Nom
            // 
            textBox_Nom.Enabled = false;
            textBox_Nom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Nom.Location = new Point(170, 75);
            textBox_Nom.MaxLength = 20;
            textBox_Nom.Name = "textBox_Nom";
            textBox_Nom.Size = new Size(270, 29);
            textBox_Nom.TabIndex = 4;
            textBox_Nom.Validating += TextBox_Nom_Validating;
            // 
            // textBox_DateInscription
            // 
            textBox_DateInscription.Enabled = false;
            textBox_DateInscription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_DateInscription.Location = new Point(170, 123);
            textBox_DateInscription.Name = "textBox_DateInscription";
            textBox_DateInscription.Size = new Size(270, 29);
            textBox_DateInscription.TabIndex = 5;
            textBox_DateInscription.Validating += TextBox_DateInscription_Validating;
            // 
            // label_Titre
            // 
            label_Titre.AutoSize = true;
            label_Titre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Titre.Location = new Point(73, 9);
            label_Titre.Name = "label_Titre";
            label_Titre.Size = new Size(306, 30);
            label_Titre.TabIndex = 6;
            label_Titre.Text = "Information chercheur d'emploi";
            // 
            // button_Modifier
            // 
            button_Modifier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Modifier.Location = new Point(341, 197);
            button_Modifier.Name = "button_Modifier";
            button_Modifier.Size = new Size(99, 34);
            button_Modifier.TabIndex = 7;
            button_Modifier.Text = "Modifier";
            button_Modifier.UseVisualStyleBackColor = true;
            button_Modifier.Click += Button_Modifier_Click;
            // 
            // button_Valider
            // 
            button_Valider.Enabled = false;
            button_Valider.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Valider.Location = new Point(341, 258);
            button_Valider.Name = "button_Valider";
            button_Valider.Size = new Size(99, 34);
            button_Valider.TabIndex = 8;
            button_Valider.Text = "Valider";
            button_Valider.UseVisualStyleBackColor = true;
            button_Valider.Click += Button_Valider_Click;
            // 
            // button_Annuler
            // 
            button_Annuler.Enabled = false;
            button_Annuler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Annuler.Location = new Point(341, 319);
            button_Annuler.Name = "button_Annuler";
            button_Annuler.Size = new Size(99, 34);
            button_Annuler.TabIndex = 9;
            button_Annuler.Text = "Annuler";
            button_Annuler.UseVisualStyleBackColor = true;
            button_Annuler.Click += Button_Annuler_Click;
            // 
            // errorProvider_Nom
            // 
            errorProvider_Nom.ContainerControl = this;
            // 
            // errorProvider_Date
            // 
            errorProvider_Date.ContainerControl = this;
            // 
            // Form_TrouveEmploi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 383);
            Controls.Add(button_Annuler);
            Controls.Add(button_Valider);
            Controls.Add(button_Modifier);
            Controls.Add(label_Titre);
            Controls.Add(textBox_DateInscription);
            Controls.Add(textBox_Nom);
            Controls.Add(groupBox_Niveau);
            Controls.Add(label_DateInscription);
            Controls.Add(label_Nom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form_TrouveEmploi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrouveEmploi : Information chercheur d'emploi";
            groupBox_Niveau.ResumeLayout(false);
            groupBox_Niveau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Nom).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Date).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Nom;
        private Label label_DateInscription;
        private GroupBox groupBox_Niveau;
        private RadioButton radioButton_Bac;
        private RadioButton radioButton_InfBac;
        private RadioButton radioButton_SupBacPlus5;
        private RadioButton radioButton_BacPlus5;
        private RadioButton radioButton_BacPlus2;
        private TextBox textBox_Nom;
        private TextBox textBox_DateInscription;
        private Label label_Titre;
        private Button button_Modifier;
        private Button button_Valider;
        private Button button_Annuler;
        private ErrorProvider errorProvider_Nom;
        private ErrorProvider errorProvider_Date;
    }
}
