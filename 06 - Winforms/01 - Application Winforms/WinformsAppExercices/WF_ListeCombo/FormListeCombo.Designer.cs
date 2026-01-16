namespace WF_ListeCombo
{
    partial class FormListeCombo
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
            components = new System.ComponentModel.Container();
            comboBox_Source = new ComboBox();
            listBox_Cible = new ListBox();
            label_Source = new Label();
            label_Cible = new Label();
            button_Add = new Button();
            button_AddAll = new Button();
            button_Remove = new Button();
            button_RemoveAll = new Button();
            button_MoveUp = new Button();
            button_MoveDown = new Button();
            errorProviderExist = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderExist).BeginInit();
            SuspendLayout();
            // 
            // comboBox_Source
            // 
            comboBox_Source.FormattingEnabled = true;
            comboBox_Source.Location = new Point(22, 45);
            comboBox_Source.Name = "comboBox_Source";
            comboBox_Source.Size = new Size(121, 23);
            comboBox_Source.TabIndex = 0;
            comboBox_Source.SelectionChangeCommitted += ComboBox_Source_SelectionChangeCommitted;
            comboBox_Source.TextChanged += ComboBox_Source_TextChanged;
            comboBox_Source.KeyPress += ComboBox_Source_KeyPress;
            // 
            // listBox_Cible
            // 
            listBox_Cible.FormattingEnabled = true;
            listBox_Cible.ItemHeight = 15;
            listBox_Cible.Location = new Point(282, 44);
            listBox_Cible.Name = "listBox_Cible";
            listBox_Cible.Size = new Size(120, 94);
            listBox_Cible.TabIndex = 1;
            listBox_Cible.SelectedIndexChanged += ListBox_Cible_SelectedIndexChanged;
            // 
            // label_Source
            // 
            label_Source.AutoSize = true;
            label_Source.Location = new Point(60, 16);
            label_Source.Name = "label_Source";
            label_Source.Size = new Size(43, 15);
            label_Source.TabIndex = 2;
            label_Source.Text = "Source";
            // 
            // label_Cible
            // 
            label_Cible.AutoSize = true;
            label_Cible.Location = new Point(318, 17);
            label_Cible.Name = "label_Cible";
            label_Cible.Size = new Size(34, 15);
            label_Cible.TabIndex = 3;
            label_Cible.Text = "Cible";
            // 
            // button_Add
            // 
            button_Add.Enabled = false;
            button_Add.Location = new Point(175, 44);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(75, 23);
            button_Add.TabIndex = 4;
            button_Add.Text = ">";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += Button_Add_Click;
            // 
            // button_AddAll
            // 
            button_AddAll.Enabled = false;
            button_AddAll.Location = new Point(175, 73);
            button_AddAll.Name = "button_AddAll";
            button_AddAll.Size = new Size(75, 23);
            button_AddAll.TabIndex = 5;
            button_AddAll.Text = ">>";
            button_AddAll.UseVisualStyleBackColor = true;
            button_AddAll.Click += Button_AddAll_Click;
            // 
            // button_Remove
            // 
            button_Remove.Enabled = false;
            button_Remove.Location = new Point(175, 118);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(75, 23);
            button_Remove.TabIndex = 6;
            button_Remove.Text = "<";
            button_Remove.UseVisualStyleBackColor = true;
            button_Remove.Click += Button_Remove_Click;
            // 
            // button_RemoveAll
            // 
            button_RemoveAll.Enabled = false;
            button_RemoveAll.Location = new Point(175, 147);
            button_RemoveAll.Name = "button_RemoveAll";
            button_RemoveAll.Size = new Size(75, 23);
            button_RemoveAll.TabIndex = 7;
            button_RemoveAll.Text = "<<";
            button_RemoveAll.UseVisualStyleBackColor = true;
            button_RemoveAll.Click += Button_RemoveAll_Click;
            // 
            // button_MoveUp
            // 
            button_MoveUp.Enabled = false;
            button_MoveUp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_MoveUp.Location = new Point(299, 147);
            button_MoveUp.Name = "button_MoveUp";
            button_MoveUp.Size = new Size(34, 36);
            button_MoveUp.TabIndex = 8;
            button_MoveUp.Text = "🡅";
            button_MoveUp.UseVisualStyleBackColor = true;
            button_MoveUp.Click += Button_MoveUp_Click;
            // 
            // button_MoveDown
            // 
            button_MoveDown.Enabled = false;
            button_MoveDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_MoveDown.Location = new Point(348, 147);
            button_MoveDown.Name = "button_MoveDown";
            button_MoveDown.Size = new Size(34, 36);
            button_MoveDown.TabIndex = 9;
            button_MoveDown.Text = "🡇";
            button_MoveDown.UseVisualStyleBackColor = true;
            button_MoveDown.Click += Button_MoveDown_Click;
            // 
            // errorProviderExist
            // 
            errorProviderExist.ContainerControl = this;
            // 
            // FormListeCombo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 195);
            Controls.Add(button_MoveDown);
            Controls.Add(button_MoveUp);
            Controls.Add(button_RemoveAll);
            Controls.Add(button_Remove);
            Controls.Add(button_AddAll);
            Controls.Add(button_Add);
            Controls.Add(label_Cible);
            Controls.Add(label_Source);
            Controls.Add(listBox_Cible);
            Controls.Add(comboBox_Source);
            MaximizeBox = false;
            Name = "FormListeCombo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormListeCombo";
            ((System.ComponentModel.ISupportInitialize)errorProviderExist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Source;
        private ListBox listBox_Cible;
        private Label label_Source;
        private Label label_Cible;
        private Button button_Add;
        private Button button_AddAll;
        private Button button_Remove;
        private Button button_RemoveAll;
        private Button button_MoveUp;
        private Button button_MoveDown;
        private ErrorProvider errorProviderExist;
    }
}