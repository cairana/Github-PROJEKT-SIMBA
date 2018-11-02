using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbaTvaerfagligt
{
    [Serializable]
    public class Wildebeest : Animal
    {
        public override string Name
        {
            get { return "Wildebeest"; }
        }

        public Wildebeest()
        {
            this.Weight = 150; //Default weight
            this.Speed = 2;
            this.OffSpring = 1;
            //Gnuer får ikke 4 unger af gangen, de får kun 1.
            this.LooseProcentageWeight = 1;
            this.MinimumWeight = 100;
        }

        public override void AddWeight(double WeightOfWildbeest = 0, bool isOnGrass = false)
        {
            if (isOnGrass)
            {
                this.Weight = ((this.Weight * 2) / 100) + this.Weight;
            }
        }
    }
}
