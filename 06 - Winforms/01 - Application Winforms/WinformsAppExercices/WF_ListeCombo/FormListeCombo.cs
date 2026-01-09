using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_ListeCombo
{
    public partial class FormListeCombo : Form
    {
        private List<string> listePaysSource;
        private List<string> listePaysCible;

        public FormListeCombo()
        {
            InitializeComponent();
            listePaysSource = ["France", "Belgique", "Allemagne", "Japon", "Portugal", "Grèce"];
            ComboBoxRefesh();
            listePaysCible = [/*"Bulgarie", "Espagne", "Belgique", "Allemagne", "Japon", "Portugal", "Grèce"*/];
            ListBoxRefesh();
        }

        private void ComboBox_Source_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    if (listePaysSource.Contains(comboBox_Source.Text) || listePaysCible.Contains(comboBox_Source.Text))
                    {
                        errorProviderExist.SetError(label_Source, $"{comboBox_Source.Text} fait déjà partie d'une liste");
                    }
                    else
                    {
                        listePaysSource.Add(comboBox_Source.Text);
                        ComboBoxRefesh();
                        comboBox_Source.Text = null;
                    }
                }
            }
            catch (Exception)
            {
                errorProviderExist.SetError(label_Source, "Erreur de Saisie");
            }
        }

        private void listBox_Cible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Cible.SelectedIndex == 0)
            {
                button_MoveUp.Enabled = false;
                button_MoveDown.Enabled = true;
            }
            else if (listBox_Cible.SelectedIndex == listBox_Cible.Items.Count - 1)
            {
                button_MoveDown.Enabled = false;
                button_MoveUp.Enabled = true;
            }
            else
            {
                button_MoveUp.Enabled = true;
                button_MoveDown.Enabled = true;
            }
        }

        private void Button_MoveUp_Click(object sender, EventArgs e)
        {
            int selected = listBox_Cible.SelectedIndex;
            Swap(listePaysCible, selected, selected - 1);
            ListBoxRefesh();
            listBox_Cible.SelectedIndex = selected - 1;
        }

        private void Button_MoveDown_Click(object sender, EventArgs e)
        {
            int selected = listBox_Cible.SelectedIndex;
            Swap(listePaysCible, selected, selected + 1);
            ListBoxRefesh();
            listBox_Cible.SelectedIndex = selected + 1;
        }

        private static void Swap(List<string> liste, int index1, int index2)
        {
            string temp = liste[index1];
            liste[index1] = liste[index2];
            liste[index2] = temp;
        }

        private void ComboBoxRefesh()
        {
            comboBox_Source.Items.Clear();
            foreach (string s in listePaysSource)
            {
                comboBox_Source.Items.Add(s);
            }
        }

        private void ListBoxRefesh()
        {
            listBox_Cible.Items.Clear();
            if (listePaysCible.Count == 0)
            {
                button_MoveDown.Enabled = false;
                button_MoveUp.Enabled = false;
                button_Remove.Enabled = false;
                button_RemoveAll.Enabled = false;
            }
            else
            {
                foreach (string s in listePaysCible)
                {
                    listBox_Cible.Items.Add(s);
                }
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //comboBox_Source.Text
        }
    }
}
