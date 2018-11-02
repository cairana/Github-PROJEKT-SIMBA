using System;


namespace SimbaTvaerfagligt
{
    [Serializable]
    public class Lion : Animal
    {
       public override string Name
        {
            get { return "Lion"; }
        }

       

        public Lion()
        {
            this.Weight = 150; //default weight. Kobles til db, hvor vægten opdatered måske??
            this.Speed = 1;
            this.OffSpring = 2;
            this.LooseProcentageWeight = 0.5;
            this.MinimumWeight = 100;

        }
      
        public override void AddWeight(double WeightOfWildbeest = 0, bool isOnGrass = false)
        {
            this.Weight = ((WeightOfWildbeest * 1) / 100) + this.Weight;

        }
    }
}
