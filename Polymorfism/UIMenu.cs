using System;
using System.Security.Cryptography.X509Certificates;

namespace Polymorfism
{
    internal class UIMenu
    {
        public static void MainMenu()
        {
            Console.WriteLine("\n=====================================\n");
            Console.WriteLine("Pick a option to start the program.");
            Console.WriteLine("1. Person functions");
            Console.WriteLine("2. User Error Functions");
            Console.WriteLine("3. Animal Functions");
            Console.WriteLine("0. Quit program");
        }
        public static void PersonMenu()
        {
            Console.WriteLine("\n-------------------------------------\n");
            Console.WriteLine("Pick a option to start the program.");
            Console.WriteLine("1. Create person");
            Console.WriteLine("2. Change age");
            Console.WriteLine("3. Change firstname");
            Console.WriteLine("4. Change lastname");
            Console.WriteLine("5. Change height");
            Console.WriteLine("6. Change weight");
            Console.WriteLine("7. Get person");
            Console.WriteLine("0. Return to start");
        }
        public static void UserErrorMenu()
        {
            Console.WriteLine("\n-------------------------------------\n");
            Console.WriteLine("Pick a option to start the program.");
            Console.WriteLine("1. Show user errors");
            Console.WriteLine("0. Return to start");
        }
        public static void AnimalMenu()
        {
            Console.WriteLine("\n-------------------------------------\n");
            Console.WriteLine("Pick a option to start the program.");
            Console.WriteLine("1. Print animals and sound (Talk if Werewolf)");
            Console.WriteLine("2. Print the stats of all animals");
            Console.WriteLine("3. Only print the stats of all dogs");
            Console.WriteLine("4. Call a function withing Dog from Animal list");
            Console.WriteLine("0. Return to start");
        }
    }
}