namespace WF_Additionneur
{
    partial class Additionneur
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
            btn_0 = new Button();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_suppr = new Button();
            btn_calcul = new Button();
            textBox_calcul = new TextBox();
            SuspendLayout();
            // 
            // btn_0
            // 
            btn_0.Font = new Font("Segoe UI", 12F);
            btn_0.Location = new Point(96, 255);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(40, 40);
            btn_0.TabIndex = 0;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_nb_click;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Segoe UI", 12F);
            btn_1.Location = new Point(39, 117);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(40, 40);
            btn_1.TabIndex = 1;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_nb_click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Segoe UI", 12F);
            btn_2.Location = new Point(96, 117);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(40, 40);
            btn_2.TabIndex = 2;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_nb_click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Segoe UI", 12F);
            btn_3.Location = new Point(155, 117);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(40, 40);
            btn_3.TabIndex = 3;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_nb_click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Segoe UI", 12F);
            btn_4.Location = new Point(39, 163);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(40, 40);
            btn_4.TabIndex = 4;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_nb_click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Segoe UI", 12F);
            btn_5.Location = new Point(96, 163);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(40, 40);
            btn_5.TabIndex = 5;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_nb_click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Segoe UI", 12F);
            btn_6.Location = new Point(155, 163);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(40, 40);
            btn_6.TabIndex = 6;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_nb_click;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Segoe UI", 12F);
            btn_7.Location = new Point(39, 209);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(40, 40);
            btn_7.TabIndex = 7;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_nb_click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Segoe UI", 12F);
            btn_8.Location = new Point(96, 209);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(40, 40);
            btn_8.TabIndex = 8;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_nb_click;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Segoe UI", 12F);
            btn_9.Location = new Point(155, 209);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(40, 40);
            btn_9.TabIndex = 9;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_nb_click;
            // 
            // btn_suppr
            // 
            btn_suppr.Location = new Point(39, 255);
            btn_suppr.Name = "btn_suppr";
            btn_suppr.Size = new Size(51, 40);
            btn_suppr.TabIndex = 10;
            btn_suppr.Text = "Suppr";
            btn_suppr.UseVisualStyleBackColor = true;
            btn_suppr.Click += btn_suppr_Click;
            // 
            // btn_calcul
            // 
            btn_calcul.Location = new Point(142, 255);
            btn_calcul.Name = "btn_calcul";
            btn_calcul.Size = new Size(53, 40);
            btn_calcul.TabIndex = 11;
            btn_calcul.Text = "Calcul";
            btn_calcul.UseVisualStyleBackColor = true;
            btn_calcul.Click += btn_calcul_Click;
            // 
            // textBox_calcul
            // 
            textBox_calcul.Location = new Point(39, 12);
            textBox_calcul.Multiline = true;
            textBox_calcul.Name = "textBox_calcul";
            textBox_calcul.ReadOnly = true;
            textBox_calcul.ScrollBars = ScrollBars.Vertical;
            textBox_calcul.Size = new Size(156, 78);
            textBox_calcul.TabIndex = 12;
            // 
            // Additionneur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 308);
            Controls.Add(textBox_calcul);
            Controls.Add(btn_calcul);
            Controls.Add(btn_suppr);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Additionneur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Additionneur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_0;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_suppr;
        private Button btn_calcul;
        private TextBox textBox_calcul;
    }
}
