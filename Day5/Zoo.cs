using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Zoo 
    {
        private readonly List<Animal> animals = new List<Animal>();

        public ReadOnlyCollection<Animal> Animals => animals.AsReadOnly();
        public ReadOnlyCollection<Animal> Birds =>
            animals.Where(a => a is Bird).ToList().AsReadOnly();
        public ReadOnlyCollection<Animal> Mammals => 
            animals.Where(a => a is Mammal).ToList().AsReadOnly();


        public void Add(Animal animal)
        {
            if (animal.Age > 10)
            {
                Console.WriteLine($"{animal.Name} is too old for the zoo.");
                return;
            }

            if (!animal.IsAlive)
            {
                Console.WriteLine($"{animal.Name} is dead and can't be added.");
                return;
            }

            animals.Add(animal);                
        }
        public void RemoveDeadAnimals()
        {
            animals.RemoveAll(a => !a.IsAlive);
        }

    }
}
