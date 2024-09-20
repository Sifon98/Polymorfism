using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    }

    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric field. This fired an error!";
        }
    }

    public class ShortTextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to enter text that is too short in the text field. This fired an error!";
        }
    }

    public class LongTextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to enter text that is too long in the text field. This fired an error!";
        }
    }

    public class LowNumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You entered a number that is too low in the numeric field. This fired an error!";
        }
    }
}
