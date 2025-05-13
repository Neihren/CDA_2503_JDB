using Articles;
namespace AppClient_Disquetuveux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> inventaire = new List<Article>();
            inventaire.Add(new Article("Livre", "Les possédés", "Dovstoieski", 12.00m, "Seuil", ""));
            inventaire.Add(new Article("Livre", "Guerre et paix", "Tolstoi", 20.00m, "Dupuis", ""));
            inventaire.Add(new Article("CD", "Full sentimental", "Souchon", 17.00m, "", "Mercury"));
            inventaire.Add(new Article("CD", "Riders on the storm", "Morrison", 18.00m, "", "Universal"));
        }
    }
}
