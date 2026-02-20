namespace WF_ToutEmbal
{
    partial class Form_ToutEmbal
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
            fichierToolStripMenuItem = new ToolStripMenuItem();
            quittereToolStripMenuItem = new ToolStripMenuItem();
            productionToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripMenuItem();
            aToolStripMenuItem = new ToolStripMenuItem();
            bToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            arrêterToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem1 = new ToolStripMenuItem();
            bToolStripMenuItem1 = new ToolStripMenuItem();
            cToolStripMenuItem1 = new ToolStripMenuItem();
            continuerToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem2 = new ToolStripMenuItem();
            bToolStripMenuItem2 = new ToolStripMenuItem();
            cToolStripMenuItem2 = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage_A = new TabPage();
            textBox_ADefautDemarrage = new TextBox();
            textBox_ADefautHeure = new TextBox();
            textBox_ANbCaisses = new TextBox();
            label_ADefautDemarrage = new Label();
            label_ADefautHeure = new Label();
            label_ANbCaisses = new Label();
            tabPage_B = new TabPage();
            textBox_BDefautDemarrage = new TextBox();
            textBox_BDefautHeure = new TextBox();
            textBox_BNbCaisses = new TextBox();
            label_BDefautDemarrage = new Label();
            label_BDefautHeure = new Label();
            label_BNbCaisses = new Label();
            tabPage_C = new TabPage();
            textBox_CDefautDemarrage = new TextBox();
            textBox_CDefautHeure = new TextBox();
            textBox_CNbCaisses = new TextBox();
            label_CDefautDemarrage = new Label();
            label_CDefautHeure = new Label();
            label_CNbCaisses = new Label();
            label_ProductionA = new Label();
            label_ProductionB = new Label();
            label_ProductionC = new Label();
            progressBar_A = new ProgressBar();
            button_ADemarrer = new Button();
            button_AArreter = new Button();
            button_AContinuer = new Button();
            button_BContinuer = new Button();
            button_BArreter = new Button();
            button_BDemarrer = new Button();
            button_CContinuer = new Button();
            button_CArreter = new Button();
            button_CDemarrer = new Button();
            progressBar_B = new ProgressBar();
            progressBar_C = new ProgressBar();
            statusStrip1 = new StatusStrip();
            timerProduction = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage_A.SuspendLayout();
            tabPage_B.SuspendLayout();
            tabPage_C.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, productionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(628, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quittereToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 20);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quittereToolStripMenuItem
            // 
            quittereToolStripMenuItem.Name = "quittereToolStripMenuItem";
            quittereToolStripMenuItem.Size = new Size(111, 22);
            quittereToolStripMenuItem.Text = "Quitter";
            // 
            // productionToolStripMenuItem
            // 
            productionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox1, arrêterToolStripMenuItem, continuerToolStripMenuItem });
            productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            productionToolStripMenuItem.Size = new Size(78, 20);
            productionToolStripMenuItem.Text = "Production";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem, bToolStripMenuItem, cToolStripMenuItem });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(127, 22);
            toolStripComboBox1.Text = "Démarrer";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(82, 22);
            aToolStripMenuItem.Text = "A";
            // 
            // bToolStripMenuItem
            // 
            bToolStripMenuItem.Name = "bToolStripMenuItem";
            bToolStripMenuItem.Size = new Size(82, 22);
            bToolStripMenuItem.Text = "B";
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(82, 22);
            cToolStripMenuItem.Text = "C";
            // 
            // arrêterToolStripMenuItem
            // 
            arrêterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem1, bToolStripMenuItem1, cToolStripMenuItem1 });
            arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
            arrêterToolStripMenuItem.Size = new Size(127, 22);
            arrêterToolStripMenuItem.Text = "Arrêter";
            // 
            // aToolStripMenuItem1
            // 
            aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            aToolStripMenuItem1.Size = new Size(82, 22);
            aToolStripMenuItem1.Text = "A";
            // 
            // bToolStripMenuItem1
            // 
            bToolStripMenuItem1.Name = "bToolStripMenuItem1";
            bToolStripMenuItem1.Size = new Size(82, 22);
            bToolStripMenuItem1.Text = "B";
            // 
            // cToolStripMenuItem1
            // 
            cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            cToolStripMenuItem1.Size = new Size(82, 22);
            cToolStripMenuItem1.Text = "C";
            // 
            // continuerToolStripMenuItem
            // 
            continuerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem2, bToolStripMenuItem2, cToolStripMenuItem2 });
            continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            continuerToolStripMenuItem.Size = new Size(127, 22);
            continuerToolStripMenuItem.Text = "Continuer";
            // 
            // aToolStripMenuItem2
            // 
            aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            aToolStripMenuItem2.Size = new Size(82, 22);
            aToolStripMenuItem2.Text = "A";
            // 
            // bToolStripMenuItem2
            // 
            bToolStripMenuItem2.Name = "bToolStripMenuItem2";
            bToolStripMenuItem2.Size = new Size(82, 22);
            bToolStripMenuItem2.Text = "B";
            // 
            // cToolStripMenuItem2
            // 
            cToolStripMenuItem2.Name = "cToolStripMenuItem2";
            cToolStripMenuItem2.Size = new Size(82, 22);
            cToolStripMenuItem2.Text = "C";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_A);
            tabControl1.Controls.Add(tabPage_B);
            tabControl1.Controls.Add(tabPage_C);
            tabControl1.Location = new Point(225, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(393, 163);
            tabControl1.TabIndex = 1;
            // 
            // tabPage_A
            // 
            tabPage_A.Controls.Add(textBox_ADefautDemarrage);
            tabPage_A.Controls.Add(textBox_ADefautHeure);
            tabPage_A.Controls.Add(textBox_ANbCaisses);
            tabPage_A.Controls.Add(label_ADefautDemarrage);
            tabPage_A.Controls.Add(label_ADefautHeure);
            tabPage_A.Controls.Add(label_ANbCaisses);
            tabPage_A.Location = new Point(4, 24);
            tabPage_A.Name = "tabPage_A";
            tabPage_A.Padding = new Padding(3);
            tabPage_A.Size = new Size(385, 135);
            tabPage_A.TabIndex = 0;
            tabPage_A.Text = "Type A";
            tabPage_A.UseVisualStyleBackColor = true;
            // 
            // textBox_ADefautDemarrage
            // 
            textBox_ADefautDemarrage.Enabled = false;
            textBox_ADefautDemarrage.Location = new Point(270, 104);
            textBox_ADefautDemarrage.Name = "textBox_ADefautDemarrage";
            textBox_ADefautDemarrage.Size = new Size(100, 23);
            textBox_ADefautDemarrage.TabIndex = 5;
            // 
            // textBox_ADefautHeure
            // 
            textBox_ADefautHeure.Enabled = false;
            textBox_ADefautHeure.Location = new Point(270, 57);
            textBox_ADefautHeure.Name = "textBox_ADefautHeure";
            textBox_ADefautHeure.Size = new Size(100, 23);
            textBox_ADefautHeure.TabIndex = 4;
            // 
            // textBox_ANbCaisses
            // 
            textBox_ANbCaisses.Enabled = false;
            textBox_ANbCaisses.Location = new Point(270, 10);
            textBox_ANbCaisses.Name = "textBox_ANbCaisses";
            textBox_ANbCaisses.Size = new Size(100, 23);
            textBox_ANbCaisses.TabIndex = 3;
            // 
            // label_ADefautDemarrage
            // 
            label_ADefautDemarrage.AutoSize = true;
            label_ADefautDemarrage.Location = new Point(6, 107);
            label_ADefautDemarrage.Name = "label_ADefautDemarrage";
            label_ADefautDemarrage.Size = new Size(166, 15);
            label_ADefautDemarrage.TabIndex = 2;
            label_ADefautDemarrage.Text = "Taux défaut depuis démarrage";
            // 
            // label_ADefautHeure
            // 
            label_ADefautHeure.AutoSize = true;
            label_ADefautHeure.Location = new Point(6, 60);
            label_ADefautHeure.Name = "label_ADefautHeure";
            label_ADefautHeure.Size = new Size(147, 15);
            label_ADefautHeure.TabIndex = 1;
            label_ADefautHeure.Text = "Taux défaut dernière heure";
            // 
            // label_ANbCaisses
            // 
            label_ANbCaisses.AutoSize = true;
            label_ANbCaisses.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ANbCaisses.Location = new Point(6, 13);
            label_ANbCaisses.Name = "label_ANbCaisses";
            label_ANbCaisses.Size = new Size(216, 15);
            label_ANbCaisses.TabIndex = 0;
            label_ANbCaisses.Text = "Nombre de caisses depuis le démarrage";
            // 
            // tabPage_B
            // 
            tabPage_B.Controls.Add(textBox_BDefautDemarrage);
            tabPage_B.Controls.Add(textBox_BDefautHeure);
            tabPage_B.Controls.Add(textBox_BNbCaisses);
            tabPage_B.Controls.Add(label_BDefautDemarrage);
            tabPage_B.Controls.Add(label_BDefautHeure);
            tabPage_B.Controls.Add(label_BNbCaisses);
            tabPage_B.Location = new Point(4, 24);
            tabPage_B.Name = "tabPage_B";
            tabPage_B.Padding = new Padding(3);
            tabPage_B.Size = new Size(385, 135);
            tabPage_B.TabIndex = 1;
            tabPage_B.Text = "Type B";
            tabPage_B.UseVisualStyleBackColor = true;
            // 
            // textBox_BDefautDemarrage
            // 
            textBox_BDefautDemarrage.Enabled = false;
            textBox_BDefautDemarrage.Location = new Point(270, 104);
            textBox_BDefautDemarrage.Name = "textBox_BDefautDemarrage";
            textBox_BDefautDemarrage.Size = new Size(100, 23);
            textBox_BDefautDemarrage.TabIndex = 6;
            // 
            // textBox_BDefautHeure
            // 
            textBox_BDefautHeure.Enabled = false;
            textBox_BDefautHeure.Location = new Point(270, 57);
            textBox_BDefautHeure.Name = "textBox_BDefautHeure";
            textBox_BDefautHeure.Size = new Size(100, 23);
            textBox_BDefautHeure.TabIndex = 5;
            // 
            // textBox_BNbCaisses
            // 
            textBox_BNbCaisses.Enabled = false;
            textBox_BNbCaisses.Location = new Point(270, 10);
            textBox_BNbCaisses.Name = "textBox_BNbCaisses";
            textBox_BNbCaisses.Size = new Size(100, 23);
            textBox_BNbCaisses.TabIndex = 4;
            // 
            // label_BDefautDemarrage
            // 
            label_BDefautDemarrage.AutoSize = true;
            label_BDefautDemarrage.Location = new Point(6, 107);
            label_BDefautDemarrage.Name = "label_BDefautDemarrage";
            label_BDefautDemarrage.Size = new Size(166, 15);
            label_BDefautDemarrage.TabIndex = 3;
            label_BDefautDemarrage.Text = "Taux défaut depuis démarrage";
            // 
            // label_BDefautHeure
            // 
            label_BDefautHeure.AutoSize = true;
            label_BDefautHeure.Location = new Point(6, 60);
            label_BDefautHeure.Name = "label_BDefautHeure";
            label_BDefautHeure.Size = new Size(147, 15);
            label_BDefautHeure.TabIndex = 2;
            label_BDefautHeure.Text = "Taux défaut dernière heure";
            // 
            // label_BNbCaisses
            // 
            label_BNbCaisses.AutoSize = true;
            label_BNbCaisses.Location = new Point(6, 13);
            label_BNbCaisses.Name = "label_BNbCaisses";
            label_BNbCaisses.Size = new Size(216, 15);
            label_BNbCaisses.TabIndex = 1;
            label_BNbCaisses.Text = "Nombre de caisses depuis le démarrage";
            // 
            // tabPage_C
            // 
            tabPage_C.Controls.Add(textBox_CDefautDemarrage);
            tabPage_C.Controls.Add(textBox_CDefautHeure);
            tabPage_C.Controls.Add(textBox_CNbCaisses);
            tabPage_C.Controls.Add(label_CDefautDemarrage);
            tabPage_C.Controls.Add(label_CDefautHeure);
            tabPage_C.Controls.Add(label_CNbCaisses);
            tabPage_C.Location = new Point(4, 24);
            tabPage_C.Name = "tabPage_C";
            tabPage_C.Padding = new Padding(3);
            tabPage_C.Size = new Size(385, 135);
            tabPage_C.TabIndex = 2;
            tabPage_C.Text = "Type C";
            tabPage_C.UseVisualStyleBackColor = true;
            // 
            // textBox_CDefautDemarrage
            // 
            textBox_CDefautDemarrage.Enabled = false;
            textBox_CDefautDemarrage.Location = new Point(270, 104);
            textBox_CDefautDemarrage.Name = "textBox_CDefautDemarrage";
            textBox_CDefautDemarrage.Size = new Size(100, 23);
            textBox_CDefautDemarrage.TabIndex = 7;
            // 
            // textBox_CDefautHeure
            // 
            textBox_CDefautHeure.Enabled = false;
            textBox_CDefautHeure.Location = new Point(270, 57);
            textBox_CDefautHeure.Name = "textBox_CDefautHeure";
            textBox_CDefautHeure.Size = new Size(100, 23);
            textBox_CDefautHeure.TabIndex = 6;
            // 
            // textBox_CNbCaisses
            // 
            textBox_CNbCaisses.Enabled = false;
            textBox_CNbCaisses.Location = new Point(270, 10);
            textBox_CNbCaisses.Name = "textBox_CNbCaisses";
            textBox_CNbCaisses.Size = new Size(100, 23);
            textBox_CNbCaisses.TabIndex = 5;
            // 
            // label_CDefautDemarrage
            // 
            label_CDefautDemarrage.AutoSize = true;
            label_CDefautDemarrage.Location = new Point(6, 107);
            label_CDefautDemarrage.Name = "label_CDefautDemarrage";
            label_CDefautDemarrage.Size = new Size(166, 15);
            label_CDefautDemarrage.TabIndex = 4;
            label_CDefautDemarrage.Text = "Taux défaut depuis démarrage";
            // 
            // label_CDefautHeure
            // 
            label_CDefautHeure.AutoSize = true;
            label_CDefautHeure.Location = new Point(6, 60);
            label_CDefautHeure.Name = "label_CDefautHeure";
            label_CDefautHeure.Size = new Size(147, 15);
            label_CDefautHeure.TabIndex = 3;
            label_CDefautHeure.Text = "Taux défaut dernière heure";
            // 
            // label_CNbCaisses
            // 
            label_CNbCaisses.AutoSize = true;
            label_CNbCaisses.Location = new Point(6, 13);
            label_CNbCaisses.Name = "label_CNbCaisses";
            label_CNbCaisses.Size = new Size(216, 15);
            label_CNbCaisses.TabIndex = 2;
            label_CNbCaisses.Text = "Nombre de caisses depuis le démarrage";
            // 
            // label_ProductionA
            // 
            label_ProductionA.AutoSize = true;
            label_ProductionA.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ProductionA.Location = new Point(224, 206);
            label_ProductionA.Name = "label_ProductionA";
            label_ProductionA.Size = new Size(131, 25);
            label_ProductionA.TabIndex = 2;
            label_ProductionA.Text = "Production A";
            // 
            // label_ProductionB
            // 
            label_ProductionB.AutoSize = true;
            label_ProductionB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ProductionB.Location = new Point(225, 276);
            label_ProductionB.Name = "label_ProductionB";
            label_ProductionB.Size = new Size(130, 25);
            label_ProductionB.TabIndex = 3;
            label_ProductionB.Text = "Production B";
            // 
            // label_ProductionC
            // 
            label_ProductionC.AutoSize = true;
            label_ProductionC.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ProductionC.Location = new Point(224, 346);
            label_ProductionC.Name = "label_ProductionC";
            label_ProductionC.Size = new Size(130, 25);
            label_ProductionC.TabIndex = 4;
            label_ProductionC.Text = "Production C";
            // 
            // progressBar_A
            // 
            progressBar_A.Location = new Point(361, 208);
            progressBar_A.Name = "progressBar_A";
            progressBar_A.Size = new Size(253, 23);
            progressBar_A.TabIndex = 5;
            // 
            // button_ADemarrer
            // 
            button_ADemarrer.BackColor = SystemColors.Control;
            button_ADemarrer.BackgroundImage = Properties.Resources.traffic_light_1_;
            button_ADemarrer.BackgroundImageLayout = ImageLayout.Zoom;
            button_ADemarrer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_ADemarrer.ImageAlign = ContentAlignment.TopCenter;
            button_ADemarrer.Location = new Point(12, 27);
            button_ADemarrer.Name = "button_ADemarrer";
            button_ADemarrer.Size = new Size(64, 112);
            button_ADemarrer.TabIndex = 6;
            button_ADemarrer.Text = "A";
            button_ADemarrer.TextAlign = ContentAlignment.BottomCenter;
            button_ADemarrer.UseVisualStyleBackColor = false;
            button_ADemarrer.Click += Button_ADemarrer_Click;
            // 
            // button_AArreter
            // 
            button_AArreter.BackColor = SystemColors.Control;
            button_AArreter.BackgroundImage = Properties.Resources.red_light;
            button_AArreter.BackgroundImageLayout = ImageLayout.Zoom;
            button_AArreter.Enabled = false;
            button_AArreter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_AArreter.ImageAlign = ContentAlignment.TopCenter;
            button_AArreter.Location = new Point(75, 27);
            button_AArreter.Name = "button_AArreter";
            button_AArreter.Size = new Size(64, 112);
            button_AArreter.TabIndex = 7;
            button_AArreter.Text = "A";
            button_AArreter.TextAlign = ContentAlignment.BottomCenter;
            button_AArreter.UseVisualStyleBackColor = false;
            button_AArreter.Click += Button_AArreter_Click;
            // 
            // button_AContinuer
            // 
            button_AContinuer.BackColor = SystemColors.Control;
            button_AContinuer.BackgroundImage = Properties.Resources.traffic_light;
            button_AContinuer.BackgroundImageLayout = ImageLayout.Zoom;
            button_AContinuer.Enabled = false;
            button_AContinuer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_AContinuer.ImageAlign = ContentAlignment.TopCenter;
            button_AContinuer.Location = new Point(138, 27);
            button_AContinuer.Name = "button_AContinuer";
            button_AContinuer.Size = new Size(64, 112);
            button_AContinuer.TabIndex = 8;
            button_AContinuer.Text = "A";
            button_AContinuer.TextAlign = ContentAlignment.BottomCenter;
            button_AContinuer.UseVisualStyleBackColor = false;
            button_AContinuer.Click += Button_AContinuer_Click;
            // 
            // button_BContinuer
            // 
            button_BContinuer.BackColor = SystemColors.Control;
            button_BContinuer.BackgroundImage = Properties.Resources.traffic_light;
            button_BContinuer.BackgroundImageLayout = ImageLayout.Zoom;
            button_BContinuer.Enabled = false;
            button_BContinuer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_BContinuer.ImageAlign = ContentAlignment.TopCenter;
            button_BContinuer.Location = new Point(138, 145);
            button_BContinuer.Name = "button_BContinuer";
            button_BContinuer.Size = new Size(64, 112);
            button_BContinuer.TabIndex = 11;
            button_BContinuer.Text = "B";
            button_BContinuer.TextAlign = ContentAlignment.BottomCenter;
            button_BContinuer.UseVisualStyleBackColor = false;
            button_BContinuer.Click += Button_BContinuer_Click;
            // 
            // button_BArreter
            // 
            button_BArreter.BackColor = SystemColors.Control;
            button_BArreter.BackgroundImage = Properties.Resources.red_light;
            button_BArreter.BackgroundImageLayout = ImageLayout.Zoom;
            button_BArreter.Enabled = false;
            button_BArreter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_BArreter.ImageAlign = ContentAlignment.TopCenter;
            button_BArreter.Location = new Point(75, 145);
            button_BArreter.Name = "button_BArreter";
            button_BArreter.Size = new Size(64, 112);
            button_BArreter.TabIndex = 10;
            button_BArreter.Text = "B";
            button_BArreter.TextAlign = ContentAlignment.BottomCenter;
            button_BArreter.UseVisualStyleBackColor = false;
            button_BArreter.Click += Button_BArreter_Click;
            // 
            // button_BDemarrer
            // 
            button_BDemarrer.BackColor = SystemColors.Control;
            button_BDemarrer.BackgroundImage = Properties.Resources.traffic_light_1_;
            button_BDemarrer.BackgroundImageLayout = ImageLayout.Zoom;
            button_BDemarrer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_BDemarrer.ImageAlign = ContentAlignment.TopCenter;
            button_BDemarrer.Location = new Point(12, 145);
            button_BDemarrer.Name = "button_BDemarrer";
            button_BDemarrer.Size = new Size(64, 112);
            button_BDemarrer.TabIndex = 9;
            button_BDemarrer.Text = "B";
            button_BDemarrer.TextAlign = ContentAlignment.BottomCenter;
            button_BDemarrer.UseVisualStyleBackColor = false;
            button_BDemarrer.Click += Button_BDemarrer_Click;
            // 
            // button_CContinuer
            // 
            button_CContinuer.BackColor = SystemColors.Control;
            button_CContinuer.BackgroundImage = Properties.Resources.traffic_light;
            button_CContinuer.BackgroundImageLayout = ImageLayout.Zoom;
            button_CContinuer.Enabled = false;
            button_CContinuer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_CContinuer.ImageAlign = ContentAlignment.TopCenter;
            button_CContinuer.Location = new Point(138, 263);
            button_CContinuer.Name = "button_CContinuer";
            button_CContinuer.Size = new Size(64, 112);
            button_CContinuer.TabIndex = 14;
            button_CContinuer.Text = "C";
            button_CContinuer.TextAlign = ContentAlignment.BottomCenter;
            button_CContinuer.UseVisualStyleBackColor = false;
            button_CContinuer.Click += Button_CContinuer_Click;
            // 
            // button_CArreter
            // 
            button_CArreter.BackColor = SystemColors.Control;
            button_CArreter.BackgroundImage = Properties.Resources.red_light;
            button_CArreter.BackgroundImageLayout = ImageLayout.Zoom;
            button_CArreter.Enabled = false;
            button_CArreter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_CArreter.ImageAlign = ContentAlignment.TopCenter;
            button_CArreter.Location = new Point(75, 263);
            button_CArreter.Name = "button_CArreter";
            button_CArreter.Size = new Size(64, 112);
            button_CArreter.TabIndex = 13;
            button_CArreter.Text = "C";
            button_CArreter.TextAlign = ContentAlignment.BottomCenter;
            button_CArreter.UseVisualStyleBackColor = false;
            button_CArreter.Click += Button_CArreter_Click;
            // 
            // button_CDemarrer
            // 
            button_CDemarrer.BackColor = SystemColors.Control;
            button_CDemarrer.BackgroundImage = Properties.Resources.traffic_light_1_;
            button_CDemarrer.BackgroundImageLayout = ImageLayout.Zoom;
            button_CDemarrer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_CDemarrer.ImageAlign = ContentAlignment.TopCenter;
            button_CDemarrer.Location = new Point(12, 263);
            button_CDemarrer.Name = "button_CDemarrer";
            button_CDemarrer.Size = new Size(64, 112);
            button_CDemarrer.TabIndex = 12;
            button_CDemarrer.Text = "C";
            button_CDemarrer.TextAlign = ContentAlignment.BottomCenter;
            button_CDemarrer.UseVisualStyleBackColor = false;
            button_CDemarrer.Click += Button_CDemarrer_Click;
            // 
            // progressBar_B
            // 
            progressBar_B.Location = new Point(361, 278);
            progressBar_B.Name = "progressBar_B";
            progressBar_B.Size = new Size(253, 23);
            progressBar_B.TabIndex = 15;
            // 
            // progressBar_C
            // 
            progressBar_C.Location = new Point(361, 348);
            progressBar_C.Name = "progressBar_C";
            progressBar_C.Size = new Size(253, 23);
            progressBar_C.TabIndex = 16;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 393);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(628, 22);
            statusStrip1.TabIndex = 17;
            statusStrip1.Text = "statusStrip1";
            // 
            // timerProduction
            // 
            timerProduction.Interval = 3600;
            timerProduction.Tick += TimerProduction_Tick;
            // 
            // Form_ToutEmbal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 415);
            Controls.Add(statusStrip1);
            Controls.Add(progressBar_C);
            Controls.Add(progressBar_B);
            Controls.Add(button_CContinuer);
            Controls.Add(button_CArreter);
            Controls.Add(button_CDemarrer);
            Controls.Add(button_BContinuer);
            Controls.Add(button_BArreter);
            Controls.Add(button_BDemarrer);
            Controls.Add(button_AContinuer);
            Controls.Add(button_AArreter);
            Controls.Add(button_ADemarrer);
            Controls.Add(progressBar_A);
            Controls.Add(label_ProductionC);
            Controls.Add(label_ProductionB);
            Controls.Add(label_ProductionA);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form_ToutEmbal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form_ToutEmbal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage_A.ResumeLayout(false);
            tabPage_A.PerformLayout();
            tabPage_B.ResumeLayout(false);
            tabPage_B.PerformLayout();
            tabPage_C.ResumeLayout(false);
            tabPage_C.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem quittereToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ToolStripMenuItem toolStripComboBox1;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem bToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem arrêterToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem1;
        private ToolStripMenuItem bToolStripMenuItem1;
        private ToolStripMenuItem cToolStripMenuItem1;
        private ToolStripMenuItem continuerToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem2;
        private ToolStripMenuItem bToolStripMenuItem2;
        private ToolStripMenuItem cToolStripMenuItem2;
        private TabControl tabControl1;
        private TabPage tabPage_A;
        private TabPage tabPage_B;
        private TabPage tabPage_C;
        private Label label_ADefautHeure;
        private Label label_ANbCaisses;
        private Label label_ADefautDemarrage;
        private Label label_BDefautDemarrage;
        private Label label_BDefautHeure;
        private Label label_BNbCaisses;
        private Label label_CDefautDemarrage;
        private Label label_CDefautHeure;
        private Label label_CNbCaisses;
        private Label label_ProductionA;
        private Label label_ProductionB;
        private Label label_ProductionC;
        private ProgressBar progressBar_A;
        private Button button_ADemarrer;
        private Button button_AArreter;
        private Button button_AContinuer;
        private Button button_BContinuer;
        private Button button_BArreter;
        private Button button_BDemarrer;
        private Button button_CContinuer;
        private Button button_CArreter;
        private Button button_CDemarrer;
        private ProgressBar progressBar_B;
        private ProgressBar progressBar_C;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timerProduction;
        private TextBox textBox_ADefautDemarrage;
        private TextBox textBox_ADefautHeure;
        private TextBox textBox_ANbCaisses;
        private TextBox textBox_BNbCaisses;
        private TextBox textBox_CNbCaisses;
        private TextBox textBox_BDefautHeure;
        private TextBox textBox_CDefautHeure;
        private TextBox textBox_BDefautDemarrage;
        private TextBox textBox_CDefautDemarrage;
    }
}
