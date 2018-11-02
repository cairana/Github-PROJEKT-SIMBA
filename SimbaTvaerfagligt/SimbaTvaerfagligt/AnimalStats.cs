using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbaTvaerfagligt
{
    public class AnimalStats
    {
        public int TotalFemaleWildebeests { get; set; }
        public int TotalMaleWildebeests { get; set; }
        public int TotalMaleLions  { get; set; }
        public int TotalFemaleLions { get; set; }
        public int TotalNbrOffspringWildebeests { get; set; }
        public int TotalNbrOffspringLions { get; set; }
        public int TotalNbrOffAnimals { get; set; }

        // Mangler nedenstående:
        //public int TotalNbrWildbeestPreyEaten { get; set; }
        //public int TotalNbrWildbeestDiedStarvation { get; set; }
        //public int TotalNbrLionsDiedStarvation { get; set; }

    }
}
