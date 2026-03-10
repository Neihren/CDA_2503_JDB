namespace CL_Expression
{
    public abstract class Expression
    {
        public abstract int Evalue();

        public string Formate()
        {
            return $"{this.ToString()} = {this.Evalue()}";
        }
    }
}
