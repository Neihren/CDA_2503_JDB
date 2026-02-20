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
using CL_Pays;

namespace WF_ListeCombo
{
    public partial class FormListeCombo : Form
    {
        private readonly List<Pays> listePaysSource;
        private readonly List<Pays> listePaysCible;
        private static int compteur = 0;

        public FormListeCombo()
        {
            InitializeComponent();
            compteur++;
            this.Text = "Les listes N°" + compteur;
            listePaysSource = [new Pays("France"), new Pays("Belgique"), new Pays("Allemagne"), new Pays("Japon"), new Pays("Portugal"), new Pays("Grèce")];
            ComboBoxRefesh();
            listePaysCible = [new Pays("Bulgarie"), new Pays("Espagne")];
            ListBoxRefesh();
        }

        private void ComboBoxRefesh()
        {
            comboBox_Source.Items.Clear();
            if (listePaysSource.Count == 0)
            {
                button_Add.Enabled = false;
                button_AddAll.Enabled = false;
            }
            else
            {
                foreach (Pays pays in listePaysSource)
                {
                    comboBox_Source.Items.Add(pays.Nom);
                }
                button_AddAll.Enabled = true;
            }
        }

        private void ListBoxRefesh()
        {
            listBox_Cible.Items.Clear();
            button_MoveDown.Enabled = false;
            button_MoveUp.Enabled = false;
            button_Remove.Enabled = false;
            if (listePaysCible.Count == 0)
            {
                button_Remove.Enabled = false;
                button_RemoveAll.Enabled = false;
            }
            else
            {
                foreach (Pays pays in listePaysCible)
                {
                    listBox_Cible.Items.Add(pays.Nom);
                }
                button_RemoveAll.Enabled = true;
            }
        }

        private static void Swap(List<Pays> liste, int index1, int index2)
        {
            (liste[index2], liste[index1]) = (liste[index1], liste[index2]);
        }

        private void ListBox_Cible_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Remove.Enabled = true;
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
            else if (listBox_Cible.SelectedIndex == -1)
            {
                button_MoveDown.Enabled = false;
                button_MoveUp.Enabled = false;
                button_Remove.Enabled = false;
            }
            else
            {
                button_MoveUp.Enabled = true;
                button_MoveDown.Enabled = true;
            }
        }

        private void ComboBox_Source_SelectionChangeCommitted(object sender, EventArgs e)
        {
            button_Add.Enabled = true;
        }

        private void ComboBox_Source_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBox_Source.Text) || comboBox_Source.SelectedIndex == -1)
            {
                button_Add.Enabled = false;
            }
        }

        private void ComboBox_Source_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    string texte = comboBox_Source.Text.Trim();

                    if (String.IsNullOrWhiteSpace(comboBox_Source.Text))
                    {
                        errorProviderExist.SetError(label_Source, "Vous devez saisir un nom de pays pour l'ajouter.");
                        return;
                    }

                    bool existeDeja = false;

                    foreach (Pays pays in listePaysSource)
                    {
                        if (string.Equals(pays.Nom, texte, StringComparison.OrdinalIgnoreCase))
                        {
                            existeDeja = true;
                            break;
                        }
                    }

                    foreach (Pays pays in listePaysCible)
                    {
                        if (string.Equals(pays.Nom, texte, StringComparison.OrdinalIgnoreCase))
                        {
                            existeDeja = true;
                            break;
                        }
                    }

                    if (existeDeja)
                    {
                        errorProviderExist.SetError(label_Source, $"{texte} fait déjà partie de la liste.");
                    }
                    else
                    {
                        errorProviderExist.Clear();
                        listePaysSource.Add(new Pays(texte));
                        comboBox_Source.Text = null;
                        ComboBoxRefesh();
                    }
                }
            }
            catch (Exception)
            {
                errorProviderExist.SetError(label_Source, "Erreur de Saisie");
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

        private void Button_Add_Click(object sender, EventArgs e)
        {
            int index = comboBox_Source.SelectedIndex;
            listePaysCible.Add(listePaysSource[index]);
            listePaysSource.RemoveAt(index);
            ComboBoxRefesh();
            ListBoxRefesh();
            if (listePaysSource.Count >= index + 1)
            {
                comboBox_Source.SelectedIndex = index;
            }
            else if (listePaysSource.Count > 0)
            {
                comboBox_Source.SelectedIndex = listePaysSource.Count - 1;
            }
            else
            {
                 comboBox_Source.Text = null;
            }
        }

        private void Button_AddAll_Click(object sender, EventArgs e)
        {
            foreach (Pays pays in listePaysSource)
            {
                listePaysCible.Add(pays);
            }
            listePaysSource.Clear();
            ComboBoxRefesh();
            ListBoxRefesh();
            comboBox_Source.Text = null;
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            int index = listBox_Cible.SelectedIndex;
            listePaysSource.Add(listePaysCible[index]);
            listePaysCible.RemoveAt(index);
            ComboBoxRefesh();
            ListBoxRefesh();
            if (listePaysCible.Count >= index + 1)
            {
                listBox_Cible.SelectedIndex = index;
            }
            else if (listePaysCible.Count > 0)
            {
                listBox_Cible.SelectedIndex = listePaysCible.Count - 1;
            }
        }

        private void Button_RemoveAll_Click(object sender, EventArgs e)
        {
            foreach (Pays pays in listePaysCible)
            {
                listePaysSource.Add(pays);
            }
            listePaysCible.Clear();
            ComboBoxRefesh();
            ListBoxRefesh();
        }
    }
}
