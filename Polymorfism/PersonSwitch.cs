using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    internal class PersonSwitch
    {
        public static void PersonMenu()
        {
            Person person = new Person();
            PersonHandler handler = new PersonHandler();

            bool personRunning = true;
            while (personRunning)
            {
                UIMenu.PersonMenu();
                int.TryParse(Console.ReadLine(), out int switchNumber);

                switch (switchNumber)
                {
                    case 1:
                        Console.WriteLine("A template person was created.");
                        handler.CreatePerson(person, 28, "John", "Doe", 175, 40);
                        break;
                    case 2:
                        Console.Write("Write the age: ");
                        handler.SetAge(person, int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Write("Write the firstname: ");
                        handler.SetFname(person, Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("Write the lastname: ");
                        handler.SetLname(person, Console.ReadLine());
                        break;
                    case 5:
                        Console.Write("Write the height: ");
                        handler.SetHeight(person, double.Parse(Console.ReadLine()));
                        break;
                    case 6:
                        Console.Write("Write the weight: ");
                        handler.SetWeight(person, double.Parse(Console.ReadLine()));
                        break;
                    case 7:
                        string personOutput = handler.GetPerson(person);
                        Console.WriteLine(personOutput);
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
