using System;
using System.Collections.Generic;
using System.Linq;

namespace Passwords
{
    public class CaseAlternatorTask
    {
        //Тесты будут вызывать этот метод
        public static List<string> AlternateCharCases(string lowercaseWord)
        {
            var result = new List<string>();
            AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
            return result;
        }

        static void AlternateCharCases(char[] word, int startIndex, List<string> result)
        {
            // solution two
            if (startIndex == word.Length)
            {
                result.Add(new string(word));
                return;
            }
            word[startIndex] = char.ToLower(word[startIndex]);
            AlternateCharCases(word, startIndex + 1, result);
            //only if char upper and lower make difference and it's a character, we are going to change and call it again, since we don't want to have extra operations to run.
            if(char.ToUpper(word[startIndex]) != char.ToLower(word[startIndex]) && char.IsLetter(word[startIndex]))
            {
                word[startIndex] = char.ToUpper(word[startIndex]);
                AlternateCharCases(word, startIndex + 1, result);
            }
            //by doing this, we save up number of operations to be performed, to compute dublicates and to get rid of them.
        }
    }
}