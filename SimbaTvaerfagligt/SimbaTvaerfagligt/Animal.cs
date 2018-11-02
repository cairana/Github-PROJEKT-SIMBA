using System;
using System.Xml.Serialization;

namespace SimbaTvaerfagligt
{
    [XmlInclude(typeof(Wildebeest))]
    [XmlInclude(typeof(Lion))]
    [Serializable]

    public abstract class Animal
    {      
        public virtual string Name { get; }
        public virtual int Speed { get; set; }
        public virtual int OffSpring { get; set; }
        public virtual double Weight { get; set; } // Input startweight   
        public virtual double LooseProcentageWeight { get; set; }
        public virtual double MinimumWeight { get; set; }
        public virtual int NbrOffOffspring { get; set; }       
        public bool HasBeenMoved { get; set; }
        public bool IsFemale { get; set; }
        public bool IsOffspring { get; set; }

        //Tilføjet efter aflevering
        public bool HasJustBreeded { get; set; }
        public bool HasEatenAnimal { get; set; }
        public int breakFromBreeding = 3;
        public int breakFromEating = 3;
        



        public Animal()
        {
            HasBeenMoved = false;
        }

        public abstract void AddWeight(double WeightOfWildbeest = 0.0D, bool isOnGrass = false);
       

        public bool SetGender()
        {
            int gender = Savanna.rnd.Next(100);
            if (gender % 2 == 1)
            {
                return this.IsFemale = false;
            }
            else return this.IsFemale = true;
        }

        //Den behøver ikke at være virtual da metoden er ens for dyrene og derved ikke skal overrides.
        //Ændret efter aflevering
        public void RemoveWeight(double inputWeight)
        {
            this.Weight = inputWeight - ((inputWeight * this.LooseProcentageWeight) / 100);           
        }
    }
}
