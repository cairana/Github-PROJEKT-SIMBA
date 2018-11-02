using System;


namespace SimbaTvaerfagligt
{
    public class Savanna
    {
        //Hint til selv, lade være med at remove animals når de dør, gem dem i databasen med bool dead evt.

        public Field[][] grid = new Field[20][];
        public static Random rnd = new Random();        
        public int nbrOfLions;
        public int nbrOfWildebeest;
        public int nbrOfGrassPatches;
        private bool begun = false;
        public static int nbrOffFields { get; set; } = 20;
        private Database db = new Database();

        public Savanna() 
        {
            InitializeSavannaGrid();
        }

        private void InitializeSavannaGrid()
        {
            for (int x = 0; x < nbrOffFields; x++)
            {
                this.grid[x] = new Field[nbrOffFields];
                for (int y = 0; y < nbrOffFields; y++)
                {
                    this.grid[x][y] = new Field();

                }
            }
        }
        public void ActivateGameWithPreConditions()
        {
            if (!this.begun)
            {
                this.begun = true;

                AddInitialGameConditions(nbrOfLions, nbrOfWildebeest, nbrOfGrassPatches);
                db.SaveInitialGameConditions();
            }
        }

        public void DoRound()
        {
            
            SaveGame(); //Saves the round in database as text (XMLSerialization)
            Starve();
            RemoveAnimalDiedOfStarvation();
            Eat();    //Gain weight ligger under eat() 
            BreedAll();
            resetHasBeenMoved();
            MoveAnimals();
           // OverpopulationStopGame(); //Tilføjet efter aflevering

        }


        //Tilføjet efter aflevering
        public bool OverpopulationStopGame(int TotalNbrOffAnimals)
        {
            
            if (TotalNbrOffAnimals >= 350)
            {
                RestartGame();
                return true;
            }
            return false;
        }

        private void SaveGame()
        {
            string xmlText = SerializationHandler.SerializeRound(this);

            db.SaveGameRounds(xmlText);
        }

        public void RestartGame()
        {
            SaveGame();
            db.EndCurrentGame();
            db.Close();
            this.begun = false;
            InitializeSavannaGrid();
        }


        private Field ReturnRndField()
        {
            int x = rnd.Next(0, nbrOffFields);
            int y = rnd.Next(0, nbrOffFields);
            return grid[x][y];
        }
        private void AddInitialGameConditions(int nbrOfLions, int nbrOfWildbeest, int nbrOfGrassPatches)
        {
            this.nbrOfGrassPatches = nbrOfGrassPatches - 1;
            this.nbrOfLions = nbrOfLions - 1;
            this.nbrOfWildebeest = nbrOfWildbeest - 1;


            for (int i = 0; i <= this.nbrOfLions; i++)
            {
                Animal l = new Lion();
                l.AddWeight();
                l.SetGender();
                ReturnRndField().AddAnimal(l);
            }

            for (int k = 0; k <= this.nbrOfWildebeest; k++)
            {
                Animal w = new Wildebeest();
                w.AddWeight();
                w.SetGender();
                ReturnRndField().AddAnimal(w);
            }
            for (int j = 0; j <= this.nbrOfGrassPatches; j++)
            {
                RespawnGrass(0,0,true);
            }
        }

        private void RespawnGrass(int x, int y, bool forceGrass = false)
        {
            if (!grid[x][y].grass || forceGrass)
            {
                Field rnd = ReturnRndField();

                while (rnd.grass)
                {
                    rnd = ReturnRndField();
                }
                rnd.grass = true;
            }
        }


        private void Starve()
        {
            for (int x = 0; x < nbrOffFields; x++)
            {
                for (int y = 0; y < nbrOffFields; y++)
                {
                    grid[x][y].StarveAnimals();
                }
            }
        }
    

        private void RemoveAnimalDiedOfStarvation()
        {
            for (int x = 0; x < nbrOffFields; x++)
            {
                for (int y = 0; y < nbrOffFields; y++)
                {
                    for (int i = grid[x][y].animals.Count - 1; i >= 0; i--)
                    {
                        Animal currentAnimal = grid[x][y].animals[i];

                        if (currentAnimal.Weight <= currentAnimal.MinimumWeight)
                        {
                            grid[x][y].animals.Remove(currentAnimal);
                            
                        }
                    }
                }
            }
        }
 
