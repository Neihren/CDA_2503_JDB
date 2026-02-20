namespace WF_Menu
{
    partial class Form_Saisie
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
            button_Valider = new Button();
            textBox_Text = new TextBox();
            label_Text = new Label();
            SuspendLayout();
            // 
            // button_Valider
            // 
            button_Valider.Location = new Point(279, 27);
            button_Valider.Name = "button_Valider";
            button_Valider.Size = new Size(75, 23);
            button_Valider.TabIndex = 0;
            button_Valider.Text = "Valider";
            button_Valider.UseVisualStyleBackColor = true;
            button_Valider.Click += Button_Valider_Click;
            // 
            // textBox_Text
            // 
            textBox_Text.Location = new Point(12, 27);
            textBox_Text.Name = "textBox_Text";
            textBox_Text.Size = new Size(261, 23);
            textBox_Text.TabIndex = 1;
            // 
            // label_Text
            // 
            label_Text.AutoSize = true;
            label_Text.Location = new Point(12, 9);
            label_Text.Name = "label_Text";
            label_Text.Size = new Size(95, 15);
            label_Text.TabIndex = 2;
            label_Text.Text = "Tapez votre texte";
            // 
            // Form_Saisie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 59);
            Controls.Add(label_Text);
            Controls.Add(textBox_Text);
            Controls.Add(button_Valider);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form_Saisie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saisie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_Text;
        private Label label_Text;
        private Button button_Valider;
    }
}