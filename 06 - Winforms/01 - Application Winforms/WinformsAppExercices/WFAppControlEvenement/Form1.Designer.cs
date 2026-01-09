namespace WFAppControlEvenement
{
    partial class Form1
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
            uC_DisBonjourTest = new WFControlDisBonjour.UC_DisBonjour();
            uC_DisBonjour1 = new WFControlDisBonjour.UC_DisBonjour();
            uC_DisBonjour2 = new WFControlDisBonjour.UC_DisBonjour();
            SuspendLayout();
            // 
            // uC_DisBonjourTest
            // 
            uC_DisBonjourTest.Location = new Point(27, 32);
            uC_DisBonjourTest.Name = "uC_DisBonjourTest";
            uC_DisBonjourTest.NomDestinataire = "Ludo";
            uC_DisBonjourTest.Size = new Size(272, 99);
            uC_DisBonjourTest.TabIndex = 0;
            uC_DisBonjourTest.NomIdentified += uC_DisBonjourTest_NomIdentified;
            // 
            // uC_DisBonjour1
            // 
            uC_DisBonjour1.Location = new Point(27, 137);
            uC_DisBonjour1.Name = "uC_DisBonjour1";
            uC_DisBonjour1.NomDestinataire = "Hülya";
            uC_DisBonjour1.Size = new Size(272, 99);
            uC_DisBonjour1.TabIndex = 1;
            // 
            // uC_DisBonjour2
            // 
            uC_DisBonjour2.Location = new Point(27, 255);
            uC_DisBonjour2.Name = "uC_DisBonjour2";
            uC_DisBonjour2.NomDestinataire = "Jessy";
            uC_DisBonjour2.Size = new Size(272, 99);
            uC_DisBonjour2.TabIndex = 2;
            uC_DisBonjour2.NomIdentified += uC_DisBonjour2_NomIdentified;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uC_DisBonjour2);
            Controls.Add(uC_DisBonjour1);
            Controls.Add(uC_DisBonjourTest);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private WFControlDisBonjour.UC_DisBonjour uC_DisBonjourTest;
        private WFControlDisBonjour.UC_DisBonjour uC_DisBonjour1;
        private WFControlDisBonjour.UC_DisBonjour uC_DisBonjour2;
    }
}
