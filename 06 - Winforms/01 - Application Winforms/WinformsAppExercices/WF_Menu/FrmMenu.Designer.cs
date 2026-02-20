namespace WF_Menu
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            connectionToolStripMenuItem = new ToolStripMenuItem();
            sidentifierToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            phase1ToolStripMenuItem = new ToolStripMenuItem();
            lAdditionneurToolStripMenuItem = new ToolStripMenuItem();
            phase2ToolStripMenuItem = new ToolStripMenuItem();
            controlesDeSaisieToolStripMenuItem = new ToolStripMenuItem();
            phase3ToolStripMenuItem = new ToolStripMenuItem();
            casesToolStripMenuItem = new ToolStripMenuItem();
            comboBoxToolStripMenuItem = new ToolStripMenuItem();
            défilementToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            synthèseToolStripMenuItem = new ToolStripMenuItem();
            fenetresToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1 = new ToolStrip();
            toolStripButton_identifier = new ToolStripButton();
            toolStripSplitButton1 = new ToolStripSplitButton();
            casesToolStripMenuItem1 = new ToolStripMenuItem();
            comboBoxToolStripMenuItem1 = new ToolStripMenuItem();
            défilementToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            synthèseToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel_Date = new ToolStripStatusLabel();
            toolStripStatusLabel_App = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { connectionToolStripMenuItem, phase1ToolStripMenuItem, phase2ToolStripMenuItem, phase3ToolStripMenuItem, fenetresToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = fenetresToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            connectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sidentifierToolStripMenuItem, quitterToolStripMenuItem });
            connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            connectionToolStripMenuItem.Size = new Size(81, 20);
            connectionToolStripMenuItem.Text = "Connection";
            // 
            // sidentifierToolStripMenuItem
            // 
            sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            sidentifierToolStripMenuItem.Size = new Size(130, 22);
            sidentifierToolStripMenuItem.Text = "S'identifier";
            sidentifierToolStripMenuItem.Click += SidentifierToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(130, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += QuitterToolStripMenuItem_Click;
            // 
            // phase1ToolStripMenuItem
            // 
            phase1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lAdditionneurToolStripMenuItem });
            phase1ToolStripMenuItem.Enabled = false;
            phase1ToolStripMenuItem.Name = "phase1ToolStripMenuItem";
            phase1ToolStripMenuItem.Size = new Size(59, 20);
            phase1ToolStripMenuItem.Text = "Phase 1";
            // 
            // lAdditionneurToolStripMenuItem
            // 
            lAdditionneurToolStripMenuItem.Name = "lAdditionneurToolStripMenuItem";
            lAdditionneurToolStripMenuItem.Size = new Size(153, 22);
            lAdditionneurToolStripMenuItem.Text = "L'Additionneur";
            lAdditionneurToolStripMenuItem.Click += LAdditionneurToolStripMenuItem_Click;
            // 
            // phase2ToolStripMenuItem
            // 
            phase2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { controlesDeSaisieToolStripMenuItem });
            phase2ToolStripMenuItem.Enabled = false;
            phase2ToolStripMenuItem.Name = "phase2ToolStripMenuItem";
            phase2ToolStripMenuItem.Size = new Size(59, 20);
            phase2ToolStripMenuItem.Text = "Phase 2";
            // 
            // controlesDeSaisieToolStripMenuItem
            // 
            controlesDeSaisieToolStripMenuItem.Name = "controlesDeSaisieToolStripMenuItem";
            controlesDeSaisieToolStripMenuItem.Size = new Size(172, 22);
            controlesDeSaisieToolStripMenuItem.Text = "Controles de saisie";
            controlesDeSaisieToolStripMenuItem.Click += ControlesDeSaisieToolStripMenuItem_Click;
            // 
            // phase3ToolStripMenuItem
            // 
            phase3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { casesToolStripMenuItem, comboBoxToolStripMenuItem, défilementToolStripMenuItem, toolStripSeparator1, synthèseToolStripMenuItem });
            phase3ToolStripMenuItem.Enabled = false;
            phase3ToolStripMenuItem.Name = "phase3ToolStripMenuItem";
            phase3ToolStripMenuItem.Size = new Size(59, 20);
            phase3ToolStripMenuItem.Text = "Phase 3";
            // 
            // casesToolStripMenuItem
            // 
            casesToolStripMenuItem.Name = "casesToolStripMenuItem";
            casesToolStripMenuItem.Size = new Size(133, 22);
            casesToolStripMenuItem.Text = "Cases";
            casesToolStripMenuItem.Click += CasesToolStripMenuItem_Click;
            // 
            // comboBoxToolStripMenuItem
            // 
            comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            comboBoxToolStripMenuItem.Size = new Size(133, 22);
            comboBoxToolStripMenuItem.Text = "ComboBox";
            comboBoxToolStripMenuItem.Click += ComboBoxToolStripMenuItem_Click;
            // 
            // défilementToolStripMenuItem
            // 
            défilementToolStripMenuItem.Name = "défilementToolStripMenuItem";
            défilementToolStripMenuItem.Size = new Size(133, 22);
            défilementToolStripMenuItem.Text = "Défilement";
            défilementToolStripMenuItem.Click += DéfilementToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(130, 6);
            // 
            // synthèseToolStripMenuItem
            // 
            synthèseToolStripMenuItem.Name = "synthèseToolStripMenuItem";
            synthèseToolStripMenuItem.Size = new Size(133, 22);
            synthèseToolStripMenuItem.Text = "Synthèse";
            synthèseToolStripMenuItem.Click += SynthèseToolStripMenuItem_Click;
            // 
            // fenetresToolStripMenuItem
            // 
            fenetresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, horizontalToolStripMenuItem, verticalToolStripMenuItem, toolStripSeparator2 });
            fenetresToolStripMenuItem.Enabled = false;
            fenetresToolStripMenuItem.Name = "fenetresToolStripMenuItem";
            fenetresToolStripMenuItem.Size = new Size(63, 20);
            fenetresToolStripMenuItem.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.CheckOnClick = true;
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(129, 22);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.CheckOnClick = true;
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(129, 22);
            horizontalToolStripMenuItem.Text = "Horizontal";
            horizontalToolStripMenuItem.Click += HorizontalToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.CheckOnClick = true;
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(129, 22);
            verticalToolStripMenuItem.Text = "Vertical";
            verticalToolStripMenuItem.Click += VerticalToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(126, 6);
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton_identifier, toolStripSplitButton1 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_identifier
            // 
            toolStripButton_identifier.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_identifier.ImageTransparentColor = Color.Magenta;
            toolStripButton_identifier.Name = "toolStripButton_identifier";
            toolStripButton_identifier.Size = new Size(67, 22);
            toolStripButton_identifier.Text = "S'identifier";
            toolStripButton_identifier.Click += SidentifierToolStripMenuItem_Click;
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { casesToolStripMenuItem1, comboBoxToolStripMenuItem1, défilementToolStripMenuItem1, toolStripSeparator3, synthèseToolStripMenuItem1 });
            toolStripSplitButton1.Enabled = false;
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(63, 22);
            toolStripSplitButton1.Text = "Phase 3";
            // 
            // casesToolStripMenuItem1
            // 
            casesToolStripMenuItem1.Name = "casesToolStripMenuItem1";
            casesToolStripMenuItem1.Size = new Size(133, 22);
            casesToolStripMenuItem1.Text = "Cases";
            casesToolStripMenuItem1.Click += CasesToolStripMenuItem_Click;
            // 
            // comboBoxToolStripMenuItem1
            // 
            comboBoxToolStripMenuItem1.Name = "comboBoxToolStripMenuItem1";
            comboBoxToolStripMenuItem1.Size = new Size(133, 22);
            comboBoxToolStripMenuItem1.Text = "ComboBox";
            comboBoxToolStripMenuItem1.Click += ComboBoxToolStripMenuItem_Click;
            // 
            // défilementToolStripMenuItem1
            // 
            défilementToolStripMenuItem1.Name = "défilementToolStripMenuItem1";
            défilementToolStripMenuItem1.Size = new Size(133, 22);
            défilementToolStripMenuItem1.Text = "Défilement";
            défilementToolStripMenuItem1.Click += DéfilementToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(130, 6);
            // 
            // synthèseToolStripMenuItem1
            // 
            synthèseToolStripMenuItem1.Name = "synthèseToolStripMenuItem1";
            synthèseToolStripMenuItem1.Size = new Size(133, 22);
            synthèseToolStripMenuItem1.Text = "Synthèse";
            synthèseToolStripMenuItem1.Click += SynthèseToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_Date, toolStripStatusLabel_App });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Date
            // 
            toolStripStatusLabel_Date.Name = "toolStripStatusLabel_Date";
            toolStripStatusLabel_Date.Size = new Size(31, 17);
            toolStripStatusLabel_Date.Text = "Date";
            // 
            // toolStripStatusLabel_App
            // 
            toolStripStatusLabel_App.Name = "toolStripStatusLabel_App";
            toolStripStatusLabel_App.Size = new Size(29, 17);
            toolStripStatusLabel_App.Text = "App";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private ToolStripMenuItem phase1ToolStripMenuItem;
        private ToolStripMenuItem phase2ToolStripMenuItem;
        private ToolStripMenuItem phase3ToolStripMenuItem;
        private ToolStripMenuItem fenetresToolStripMenuItem;
        private ToolStripMenuItem sidentifierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem lAdditionneurToolStripMenuItem;
        private ToolStripMenuItem controlesDeSaisieToolStripMenuItem;
        private ToolStripMenuItem casesToolStripMenuItem;
        private ToolStripMenuItem comboBoxToolStripMenuItem;
        private ToolStripMenuItem défilementToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem synthèseToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timer1;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripButton toolStripButton_identifier;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripStatusLabel toolStripStatusLabel_Date;
        private ToolStripStatusLabel toolStripStatusLabel_App;
        private ToolStripMenuItem casesToolStripMenuItem1;
        private ToolStripMenuItem comboBoxToolStripMenuItem1;
        private ToolStripMenuItem défilementToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem synthèseToolStripMenuItem1;
    }
}
