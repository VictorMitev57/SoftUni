using System.Collections.Generic;
using System;

namespace Zoo
{
    public class Zoo
    {
        private List<Animal> animals;
        private string name;
        private int capacity;

        /// <summary>
        /// ////
        /// </summary>
        public List<Animal> Animals { get => animals; set => animals = value; }
        public string Name { get => name; set => name = value; }
        public int Capacity { get => capacity; set => capacity = value; }


        /// <summary>
        /// ////////////////////
        /// </summary>
        public Zoo(string name, int capacity)
        {
            animals = new List<Animal>();
            Name = name;
            Capacity = capacity;    
        }

        public string AddAnimal(Animal animal)
        {
            string text = "";
            int index = animals.IndexOf(animal);
            if (string.IsNullOrWhiteSpace(animals[index].Species))
            {
                text = "Invalid animal species.";
            }
            else if (animal.Diet != "herbivore" || (animal.Diet != "carnivore"))
            {
                text =  "Invalid animal diet.";
            }
            else if (animals.Count == capacity)
            {   
                text = "The zoo is full.";
            }
            else if (animals.Count < capacity)
            {
                animals.Add(animal);
                text = "Successfully added" + animals[index].Species + "to the zoo.";
            }
            return text;
        }
        public int RemoveAnimals(string species)
        {
            int count = 0;
            foreach (var el in animals)
            {
                if (el.Species == species)
                {
                    animals.Remove(el);
                    count++;
                }
            }
            return count;
        }
        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animalDiet = new List<Animal>();
            foreach (var el in animals)
            {
                if (el.Diet == diet)
                {
                    animalDiet.Add(el);
                }
            }
            return animalDiet;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            string firstAnimal = "";
            foreach (var el in animals)
            {
                if (el.Weight == weight)
                {
                    firstAnimal = el.;
                    break;
                }
            }
            return;
        }

    }
}
