namespace WF_Emprunts
{
    partial class FormEmprunts
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
            label_Capital = new Label();
            label_Duree = new Label();
            label_Periode = new Label();
            label_Remboursements = new Label();
            textBox_Nom = new TextBox();
            textBox_Capital = new TextBox();
            listBox_Periode = new ListBox();
            groupBox_Taux = new GroupBox();
            radioButton_9 = new RadioButton();
            radioButton_8 = new RadioButton();
            radioButton_7 = new RadioButton();
            hScrollBar_Duree = new HScrollBar();
            label_NbDuree = new Label();
            label_NbRemboursements = new Label();
            label_Amount = new Label();
            errorProviderAmount = new ErrorProvider(components);
            groupBox_Taux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderAmount).BeginInit();
            SuspendLayout();
            // 
            // label_Nom
            // 
            label_Nom.AutoSize = true;
            label_Nom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Nom.Location = new Point(17, 27);
            label_Nom.Name = "label_Nom";
            label_Nom.Size = new Size(45, 21);
            label_Nom.TabIndex = 0;
            label_Nom.Text = "Nom";
            // 
            // label_Capital
            // 
            label_Capital.AutoSize = true;
            label_Capital.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Capital.Location = new Point(17, 79);
            label_Capital.Name = "label_Capital";
            label_Capital.Size = new Size(130, 21);
            label_Capital.TabIndex = 1;
            label_Capital.Text = "Capital Emprunté";
            // 
            // label_Duree
            // 
            label_Duree.AutoSize = true;
            label_Duree.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Duree.Location = new Point(17, 136);
            label_Duree.Name = "label_Duree";
            label_Duree.Size = new Size(133, 42);
            label_Duree.TabIndex = 2;
            label_Duree.Text = "Durée en mois du\r\nremboursement";
            // 
            // label_Periode
            // 
            label_Periode.AutoSize = true;
            label_Periode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Periode.Location = new Point(17, 204);
            label_Periode.Name = "label_Periode";
            label_Periode.Size = new Size(219, 21);
            label_Periode.TabIndex = 3;
            label_Periode.Text = "Périodicité de remboursement";
            // 
            // label_Remboursements
            // 
            label_Remboursements.AutoSize = true;
            label_Remboursements.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Remboursements.Location = new Point(343, 204);
            label_Remboursements.Name = "label_Remboursements";
            label_Remboursements.Size = new Size(143, 21);
            label_Remboursements.TabIndex = 4;
            label_Remboursements.Text = "Remboursements";
            // 
            // textBox_Nom
            // 
            textBox_Nom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Nom.Location = new Point(200, 23);
            textBox_Nom.Name = "textBox_Nom";
            textBox_Nom.Size = new Size(177, 29);
            textBox_Nom.TabIndex = 5;
            // 
            // textBox_Capital
            // 
            textBox_Capital.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Capital.Location = new Point(200, 75);
            textBox_Capital.MaxLength = 10;
            textBox_Capital.Name = "textBox_Capital";
            textBox_Capital.Size = new Size(177, 29);
            textBox_Capital.TabIndex = 6;
            textBox_Capital.TextChanged += TextBox_Capital_TextChanged;
            // 
            // listBox_Periode
            // 
            listBox_Periode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox_Periode.FormattingEnabled = true;
            listBox_Periode.ItemHeight = 21;
            listBox_Periode.Location = new Point(20, 232);
            listBox_Periode.Name = "listBox_Periode";
            listBox_Periode.Size = new Size(120, 109);
            listBox_Periode.TabIndex = 8;
            listBox_Periode.SelectedIndexChanged += ListBox_Periode_SelectedIndexChanged;
            // 
            // groupBox_Taux
            // 
            groupBox_Taux.Controls.Add(radioButton_9);
            groupBox_Taux.Controls.Add(radioButton_8);
            groupBox_Taux.Controls.Add(radioButton_7);
            groupBox_Taux.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_Taux.Location = new Point(404, 23);
            groupBox_Taux.Name = "groupBox_Taux";
            groupBox_Taux.Size = new Size(117, 145);
            groupBox_Taux.TabIndex = 9;
            groupBox_Taux.TabStop = false;
            groupBox_Taux.Text = "Taux d'intérêt";
            // 
            // radioButton_9
            // 
            radioButton_9.AutoSize = true;
            radioButton_9.Location = new Point(31, 98);
            radioButton_9.Name = "radioButton_9";
            radioButton_9.Size = new Size(54, 25);
            radioButton_9.TabIndex = 2;
            radioButton_9.TabStop = true;
            radioButton_9.Text = "9 %";
            radioButton_9.UseVisualStyleBackColor = true;
            radioButton_9.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // radioButton_8
            // 
            radioButton_8.AutoSize = true;
            radioButton_8.Location = new Point(31, 67);
            radioButton_8.Name = "radioButton_8";
            radioButton_8.Size = new Size(54, 25);
            radioButton_8.TabIndex = 1;
            radioButton_8.TabStop = true;
            radioButton_8.Text = "8 %";
            radioButton_8.UseVisualStyleBackColor = true;
            radioButton_8.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // radioButton_7
            // 
            radioButton_7.AutoSize = true;
            radioButton_7.Location = new Point(31, 38);
            radioButton_7.Name = "radioButton_7";
            radioButton_7.Size = new Size(54, 25);
            radioButton_7.TabIndex = 0;
            radioButton_7.TabStop = true;
            radioButton_7.Text = "7 %";
            radioButton_7.UseVisualStyleBackColor = true;
            radioButton_7.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // hScrollBar_Duree
            // 
            hScrollBar_Duree.Location = new Point(246, 149);
            hScrollBar_Duree.Maximum = 300;
            hScrollBar_Duree.Minimum = 1;
            hScrollBar_Duree.Name = "hScrollBar_Duree";
            hScrollBar_Duree.Size = new Size(131, 17);
            hScrollBar_Duree.TabIndex = 10;
            hScrollBar_Duree.Value = 1;
            hScrollBar_Duree.Scroll += HScrollBar_Duree_Scroll;
            hScrollBar_Duree.ValueChanged += HScrollBar_Duree_ValueChanged;
            // 
            // label_NbDuree
            // 
            label_NbDuree.AutoSize = true;
            label_NbDuree.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_NbDuree.Location = new Point(200, 147);
            label_NbDuree.Name = "label_NbDuree";
            label_NbDuree.Size = new Size(19, 21);
            label_NbDuree.TabIndex = 11;
            label_NbDuree.Text = "0";
            // 
            // label_NbRemboursements
            // 
            label_NbRemboursements.AutoSize = true;
            label_NbRemboursements.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_NbRemboursements.ForeColor = Color.Red;
            label_NbRemboursements.Location = new Point(302, 204);
            label_NbRemboursements.Name = "label_NbRemboursements";
            label_NbRemboursements.Size = new Size(19, 21);
            label_NbRemboursements.TabIndex = 14;
            label_NbRemboursements.Text = "0";
            // 
            // label_Amount
            // 
            label_Amount.AutoSize = true;
            label_Amount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Amount.ForeColor = Color.Red;
            label_Amount.Location = new Point(375, 252);
            label_Amount.Name = "label_Amount";
            label_Amount.Size = new Size(53, 21);
            label_Amount.TabIndex = 15;
            label_Amount.Text = "0,00 €";
            // 
            // errorProviderAmount
            // 
            errorProviderAmount.ContainerControl = this;
            // 
            // FormEmprunts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 359);
            Controls.Add(label_Amount);
            Controls.Add(label_NbRemboursements);
            Controls.Add(label_NbDuree);
            Controls.Add(hScrollBar_Duree);
            Controls.Add(groupBox_Taux);
            Controls.Add(listBox_Periode);
            Controls.Add(textBox_Capital);
            Controls.Add(textBox_Nom);
            Controls.Add(label_Remboursements);
            Controls.Add(label_Periode);
            Controls.Add(label_Duree);
            Controls.Add(label_Capital);
            Controls.Add(label_Nom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormEmprunts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox_Taux.ResumeLayout(false);
            groupBox_Taux.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Nom;
        private Label label_Capital;
        private Label label_Duree;
        private Label label_Periode;
        private Label label_Remboursements;
        private TextBox textBox_Nom;
        private TextBox textBox_Capital;
        private ListBox listBox_Periode;
        private GroupBox groupBox_Taux;
        private RadioButton radioButton_7;
        private RadioButton radioButton_9;
        private RadioButton radioButton_8;
        private HScrollBar hScrollBar_Duree;
        private Label label_NbDuree;
        private Label label_NbRemboursements;
        private Label label_Amount;
        private ErrorProvider errorProviderAmount;
    }
}
