namespace Articles
{
    public class Article
    {
        private string type { get; set; }
        private string title { get; set; }
        private string author { get; set; }
        private decimal price { get; set; }
        private string editor { get; set; }
        private string label { get; set; }

        public Article (string type, string title, string author, decimal price, string editor, string label)
        {
            this.type = type;
            this.title = title;
            this.author = author;
            this.price = price;
            this.editor = editor;
            this.label = label;
        }

        public string ToString()
        {
            return ($"Article [ type : {this.type}, title : {this.title}, author : {this.author}, price : {this.price}, editor : {this.editor}, label : {this.label}"); 
        }
    }
}
