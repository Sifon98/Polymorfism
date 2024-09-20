using System;
using System.Collections.Generic;

namespace Polymorfism
{
    internal class AnimalSwitch
    {
        internal static void AnimalMenu()
        {
            List<Animal> animals = new List<Animal>();

            Horse horse = new Horse();
            horse.Do("Zebra", 10, 10, 15);
            animals.Add(horse);

            Worm worm = new Worm();
            worm.Do("Lillen", 10, 10, "yes");
            animals.Add(worm);

            Wolf wolf = new Wolf();
            wolf.Do("Buddy", 13, 53, 10);
            animals.Add(wolf);

            Wolfman wolfman = new Wolfman();
            wolfman.Do("Albert", 14, 33, 1);
            animals.Add(wolfman);

            List<Dog> dogs = new List<Dog>();
            Dog dog = new Dog();
            dog.Do("Runner", 10, 10, "Super kind");
            dogs.Add(dog);
            animals.Add(dog);
            //dogs.Add(horse);
            // 9. F: En Horse kan inte lagras i en lista av Dog, det hade funkat om Horse hade ärvt av Dog men eftersom den inte gör det kan C# inte
            // inte fatta hur en Horse ska sättas in i en Dog lista
            // 10. F: För att kunna lagra dem i samma lista måste det vara en lista av Animal som dem båda ärver av

            bool personRunning = true;
            while (personRunning)
            {
                UIMenu.AnimalMenu();
                int.TryParse(Console.ReadLine(), out int switchNumber);

                switch (switchNumber)
                {
                    case 1:
                        foreach (var animal in animals)
                        {
                            if (animal.GetType().GetInterface("IPerson") == typeof(IPerson))
                            {
                                IPerson interfaceAnimal = (IPerson)animal;
                                interfaceAnimal.Talk();
                            }
                            else
                            {
                                Console.Write($"Animal: {animal.GetType().Name}, Sound: ");
                                animal.DoSound();
                            }
                        }
                        break;
                    case 2:
                        // 13. F: För varje animal i listan animals anropas dens Stats() funktion som returnerar en string i Console.WriteLine
                        foreach (var animal in animals)
                        {
                            Console.WriteLine(animal.Stats());
                        }
                        break;
                    case 3:
                        foreach (var animal in animals)
                        {
                            if (animal.GetType() == typeof(Dog))
                            {
                                Console.WriteLine(animal.Stats());
                                // Console.WriteLine(animal.ReturnString());
                                // 17. F: En lista av Animal har inte tillgång till en metod unik till Dog. Dog har tillgång till metoder i Animal eftersom
                                // den ärver dem men det fungerar inte åt motsatt håll. I Case 4 ser ni hur jag kom åt det.
                            }
                        }
                        break;
                    case 4:
                        foreach (var animal in animals)
                        {
                            if (animal.GetType() == typeof(Dog))
                            {
                                Dog dogFunction = (Dog)animal;
                                Console.WriteLine(dogFunction.ReturnString());
                            }
                        }
                        break;
                    case 0:
                        personRunning = false;
                        break;
                    default:
                        Console.WriteLine("Something unexpected went wrong. Try again");
                        break;
                } 
            }
        }
    }
}