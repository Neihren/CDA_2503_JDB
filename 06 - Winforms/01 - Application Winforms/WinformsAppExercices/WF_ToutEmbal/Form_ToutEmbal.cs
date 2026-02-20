using System.Drawing.Imaging;
using CL_Production;

namespace WF_ToutEmbal
{
    public partial class Form_ToutEmbal : Form
    {
        private const int ObjA = 10000;
        private const int CadenceA = 1000;
        private const int ObjB = 25000;
        private const int CadenceB = 5000;
        private const int ObjC = 120000;
        private const int CadenceC = 10000;
        private Image greenLight;
        private Image redLight;
        private Image orangeLight;
        private Image disabledLight;
        private Production prodA;
        private Production prodB;
        private Production prodC;

        public Form_ToutEmbal()
        {
            InitializeComponent();
            this.greenLight = Properties.Resources.traffic_light_1_;
            this.redLight = Properties.Resources.red_light;
            this.orangeLight = Properties.Resources.traffic_light;
            this.disabledLight = Properties.Resources.traffic_light_2_;
            this.prodA = new Production(CadenceA, ObjA);
            this.prodB = new Production(CadenceB, ObjB);
            this.prodC = new Production(CadenceC, ObjC);
            this.progressBar_A.Maximum = ObjA;
            this.progressBar_B.Maximum = ObjB;
            this.progressBar_C.Maximum = ObjC;
            this.prodA.ChangementProduction += SurChangementProduction;
            this.prodB.ChangementProduction += SurChangementProduction;
            this.prodC.ChangementProduction += SurChangementProduction;
        }
        private void SurChangementProduction(Production p)
        {

                if (this.InvokeRequired)
                {
                    try
                    {
                        this.Invoke(new Action(() => SurChangementProduction(p)));
                        //this.Invoke(new Production.DelegateProduction(SurChangementProduction),new object[] { p });
                    }
                    catch (ObjectDisposedException e)
                    {
                        //fin du programme, retard de travail
                    }
                }
                else
                {
                    ActualiserAffichage();
                    if (p.EtatProduction == EnumProduction.Termine)
                    {
                        string nomProduction = "";
                        if (p == prodA)
                        {
                            nomProduction = "A";
                        }
                        else if (p == prodB)
                        {
                            nomProduction = "B";
                        }
                        else if (p == prodC)
                        {
                            nomProduction = "C";
                        }
                        MessageBox.Show($"Production {nomProduction} terminée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            
        }

        private void ActualiserAffichage()
        {
            this.progressBar_A.Value = prodA.NbCaissesProduites;
            this.textBox_ANbCaisses.Text = prodA.NbCaissesProduites.ToString();
            this.textBox_ADefautHeure.Text = prodA.TauxDefautHeure.ToString("0.0000");
            this.textBox_ADefautDemarrage.Text = prodA.TauxDefautCumule.ToString("0.0000");
            ActualiserBoutons(prodA, button_ADemarrer, button_AArreter, button_AContinuer);

            this.progressBar_B.Value = prodB.NbCaissesProduites;
            this.textBox_BNbCaisses.Text = prodB.NbCaissesProduites.ToString();
            this.textBox_BDefautHeure.Text = prodB.TauxDefautHeure.ToString("0.0000");
            this.textBox_BDefautDemarrage.Text = prodB.TauxDefautCumule.ToString("0.0000");
            ActualiserBoutons(prodB, button_BDemarrer, button_BArreter, button_BContinuer);

            this.progressBar_C.Value = prodC.NbCaissesProduites;
            this.textBox_CNbCaisses.Text = prodC.NbCaissesProduites.ToString();
            this.textBox_CDefautHeure.Text = prodC.TauxDefautHeure.ToString("0.0000");
            this.textBox_CDefautDemarrage.Text = prodC.TauxDefautCumule.ToString("0.0000");
            ActualiserBoutons(prodC, button_CDemarrer, button_CArreter, button_CContinuer);
        }

        private void ActualiserBoutons(Production p, Button btnDemarrer, Button btnArreter, Button btnContinuer)
        {
            switch (p.EtatProduction)
            {
                case EnumProduction.Demarre:
                case EnumProduction.Redemarre:
                    btnDemarrer.Enabled = false;
                    btnDemarrer.BackgroundImage = disabledLight;
                    btnArreter.Enabled = true;
                    btnArreter.BackgroundImage = redLight;
                    btnContinuer.Enabled = false;
                    btnContinuer.BackgroundImage = disabledLight;
                    break;
                case EnumProduction.Suspendu:
                    btnDemarrer.Enabled = true;
                    btnDemarrer.BackgroundImage = greenLight;
                    btnArreter.Enabled = false;
                    btnArreter.BackgroundImage = disabledLight;
                    btnContinuer.Enabled = true;
                    btnContinuer.BackgroundImage = orangeLight;
                    break;
                default:
                    btnDemarrer.Enabled = true;
                    btnDemarrer.BackgroundImage = greenLight;
                    btnArreter.Enabled = false;
                    btnArreter.BackgroundImage = disabledLight;
                    btnContinuer.Enabled = false;
                    btnContinuer.BackgroundImage = disabledLight;
                    break;
            }
        }

        private void TimerProduction_Tick(object sender, EventArgs e)
        {
            if (this.prodA.EtatProduction == EnumProduction.Demarre || this.prodA.EtatProduction == EnumProduction.Redemarre)
            {
                //this.prodA.ProduireCaisse();
                if (this.prodA.NbCaissesProduites == this.prodA.ObjectifProduction)
                {
                    this.prodA.EtatProduction = EnumProduction.Termine;
                    MessageBox.Show("Production A terminée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (this.prodB.EtatProduction == EnumProduction.Demarre || this.prodB.EtatProduction == EnumProduction.Redemarre)
            {
                for (int i = 0; i < 5; i++)
                {
                    //this.prodB.ProduireCaisse();
                }
                if (this.prodB.NbCaissesProduites >= this.prodB.ObjectifProduction)
                {
                    this.prodB.EtatProduction = EnumProduction.Termine;
                    MessageBox.Show("Production B terminée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (this.prodC.EtatProduction == EnumProduction.Demarre || this.prodC.EtatProduction == EnumProduction.Redemarre)
            {
                for (int i = 0; i < 10; i++)
                {
                    //this.prodC.ProduireCaisse();
                }
                if (this.prodC.NbCaissesProduites >= this.prodC.ObjectifProduction)
                {
                    this.prodC.EtatProduction = EnumProduction.Termine;
                    MessageBox.Show("Production C terminée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Button_ADemarrer_Click(object sender, EventArgs e)
        {
            prodA.Demarrer();
            ActualiserAffichage();
        }

        private void Button_AArreter_Click(object sender, EventArgs e)
        {
            prodA.Arreter();
            ActualiserAffichage();
        }

        private void Button_AContinuer_Click(object sender, EventArgs e)
        {
            prodA.Continuer();
            ActualiserAffichage();
        }

        private void Button_BDemarrer_Click(object sender, EventArgs e)
        {
            prodB.Demarrer();
            ActualiserAffichage();
        }

        private void Button_BArreter_Click(object sender, EventArgs e)
        {
            prodB.Arreter();
            ActualiserAffichage();
        }

        private void Button_BContinuer_Click(object sender, EventArgs e)
        {
            prodB.Continuer();
            ActualiserAffichage();
        }

        private void Button_CDemarrer_Click(object sender, EventArgs e)
        {
            prodC.Demarrer();
            ActualiserAffichage();
        }

        private void Button_CArreter_Click(object sender, EventArgs e)
        {
            prodC.Arreter();
            ActualiserAffichage();
        }

        private void Button_CContinuer_Click(object sender, EventArgs e)
        {
            prodC.Continuer();
            ActualiserAffichage();
        }

        private void Form_ToutEmbal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.prodA.Arreter();
            this.prodB.Arreter();
            this.prodC.Arreter();
            this.prodA.ChangementProduction -= SurChangementProduction;
            this.prodB.ChangementProduction -= SurChangementProduction;
            this.prodC.ChangementProduction -= SurChangementProduction;
        }
    }
}
