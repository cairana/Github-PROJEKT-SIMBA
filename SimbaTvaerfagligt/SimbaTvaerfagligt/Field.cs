using System;
using System.Collections.Generic;
using System.Linq;


namespace SimbaTvaerfagligt
{
    public class Field
    {

        public List<Animal> animals;
        public bool grass { get; set; }
        
        public Field()
        {
            animals = new List<Animal>(); // Denne skal ændres da vi skal trække fra databasen
        }

        public void AddAnimal(Animal animal)
        {
            this.animals.Add(animal);
        }

        public List<Animal> Breed(string animalName)
        {
            bool maleFound = false;
            List<Animal> newAnimals = new List<Animal>();

            for (int i = 0; i < animals.Count; i++)
            {
                foreach (Animal item in animals)
                {
                    if (item.IsFemale == false && item.Name == animalName)
                    {
                        maleFound = true;
                    }
                }

                if (maleFound)
                {
                    foreach (Animal item in animals)
                    {
                        if (item.IsFemale == true && item.Name == animalName && IsReadyToBreed())
                        {

                            for (int j = 0; j < item.OffSpring; j++)
                            {
                                Animal w = null;
                                if (animalName == "Wildebeest") w = new Wildebeest();
                                if (animalName == "Lion") w = new Lion();

                                w.IsOffspring = true;
                                w.SetGender();
                                w.AddWeight();
                                newAnimals.Add(w);
                            }
                            //tilføjet efter aflevering -->
                            item.HasJustBreeded = true;
                            //<--
                        }
                    }
                }                
            }
            return newAnimals;
        }

        //Tilføjet efter aflevering af opgaven -->
        private bool IsReadyToBreed()
        {
            foreach (Animal item in animals)
            {
                if (item.HasJustBreeded == true && item.breakFromBreeding >= 0 && item.IsFemale)
                {
                    if (item.breakFromBreeding == 0)
                    {
                        item.HasJustBreeded = false;
                        item.breakFromBreeding = 3;
                        return true;
                    }
                    item.breakFromBreeding--;
                    return false;
                }
            }
            return true;
        }
        //<--

        public void EatAnimal()
        {
            Animal lion = null;
            Animal prey = null;

            for (int i = 0; i < animals.Count; i++)
            {
                foreach (Animal item in animals)
                {
                    if (item.Name == "Lion")
                    {
                        lion = item;
                    }
                }
                if (lion != null && IsReadytoEatPrey())
                {
                    foreach (Animal item in animals)
                    {
                        if (item.Name == "Wildebeest")
                        {
                            prey = item;
                            lion.AddWeight(prey.Weight);
                            lion.HasEatenAnimal = true;
                        }
                    }
                    animals.Remove(prey);
                }
            }           
        }

        //Tilføjet efter aflevering af opgaven -->
        private bool IsReadytoEatPrey()
        {
            foreach (Animal item in animals)
            {
                if (item.HasEatenAnimal && item.breakFromEating >= 0 && item.Name == "Lion")
                {
                    if (item.breakFromEating == 0)
                    {
                        item.HasEatenAnimal = false;
                        item.breakFromEating = 3;
                        return true;
                    }
                    item.breakFromEating--;
                    return false;
                }
            }
            return true;
        }

        public void EatGrass()
        {
            Animal hungryWildbeest = null;

            for (int i = 0; i < animals.Count(); i++)
            {
                foreach (Animal item in animals)
                {
                    if (item.Name == "Wildebeest")
                    {
                        hungryWildbeest = item;
                    }
                }
                if (hungryWildbeest != null)
                {
                    if (this.grass == true)
                    {
                        hungryWildbeest.AddWeight(hungryWildbeest.Weight, grass);

                        //Fjerner græsset - det er spist og der dukker nyt græs op et andet sted.
                        this.grass = false;                     
                    }
                }
            }
        }
        public void StarveAnimals()
        {
            Animal starvingWildebeest = null;
            Animal starvingLion = null;
            for (int i = 0; i < animals.Count(); i++)
            {              
                foreach (Animal item in animals)
                {
                    if (item.Name == "Wildebeest" && this.grass == false)
                    {
                        starvingWildebeest = item;
                        starvingWildebeest.RemoveWeight(starvingWildebeest.Weight);                     
                    }                   
                }
                if (starvingWildebeest == null)
                {
                    foreach (Animal item in animals)
                    {
                        if (item.Name == "Lion")
                        {
                            starvingLion = item;
                            starvingLion.RemoveWeight(starvingLion.Weight);
                        }
                    }
                }
            }

        }
        
    }
}

