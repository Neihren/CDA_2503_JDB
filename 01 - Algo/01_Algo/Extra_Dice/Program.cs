using System.Text.Json;
using System.Text.Json.Serialization;

namespace Extra_Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = JsonFileReader.Read<Item>("UXz9eAEk.json");

        }
    }

    public static class JsonFileReader
    {
        public static T Read<T>(string filepath)
        {
            string text = File.ReadAllText(filepath);
            return JsonSerializer.Deserialize<T>(text);
        }
    }

    public class Item
    {
        public int player;
        public int diceOne;
        public int diceTwo;
    }
}
