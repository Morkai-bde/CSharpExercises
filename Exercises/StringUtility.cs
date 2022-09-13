using System;
using System.Collections.Generic;

namespace Exercises
{
    public class StringUtility
    {
            public static string SummerizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;
            
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summeryWords = new List<String>();

            foreach (var word in words)
            {
                summeryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }
            return String.Join(" ", summeryWords) + "...";
        }
    }
}
