using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace DisquetuveuxApp
{
    public partial class Form1 : Form
    {
        private ArrayList articles = new ArrayList();
        private bool modeAjout = false;

        public Form1()
        {
            InitializeComponent();
            InitialiserArticles();
            RafraichirComboBox();
            btnConfirmer.Visible = false;
        }

        private void InitialiserArticles()
        {
            articles.Add(new Livre("Les possédés", "Dovstoieski", 12.00m, "Seuil"));
            articles.Add(new Livre("Guerre et paix", "Tolstoi", 20.00m, "Dupuis"));
            articles.Add(new CD("Full sentimental", "Souchon", 17.00m, "Mercury"));
            articles.Add(new CD("Riders on the storm", "Morrison", 18.00m, "Universal"));
        }

        private void RafraichirComboBox()
        {
            comboBoxArticles.Items.Clear();
            foreach (var a in articles.Cast<Article>().OrderBy(a => a.Titre))
            {
                comboBoxArticles.Items.Add(a.Titre);
            }
        }

        private void comboBoxArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string titre = comboBoxArticles.SelectedItem.ToString();
            var article = articles.Cast<Article>().FirstOrDefault(a => a.Titre == titre);
            if (article != null)
            {
                txtTitre.Text = article.Titre;
                txtPrix.Text = article.Prix.ToString();

                if (article is Livre livre)
                {
                    txtAuteur.Text = livre.Auteur;
                    txtEditeur.Text = livre.Editeur;
                    lblAuteur.Text = "Auteur";
                    lblEditeur.Text = "Éditeur";
                }
                else if (article is CD cd)
                {
                    txtAuteur.Text = cd.Artiste;
                    txtEditeur.Text = cd.Label;
                    lblAuteur.Text = "Artiste";
                    lblEditeur.Text = "Label";
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (comboBoxArticles.SelectedItem == null) return;

            string titre = comboBoxArticles.SelectedItem.ToString();
            var article = articles.Cast<Article>().FirstOrDefault(a => a.Titre == titre);
            if (article == null) return;

            article.Titre = txtTitre.Text;
            article.Prix = decimal.Parse(txtPrix.Text);

            if (article is Livre livre)
            {
                livre.Auteur = txtAuteur.Text;
                livre.Editeur = txtEditeur.Text;
            }
            else if (article is CD cd)
            {
                cd.Artiste = txtAuteur.Text;
                cd.Label = txtEditeur.Text;
            }

            RafraichirComboBox();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            txtTitre.Clear();
            txtAuteur.Clear();
            txtPrix.Clear();
            txtEditeur.Clear();
            lblAuteur.Text = "Auteur/Artiste";
            lblEditeur.Text = "Éditeur/Label";
            modeAjout = true;
            btnConfirmer.Visible = true;
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrix.Text, out decimal prix)) return;

            // Heuristique simple : si "Label" ou "Artiste", on considère que c’est un CD
            if (lblEditeur.Text == "Label" || txtEditeur.Text.Contains("Universal") || txtAuteur.Text.Contains("Morrison"))
            {
                articles.Add(new CD(txtTitre.Text, txtAuteur.Text, prix, txtEditeur.Text));
            }
            else
            {
                articles.Add(new Livre(txtTitre.Text, txtAuteur.Text, prix, txtEditeur.Text));
            }

            modeAjout = false;
            btnConfirmer.Visible = false;
            RafraichirComboBox();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public abstract class Article
    {
        public string Titre { get; set; }
        public decimal Prix { get; set; }

        public Article(string titre, decimal prix)
        {
            Titre = titre;
            Prix = prix;
        }

        public abstract string GetDetails();
    }

    public class Livre : Article
    {
        public string Auteur { get; set; }
        public string Editeur { get; set; }

        public Livre(string titre, string auteur, decimal prix, string editeur)
            : base(titre, prix)
        {
            Auteur = auteur;
            Editeur = editeur;
        }

        public override string GetDetails() => $"Livre: {Titre}, {Auteur}, {Prix}€, {Editeur}";
    }

    public class CD : Article
    {
        public string Artiste { get; set; }
        public string Label { get; set; }

        public CD(string titre, string artiste, decimal prix, string label)
            : base(titre, prix)
        {
            Artiste = artiste;
            Label = label;
        }

        public override string GetDetails() => $"CD: {Titre}, {Artiste}, {Prix}€, {Label}";
    }
}