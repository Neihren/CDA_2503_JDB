namespace WF_Figure
{
    public partial class Form_Figure : Form
    {
        public Form_Figure()
        {
            InitializeComponent();
            Rectangle rectangle1 = new(10, 10, 100, 300);
            Pen pen1 = new(Color.Blue);
            //drawOptions = 2;
            Invalidate();
        }
    }
}
