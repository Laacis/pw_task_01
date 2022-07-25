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
            if(char.ToUpper(word[startIndex]) != char.ToLower(word[startIndex]) && char.IsLetter(word[startIndex]))
            {
                word[startIndex] = char.ToUpper(word[startIndex]);
                AlternateCharCases(word, startIndex + 1, result);
            }

        }
    }
}