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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { connectionToolStripMenuItem, phase1ToolStripMenuItem, phase2ToolStripMenuItem, phase3ToolStripMenuItem, fenetresToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
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
            sidentifierToolStripMenuItem.Size = new Size(180, 22);
            sidentifierToolStripMenuItem.Text = "S'identifier";
            sidentifierToolStripMenuItem.Click += SidentifierToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(180, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
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
            lAdditionneurToolStripMenuItem.Size = new Size(180, 22);
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
            // 
            // comboBoxToolStripMenuItem
            // 
            comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            comboBoxToolStripMenuItem.Size = new Size(133, 22);
            comboBoxToolStripMenuItem.Text = "ComboBox";
            // 
            // défilementToolStripMenuItem
            // 
            défilementToolStripMenuItem.Name = "défilementToolStripMenuItem";
            défilementToolStripMenuItem.Size = new Size(133, 22);
            défilementToolStripMenuItem.Text = "Défilement";
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
            cascadeToolStripMenuItem.Checked = true;
            cascadeToolStripMenuItem.CheckOnClick = true;
            cascadeToolStripMenuItem.CheckState = CheckState.Checked;
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(129, 22);
            cascadeToolStripMenuItem.Text = "Cascade";
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.CheckOnClick = true;
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(129, 22);
            horizontalToolStripMenuItem.Text = "Horizontal";
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.CheckOnClick = true;
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(129, 22);
            verticalToolStripMenuItem.Text = "Vertical";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(126, 6);
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}
