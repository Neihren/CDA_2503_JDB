namespace CL_Item
{
    public class Item
    {
        private string text;
        private int index;

        public Item(string text, int index)
        {
            this.text = text;
            this.index = index;
        }

        public string Text { get => text; set => text = value; }
        public int Index { get => index; set => index = value; }
    }

}
