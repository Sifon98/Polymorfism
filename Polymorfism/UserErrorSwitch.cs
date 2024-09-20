using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Polymorfism
{
    internal class UserErrorSwitch
    {
        internal static void UserErrorMenu()
        {
            List<UserError> userError = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError(),
                new ShortTextInputError(),
                new LongTextInputError(),
                new LowNumericInputError()
            };

            bool userErrorRunning = true;
            while (userErrorRunning)
            {
                UIMenu.UserErrorMenu();
                int.TryParse(Console.ReadLine(), out int switchNumber);

                switch (switchNumber)
                {
                    case 1:
                        foreach (var item in userError)
                        {
                            Console.WriteLine(item.UEMessage());
                        }
                        break;
                    case 0:
                        userErrorRunning = false;
                        break;
                    default:
                        Console.WriteLine("Something unexpected went wrong. Try again");
                        break;
                }
            }
        }
    }
}