        public AnimalStats OutputTotalSavannaLifeOnForm()
        {
            AnimalStats stats = new AnimalStats();

           //Animal currentAnimals;

            for (int x = 0; x < nbrOffFields; x++)
            {
                for (int y = 0; y < nbrOffFields; y++)
                {
                    for (int i = grid[x][y].animals.Count - 1; i >= 0; i--)
                    {
                        //Sløver det programmet????? Erklære den oppe i linje 175
                        Animal currentAnimals = grid[x][y].animals[i];

                        bool isFemale = currentAnimals.IsFemale;

                        if (isFemale == true && currentAnimals.Name == "Wildebeest")
                        {
                            stats.TotalFemaleWildebeests++;
                            if (currentAnimals.IsOffspring == true)
                            {
                                stats.TotalNbrOffspringWildebeests++;
                            }

                        }
                        if (isFemale == false && currentAnimals.Name == "Wildebeest")
                        {
                            stats.TotalMaleWildebeests++;
                            if (currentAnimals.IsOffspring == true)
                            {
                                stats.TotalNbrOffspringWildebeests++;
                            }
                        }
                        if (isFemale == true && currentAnimals.Name == "Lion")
                        {
                            stats.TotalFemaleLions++;
                            if (currentAnimals.IsOffspring == true)
                            {
                                stats.TotalNbrOffspringLions++;
                            }
                        }
                        if (isFemale == false && currentAnimals.Name == "Lion")
                        {
                            stats.TotalMaleLions++;
                            if (currentAnimals.IsOffspring == true)
                            {
                                stats.TotalNbrOffspringLions++;
                            }
                        }
                        //Tilføjet efter aflevering
                        stats.TotalNbrOffAnimals = stats.TotalFemaleLions + stats.TotalFemaleWildebeests +
                                                   stats.TotalMaleWildebeests + stats.TotalMaleLions;
                    }
                }
            }
            return stats;
        }



        private void BreedAll()
        {
            for (int x = 0; x < nbrOffFields; x++)
            {
                for (int y = 0; y < nbrOffFields; y++)
                {
                    foreach (Animal item in grid[x][y].Breed("Lion"))
                    {
                        ReturnRndField().AddAnimal(item);
                        item.NbrOffOffspring += item.OffSpring;
                    }

                    foreach (Animal item in grid[x][y].Breed("Wildebeest"))
                    {
                        ReturnRndField().AddAnimal(item);
                        item.NbrOffOffspring += item.OffSpring;
                    }
                }
            }
        }

        private void Eat()
        {                      
            //nyt græsområde bliver kreeret når et græsområde bliver spist. 1 til 1.
            for (int x = 0; x < nbrOffFields; x++)
            {
                for (int y = 0; y < nbrOffFields; y++)
                {                
                    bool grassEaten = grid[x][y].grass;

                    grid[x][y].EatAnimal();
                    grid[x][y].EatGrass();

                    if (grassEaten == true)
                    {
                        if (grid[x][y].grass == false) RespawnGrass(x, y);
                       
                    }

                }
            }
        }

        private void resetHasBeenMoved()
        {
            for (int x = 0; x < nbrOffFields; x++)
            {
                for (int y = 0; y < nbrOffFields; y++)
                {
                    foreach (Animal item in grid[x][y].animals)
                    {
                        item.HasBeenMoved = false;
                    }
                }
            }
        }
        private void MoveAnimals()
        {
            for (int x = 0; x < nbrOffFields; x++)
            {
                for (int y = 0; y < nbrOffFields; y++)
                {
                    for (int i = grid[x][y].animals.Count - 1; i >= 0; i--)
                    {
                        Animal currentAnimal = grid[x][y].animals[i];

                        if (!currentAnimal.HasBeenMoved)
                        {
                            grid[x][y].animals.Remove(currentAnimal);

                            var field = OutOffBounds(x, y, currentAnimal.Speed);

                            grid[field.Item1][field.Item2].animals.Add(currentAnimal);

                            currentAnimal.HasBeenMoved = true;
                        }
                    }
                }
            }
        }
        private Tuple<int, int> OutOffBounds(int x, int y, int speed)
        {
            int newX = x + (rnd.Next(-1, 2) * speed);
            int newY = y + (rnd.Next(-1, 2) * speed);

            while (newX < 0 || newY < 0 || newX > nbrOffFields - 1 || newY > nbrOffFields - 1 || (newX == 0 && newY == 0))
            {
                newX = x + (rnd.Next(-1, 2) * speed);
                newY = y + (rnd.Next(-1, 2) * speed);
            }

            return new Tuple<int, int>(newX, newY);
        }

    }
}


