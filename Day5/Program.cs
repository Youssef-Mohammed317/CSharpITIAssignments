namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Day5

            #region Q1
            /*
             1-	Design a Zoo class that contains different types of animals.
                Animals are categorized as Mammals or Birds. 
                Any animal whose age is greater than 10 years, is not accepted in the Zoo. 
                If an animal dies, it must be removed from the Zoo. 
                Design the system so that, the following code is valid:

                Zoo zoo = new Zoo();

                zoo.Add(new Lion());
                zoo.Add(new Sparrow());
                zoo.Add(new Elephant());
                zoo.Add(new Pigeon());

                foreach(Animal bird in zoo.Birds) 
                // (Birds must be a read-only collection)
                {
	                Console.WriteLine(bird);
                }

                foreach(Animal mammal in zoo.Mammals) 
                // (Mammals must be a read-only collection)
                {
	                Console.WriteLine(mammal);
                }

                foreach(Animal animal in zoo.Animals)
                {
	                Console.WriteLine(animal);
                }
             */
            //Zoo zoo = new Zoo();

            //zoo.Add(new Lion { Age = 5 });
            //zoo.Add(new Sparrow { Age = 2 });
            //zoo.Add(new Elephant { Age = 8 });
            //zoo.Add(new Pigeon { Age = 1 });

            //Console.WriteLine("Birds in Zoo:");
            //foreach (Animal bird in zoo.Birds)
            //{
            //    Console.WriteLine(bird);
            //}

            //Console.WriteLine("\nMammals in Zoo:");
            //foreach (Animal mammal in zoo.Mammals)
            //{
            //    Console.WriteLine(mammal);
            //}

            //Console.WriteLine("\nAll Animals in Zoo:");
            //foreach (Animal animal in zoo.Animals)
            //{
            //    Console.WriteLine(animal);
            //}

            //zoo.Animals[0].IsAlive = false;
            //zoo.RemoveDeadAnimals();

            //Console.WriteLine("\nAfter removing dead animals:");
            //foreach (Animal animal in zoo.Animals)
            //{
            //    Console.WriteLine(animal);
            //}

            #endregion

            #region Q2
            /*
             2-	Redesign your PhoneBook class so that is has  Dictionary<string, int> Entries inside it 
                (Keep the same functionality of the class)
             */
            //PhoneBook phoneBook = new PhoneBook();
            //phoneBook[123] = "Ali";
            //phoneBook["Hosam"] = 456;
            //int phone = phoneBook["Ali"];
            #endregion

            #endregion
        }
    }
}
