using Zoo.Logic;

namespace Zoo.ConApp
{
    /// <summary>
    /// The <see cref="Program"/> class is the entry point of the application.
    /// It demonstrates the creation and management of various animal types,
    /// including pets and farmed animals, and performs operations on them.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The entry point of the application that demonstrates the creation and manipulation of different animal types,
        /// including pets and farmed animals. It showcases the use of collections to manage these animals and perform
        /// various operations such as counting, displaying, and combining different sets of animals.
        /// </summary>
        /// <remarks>
        /// This method creates instances of various animal classes (Fish, Bird, Mammal) and adds them to different sets
        /// representing pets and farmed animals. It then performs operations such as intersection, union, and difference
        /// on these sets to demonstrate their relationships. The results are printed to the console.
        /// </remarks>
        static void Main(/*string[] args*/)
        {
            Console.WriteLine("Zoo");

            Fish goldfisch = new("Goldfisch");
            Fish zander = new("Zander");
            //Fish piranha = new("Piranha");
            Bird canary = new("Kanari");
            Bird chicken = new("Huhn");
            //Bird hawk = new("Falke");
            //Bird kiwi = new("Kiwi");
            //Bird eagle = new("Adler");
            //Mammal human = new("Mensch");
            Mammal dog = new("Hund");
            Mammal cat = new("Katze");
            //Mammal lion = new("Löwe");
            Mammal horse = new("Pferd");
            Mammal rabbit = new("Hase");
            Mammal cow = new("Kuh");

            Set pets = new();
            pets.Add(goldfisch);
            pets.Add(canary);
            pets.Add(dog);
            pets.Add(cat);
            pets.Add(rabbit);
            Console.WriteLine("{0} Haustiere", pets.Count);
            Console.WriteLine(pets.ToString());

            Set farmedAnimals = new();
            farmedAnimals.Add(cow);
            farmedAnimals.Add(horse);
            farmedAnimals.Add(zander);
            farmedAnimals.Add(rabbit);
            farmedAnimals.Add(chicken);
            Console.WriteLine("{0} Nutztiere", farmedAnimals.Count);
            Console.WriteLine(farmedAnimals.ToString());

            Set farmedPets = pets * farmedAnimals;
            Console.WriteLine("{0} Nutztiere zugleich Haustiere", farmedPets.Count);
            Console.WriteLine(farmedPets.ToString());

            Set companionAnimals = pets + farmedAnimals;
            Console.WriteLine("{0} zahme Tiere", companionAnimals.Count);
            Console.WriteLine(companionAnimals.ToString());

            Set uneatableAnimals = pets - farmedAnimals;
            Console.WriteLine("{0} nicht essbare Haustiere", uneatableAnimals.Count);
            Console.WriteLine(uneatableAnimals.ToString());

            //Spezialistenaufgabe: Zum Testen folgende Zeilen aktiv setzen.
            Bird penguin = new("Pinguin", true);
            Console.WriteLine("Spezialistenaufgabe:");
            Console.WriteLine(penguin.ToString());

            Console.ReadLine();
        }
    }
}
