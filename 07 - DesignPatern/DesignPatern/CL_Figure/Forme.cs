namespace CL_Figure
{
    public abstract class Forme 
    {
        protected int x;
        protected int y;

        public Forme(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X { get => x; }
        public int Y { get => y; }

        public abstract void Accept(IVisiteurDeForme visiteur);
    }
}
