using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    // Svar på frågor startar med t.ex. "13. F:" precis som i uppgiften så ni enkelt kan söka efter dem
    // Dem finns i Animal.cs och AnimalSwitch.cs
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                try
                {
                    UIMenu.MainMenu();
                    int.TryParse(Console.ReadLine(), out int switchNumber);

                    switch (switchNumber)
                    {
                        case 1:
                            PersonSwitch.PersonMenu();
                            break;
                        case 2:
                            UserErrorSwitch.UserErrorMenu();
                            break;
                        case 3:
                            AnimalSwitch.AnimalMenu();
                            break;
                        case 0:
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Something unexpected went wrong. Try again");
                            break;
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
