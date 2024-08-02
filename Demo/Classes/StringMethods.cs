using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    internal class StringMethods
    {
        public static int GetUpperCaseCounter(string Word)
        {
            int counter = 0;
            if (!string.IsNullOrEmpty(Word))
                for (int i = 0; i < Word.Length; i++)
                    if (char.IsUpper(Word[i]))
                        counter++;
            return counter;
        }
        public static int GetLowerCaseCounter(string Word)
        {
            int counter = 0;
            if (!string.IsNullOrEmpty(Word))
                for (int i = 0; i < Word.Length; i++)
                    if (char.IsLower(Word[i]))
                        counter++;
            return counter;
        }
    }
}
