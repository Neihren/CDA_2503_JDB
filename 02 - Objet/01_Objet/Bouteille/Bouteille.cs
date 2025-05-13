namespace Bouteilles
{
    public class Bouteille
    {
        private bool isOpen { get; set; }
        private decimal capacityInL { get; set; }
        private decimal amountFilledInL { get; set; }

        public Bouteille()
            : this(false, 0, 0)
        {

        }

        public Bouteille(bool isOpen, decimal capacityInL, decimal amountFilledInL)
        {
            if (amountFilledInL < 0)
            {
                throw new ArgumentException("\nImpossible de mettre une valeur négative\n", nameof(amountFilledInL));
            }
            else if (amountFilledInL > capacityInL)
            {
                throw new ArgumentException("\nImpossible de remplir la bouteille plus que sa capacité\n", nameof(amountFilledInL));
            }
            else if (capacityInL < 0)
            {
                throw new ArgumentException("\nImpossible de mettre une valeur négative\n", nameof(amountFilledInL));
            }
            this.isOpen = isOpen;
            this.capacityInL = capacityInL;
            this.amountFilledInL = amountFilledInL;
        }

        public Bouteille(Bouteille bouteilleToClone)
            : this(bouteilleToClone.isOpen, bouteilleToClone.capacityInL, bouteilleToClone.amountFilledInL)
        {

        }

        public override string ToString()
        {
            return $"Bouteille[ isOpen : {this.isOpen}, capacityInL : {this.capacityInL}, amountFilledInL : {this.amountFilledInL} ]";
        }

        public bool Open()
        {
            if (this.isOpen)
            {
                throw new ArgumentException("\nImpossible d'ouvrir une bouteille déjà ouverte\n", nameof(this.isOpen));
            }
            this.isOpen = true;
            return true;
        }

        public bool Close()
        {
            if (!this.isOpen)
            {
                throw new ArgumentException("\nImpossible de fermer une bouteille déjà fermée\n", nameof(this.isOpen));
            }
            this.isOpen = false;
            return true;
        }

        public bool Empty()
        {
            if(!this.isOpen)
            {
                throw new ArgumentException("\nImpossible de vider une bouteille fermée\n", nameof(this.amountFilledInL));
            }
            else if (this.amountFilledInL == 0)
            {
                throw new ArgumentException("\nImpossible de vider une bouteille vide\n", nameof(this.amountFilledInL));
            }
            this.amountFilledInL = 0;
            return true;
        }

        public bool Empty(decimal amountToEmpty)
        {
            if (!this.isOpen)
            {
                throw new ArgumentException("\nImpossible de vider une bouteille fermée\n", nameof(this.amountFilledInL));
            }
            else if(amountToEmpty > this.amountFilledInL)
            {
                throw new ArgumentException("\nImpossible de vider la bouteille de plus de ce qu'elle contient\n", nameof(amountToEmpty));
            }
            this.amountFilledInL -= amountToEmpty;
            return true;
        }

        public bool Fill()
        {
            if (!this.isOpen)
            {
                throw new ArgumentException("\nImpossible de remplir une bouteille fermée\n", nameof(this.amountFilledInL));
            }
            else if(this.amountFilledInL == this.capacityInL)
            {
                throw new ArgumentException("\nLa bouteille est déjà pleine\n", nameof(this.amountFilledInL));
            }
            this.amountFilledInL = this.capacityInL;
            return true;
        }

        public bool Fill(decimal amountToFill)
        {
            if (!this.isOpen)
            {
                throw new ArgumentException("\nImpossible de remplir une bouteille fermée\n", nameof(this.amountFilledInL));
            }
            else if(this.amountFilledInL + amountToFill > this.capacityInL)
            {
                throw new ArgumentException("\nImpossible de remplir la bouteille de plus de sa capacitée\n", nameof(amountToFill));
            }
            this.amountFilledInL += amountToFill;
            return true;
        }
    }
}
