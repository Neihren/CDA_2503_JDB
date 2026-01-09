namespace WF_Liste
{
    partial class Form_Liste
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
            label_NouvelElement = new Label();
            textBox_NouvelElement = new TextBox();
            label_IndexElement = new Label();
            textBox_IndexElement = new TextBox();
            button_Ajout = new Button();
            button_Selectionner = new Button();
            button_Vider = new Button();
            label_Liste = new Label();
            label_Propriete = new Label();
            listBox_Liste = new ListBox();
            label_count = new Label();
            label_SelectedIndex = new Label();
            label_Text = new Label();
            textBox_ItemCount = new TextBox();
            textBox_SelectedIndex = new TextBox();
            textBox_SelectedText = new TextBox();
            errorProviderIndex = new ErrorProvider(components);
            errorProviderNew = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderIndex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNew).BeginInit();
            SuspendLayout();
            // 
            // label_NouvelElement
            // 
            label_NouvelElement.AutoSize = true;
            label_NouvelElement.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label_NouvelElement.Location = new Point(25, 26);
            label_NouvelElement.Name = "label_NouvelElement";
            label_NouvelElement.Size = new Size(133, 21);
            label_NouvelElement.TabIndex = 0;
            label_NouvelElement.Text = "Nouvel Elément";
            // 
            // textBox_NouvelElement
            // 
            textBox_NouvelElement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_NouvelElement.Location = new Point(25, 61);
            textBox_NouvelElement.Name = "textBox_NouvelElement";
            textBox_NouvelElement.Size = new Size(183, 29);
            textBox_NouvelElement.TabIndex = 1;
            textBox_NouvelElement.Leave += TextBox_NouvelElement_Leave;
            // 
            // label_IndexElement
            // 
            label_IndexElement.AutoSize = true;
            label_IndexElement.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label_IndexElement.Location = new Point(243, 26);
            label_IndexElement.Name = "label_IndexElement";
            label_IndexElement.Size = new Size(120, 21);
            label_IndexElement.TabIndex = 2;
            label_IndexElement.Text = "Index Elément";
            // 
            // textBox_IndexElement
            // 
            textBox_IndexElement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_IndexElement.Location = new Point(243, 61);
            textBox_IndexElement.Name = "textBox_IndexElement";
            textBox_IndexElement.Size = new Size(50, 29);
            textBox_IndexElement.TabIndex = 3;
            textBox_IndexElement.Leave += TextBox_IndexElement_Leave;
            // 
            // button_Ajout
            // 
            button_Ajout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Ajout.Location = new Point(25, 105);
            button_Ajout.Name = "button_Ajout";
            button_Ajout.Size = new Size(183, 29);
            button_Ajout.TabIndex = 4;
            button_Ajout.Text = "Ajout Liste";
            button_Ajout.UseVisualStyleBackColor = true;
            button_Ajout.Click += Button_Ajout_Click;
            // 
            // button_Selectionner
            // 
            button_Selectionner.Enabled = false;
            button_Selectionner.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Selectionner.Location = new Point(324, 61);
            button_Selectionner.Name = "button_Selectionner";
            button_Selectionner.Size = new Size(183, 29);
            button_Selectionner.TabIndex = 5;
            button_Selectionner.Text = "Sélectionner";
            button_Selectionner.UseVisualStyleBackColor = true;
            button_Selectionner.Click += Button_Selectionner_Click;
            // 
            // button_Vider
            // 
            button_Vider.Enabled = false;
            button_Vider.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Vider.Location = new Point(324, 105);
            button_Vider.Name = "button_Vider";
            button_Vider.Size = new Size(183, 29);
            button_Vider.TabIndex = 6;
            button_Vider.Text = "Vider la Liste";
            button_Vider.UseVisualStyleBackColor = true;
            button_Vider.Click += Button_Vider_Click;
            // 
            // label_Liste
            // 
            label_Liste.AutoSize = true;
            label_Liste.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label_Liste.Location = new Point(25, 156);
            label_Liste.Name = "label_Liste";
            label_Liste.Size = new Size(45, 21);
            label_Liste.TabIndex = 7;
            label_Liste.Text = "Liste";
            // 
            // label_Propriete
            // 
            label_Propriete.AutoSize = true;
            label_Propriete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label_Propriete.Location = new Point(243, 156);
            label_Propriete.Name = "label_Propriete";
            label_Propriete.Size = new Size(88, 21);
            label_Propriete.TabIndex = 8;
            label_Propriete.Text = "Propriétés";
            // 
            // listBox_Liste
            // 
            listBox_Liste.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox_Liste.FormattingEnabled = true;
            listBox_Liste.ItemHeight = 21;
            listBox_Liste.Location = new Point(25, 192);
            listBox_Liste.Name = "listBox_Liste";
            listBox_Liste.Size = new Size(183, 130);
            listBox_Liste.TabIndex = 9;
            listBox_Liste.SelectedIndexChanged += ListBox_Liste_SelectedIndexChanged;
            // 
            // label_count
            // 
            label_count.AutoSize = true;
            label_count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_count.Location = new Point(243, 206);
            label_count.Name = "label_count";
            label_count.Size = new Size(94, 21);
            label_count.TabIndex = 10;
            label_count.Text = "Items Count";
            // 
            // label_SelectedIndex
            // 
            label_SelectedIndex.AutoSize = true;
            label_SelectedIndex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_SelectedIndex.Location = new Point(243, 250);
            label_SelectedIndex.Name = "label_SelectedIndex";
            label_SelectedIndex.Size = new Size(109, 21);
            label_SelectedIndex.TabIndex = 11;
            label_SelectedIndex.Text = "Selected Index";
            // 
            // label_Text
            // 
            label_Text.AutoSize = true;
            label_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Text.Location = new Point(243, 296);
            label_Text.Name = "label_Text";
            label_Text.Size = new Size(36, 21);
            label_Text.TabIndex = 12;
            label_Text.Text = "Text";
            // 
            // textBox_ItemCount
            // 
            textBox_ItemCount.Enabled = false;
            textBox_ItemCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ItemCount.Location = new Point(382, 203);
            textBox_ItemCount.Name = "textBox_ItemCount";
            textBox_ItemCount.Size = new Size(49, 29);
            textBox_ItemCount.TabIndex = 13;
            // 
            // textBox_SelectedIndex
            // 
            textBox_SelectedIndex.Enabled = false;
            textBox_SelectedIndex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_SelectedIndex.Location = new Point(382, 247);
            textBox_SelectedIndex.Name = "textBox_SelectedIndex";
            textBox_SelectedIndex.Size = new Size(49, 29);
            textBox_SelectedIndex.TabIndex = 14;
            // 
            // textBox_SelectedText
            // 
            textBox_SelectedText.Enabled = false;
            textBox_SelectedText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_SelectedText.Location = new Point(382, 293);
            textBox_SelectedText.Name = "textBox_SelectedText";
            textBox_SelectedText.Size = new Size(125, 29);
            textBox_SelectedText.TabIndex = 15;
            // 
            // errorProviderIndex
            // 
            errorProviderIndex.ContainerControl = this;
            // 
            // errorProviderNew
            // 
            errorProviderNew.ContainerControl = this;
            // 
            // Form_Liste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 340);
            Controls.Add(textBox_SelectedText);
            Controls.Add(textBox_SelectedIndex);
            Controls.Add(textBox_ItemCount);
            Controls.Add(label_Text);
            Controls.Add(label_SelectedIndex);
            Controls.Add(label_count);
            Controls.Add(listBox_Liste);
            Controls.Add(label_Propriete);
            Controls.Add(label_Liste);
            Controls.Add(button_Vider);
            Controls.Add(button_Selectionner);
            Controls.Add(button_Ajout);
            Controls.Add(textBox_IndexElement);
            Controls.Add(label_IndexElement);
            Controls.Add(textBox_NouvelElement);
            Controls.Add(label_NouvelElement);
            MaximizeBox = false;
            Name = "Form_Liste";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProviderIndex).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNew).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_NouvelElement;
        private TextBox textBox_NouvelElement;
        private Label label_IndexElement;
        private TextBox textBox_IndexElement;
        private Button button_Ajout;
        private Button button_Selectionner;
        private Button button_Vider;
        private Label label_Liste;
        private Label label_Propriete;
        private ListBox listBox_Liste;
        private Label label_count;
        private Label label_SelectedIndex;
        private Label label_Text;
        private TextBox textBox_ItemCount;
        private TextBox textBox_SelectedIndex;
        private TextBox textBox_SelectedText;
        private ErrorProvider errorProviderIndex;
        private ErrorProvider errorProviderNew;
    }
}
