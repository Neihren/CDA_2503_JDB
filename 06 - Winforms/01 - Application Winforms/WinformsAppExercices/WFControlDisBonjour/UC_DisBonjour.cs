using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFControlDisBonjour
{
    public partial class UC_DisBonjour : UserControl
    {
        private string nomDestinataire;
        public UC_DisBonjour()
        {
            InitializeComponent();
        }
        //public string NomDestinataire
        //{ 
        //    get { return nomDestinataire; }
        //    set { nomDestinataire = value; }
        //}

        //public string NomDestinataire { get; set; }


        public string NomDestinataire { get => nomDestinataire; set => nomDestinataire = value; }

        private void textBoxRepNom_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxRepNom.Text.Equals(NomDestinataire))
            {
                this.BackColor = Color.Beige;
                //genere l'evenement si qq s'est enregistré sur l'évenement
                if (NomIdentified != null)
                {
                    NomIdentified(this, new EventArgs());
                }
            }
        }
        public event EventHandler? NomIdentified;
    }
}
