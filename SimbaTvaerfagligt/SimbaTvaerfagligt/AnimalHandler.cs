//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SimbaTvaerfagligt
//{
//    class AnimalHandler
//    {

//        private Field ReturnRndField(Field[][] grid)
//        {
//            int x = rnd.Next(0, nbrOffFields);
//            int y = rnd.Next(0, nbrOffFields);
//            return grid[x][y];
//        }
//        public void BreedAll(Field[][] grid)
//        {
//            for (int x = 0; x < nbrOffFields; x++)
//            {
//                for (int y = 0; y < nbrOffFields; y++)
//                {
//                    foreach (Animal item in grid[x][y].Breed("Lion"))
//                    {
//                        ReturnRndField().AddAnimal(item);
//                        item.NbrOffOffspring += item.OffSpring;
//                    }

//                    foreach (Animal item in grid[x][y].Breed("Wildebeest"))
//                    {
//                        ReturnRndField().AddAnimal(item);
//                        item.NbrOffOffspring += item.OffSpring;
//                    }
//                }
//            }
//        }

//    }


//}
