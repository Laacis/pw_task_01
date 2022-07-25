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
            //looks like they want us to do a recursion here
            if (startIndex == word.Length)
            {
                if(!result.Contains(new string(word)))result.Add(new string(word)); return; //checking for dublicates.
            }
            if (char.IsLetter(word[startIndex])) //drops in if the char is letter, if not, no need to change to lower/upper.
            {
                word[startIndex] = char.ToLower(word[startIndex]);
                AlternateCharCases(word, startIndex + 1, result);
                word[startIndex] = char.ToUpper(word[startIndex]);
                AlternateCharCases(word, startIndex + 1, result);
            }
            else AlternateCharCases(word, startIndex + 1, result);

        }
    }
}