using CL_Item;
using System.Windows.Forms.VisualStyles;

namespace WF_Liste
{
    public partial class Form_Liste : Form
    {
        private List<Item> listeItem;

        public Form_Liste()
        {
            InitializeComponent();
            listeItem = new List<Item>();
        }

        private void Button_Ajout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_NouvelElement.Text))
            {
                return;
            }
            foreach (var item in listeItem)
            {
                if (item.Text == textBox_NouvelElement.Text)
                {
                    errorProviderNew.SetError(textBox_NouvelElement, "Fait déjà parti de la liste.");
                    textBox_NouvelElement.Focus();
                    return;
                }
            }
            listeItem.Add(new Item(textBox_NouvelElement.Text, listeItem.Count));
            listBox_Liste.Items.Add(listeItem[listeItem.Count - 1].Text);
            textBox_NouvelElement.Clear();
            textBox_NouvelElement.Focus();
            textBox_ItemCount.Text = listeItem.Count.ToString();
            button_Selectionner.Enabled = true;
            button_Vider.Enabled = true;
        }

        private void Button_Selectionner_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = int.Parse(textBox_IndexElement.Text);
                if (selected < 0 || selected > int.Parse(textBox_ItemCount.Text) - 1)
                {
                    textBox_IndexElement.Focus();
                    errorProviderIndex.SetError(textBox_IndexElement, $"Choisir un numéro d'index compris entre 0 et {int.Parse(textBox_ItemCount.Text) - 1}");
                }
                else
                {
                    listBox_Liste.SelectedIndex = selected;
                }
            }
            catch
            {
                textBox_IndexElement.Focus();
                errorProviderIndex.SetError(textBox_IndexElement, "Choisir un numéro d'index valide");
            }
        }

        private void Button_Vider_Click(object sender, EventArgs e)
        {
            textBox_IndexElement.Clear();
            listBox_Liste.Items.Clear();
            listeItem.Clear();
            textBox_ItemCount.Clear();
            textBox_SelectedIndex.Clear();
            textBox_SelectedText.Clear();
            button_Selectionner.Enabled = false;
            button_Vider.Enabled = false;
        }

        private void ListBox_Liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_SelectedIndex.Text = listeItem[listBox_Liste.SelectedIndex].Index.ToString();
            textBox_IndexElement.Text = listeItem[listBox_Liste.SelectedIndex].Index.ToString();
            textBox_SelectedText.Text = listeItem[listBox_Liste.SelectedIndex].Text;
        }

        private void TextBox_NouvelElement_Leave(object sender, EventArgs e)
        {
            errorProviderNew.Clear();
        }

        private void TextBox_IndexElement_Leave(object sender, EventArgs e)
        {
            errorProviderIndex.Clear();
        }
    }
}
