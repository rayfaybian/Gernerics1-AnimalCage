using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Cage
{
    class Cage<T> where T : Animal
    {
        private List<T> animalList { get; set; }

        public Cage() {
            this.animalList = new List<T>();
        }

        public void AddAnimal(T animal)
        {
            animalList.Add(animal);
        }

        public void RemoveAnimal(T animal)
        {
            if (animalList.Contains(animal))
            {
                animalList.Remove(animal);
            } else
            {
                Console.WriteLine("Dieses Tier wohnt hier nicht.");
            }
        }

        public void ShowAnimals()
        {
            if (animalList.Count > 0)
            {
                Console.WriteLine("In diesem Käfig leben " + animalList.Count + " Tiere vom Typ " + animalList.Select(x => x.type).FirstOrDefault());
                foreach (var inmate in animalList)
                {
                    Console.WriteLine(inmate.name);
                }
            }
        }
    }
}
