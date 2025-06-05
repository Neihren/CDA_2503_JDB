namespace ClassLibrary_Point
{
    public class Point
    {
        private float abscisse;
        private float ordonnee;

        public Point(float abscisse, float ordonnee)
        {
            this.abscisse = abscisse;
            this.ordonnee = ordonnee;
        }

        public Point() : this(0, 0)
        {
        }

        public Point(Point pointACloner) : this(pointACloner.abscisse, pointACloner.ordonnee)
        {

        }

        public override string ToString()
        {
            return base.ToString() + $"[abscisse : {this.abscisse}, ordonnee : {this.ordonnee}";
        }

        public void Deplacer(float nouvelleAbscisse, float nouvelleOrdonnee)
        {
            this.abscisse = nouvelleAbscisse;
            this.ordonnee = nouvelleOrdonnee;
        }

        public Point SymetrieOrdonnee()
        {
            return new Point(-this.abscisse, this.ordonnee);
        }

        public Point SymetrieAbscisse()
        {
            return new Point(this.abscisse, -this.ordonnee);
        }

        public Point SymetrieOrigine()
        {
            Point p = new Point(this);
            p = p.SymetrieAbscisse();
            p = p.SymetrieOrdonnee();
            return p;
        }

        public Point SymetrieBissectrice()
        {
            return new Point(this.ordonnee, this.abscisse);
        }
    }
}
