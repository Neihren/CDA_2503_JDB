﻿namespace Bouteilles
{
    public class Bouteille
    {
        private bool isOpen;
        private decimal capacityInL;
        private decimal amountFilledInL;

        public bool IsOpen { get => isOpen; /*set => isOpen = value;*/ }
        public decimal CapacityInL { get => capacityInL;/* set => capacityInL = value;*/ }
        public decimal AmountFilledInL { get => amountFilledInL; /*set => amountFilledInL = value;*/ }

        public Bouteille()
            : this(false, 0, 0)
        {
        
        }

        public Bouteille(bool isOpen, decimal capacityInL, decimal amountFilledInL)
        {
            if (capacityInL < 0 || amountFilledInL < 0)
            {
                throw new ArgumentException("\nImpossible de mettre une valeur négative\n", nameof(amountFilledInL));
            }
            if (amountFilledInL > capacityInL)
            {
                throw new ArgumentException("\nImpossible de remplir la bouteille plus que sa capacité\n", nameof(amountFilledInL));
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
            return $"Bouteille[ {nameof(isOpen)} : {this.isOpen}, capacityInL : {this.capacityInL}, amountFilledInL : {this.amountFilledInL} ]";
        }

        public bool Open()
        {
            if (this.isOpen)
            {
                return false;
            }
            this.isOpen = true;
            return true;
        }

        public bool Close()
        {
            if (!this.isOpen)
            {
                return false;
            }
            this.isOpen = false;
            return true;
        }

        public bool Empty()
        {
            return Empty(this.amountFilledInL);
        }

        public bool Empty(decimal amountToEmpty)
        {
            if (amountToEmpty < 0)
            {
                throw new ArgumentException("\nImpossible de mettre une valeur négative à la quantitée à retirer\n", nameof(amountToEmpty));
            }
            if (!this.isOpen)
            {
                return false;
            }
            if(amountToEmpty > this.amountFilledInL)
            {
                return false;
            }
            this.amountFilledInL -= amountToEmpty;
            return true;
        }

        public bool Fill()
        {
            return Fill(this.CapacityInL - this.amountFilledInL);
        }

        public bool Fill(decimal amountToFill)
        {
            if (amountToFill < 0)
            {
                throw new ArgumentException("\nImpossible de mettre une valeur négative à la quantitée à remplir\n", nameof(amountToFill));
            }
            if (!this.isOpen)
            {
                return false;
            }
            if(this.amountFilledInL + amountToFill > this.capacityInL)
            {
                return false;
            }
            this.amountFilledInL += amountToFill;
            return true;
        }

        public decimal LToML()
        {
            return this.amountFilledInL * 1000;
        }
    }
}
