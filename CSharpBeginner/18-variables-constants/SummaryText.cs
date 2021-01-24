using System;
using System.Collections.Generic;

namespace _CSharpFund
{
    public class SummaryText
    {

        public static string Sum(string sentence, int maxLength = 20 )
        {
            var summary = "";

            if (sentence.Length < maxLength)
            {
                return sentence;
            }
            else
            {
                var words = sentence.Split(' ');
                var totalCharacter = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacter += word.Length + 1;
                    if (totalCharacter > maxLength)
                    {
                        break;
                    }
                }

                summary = String.Join(" ", summaryWords);
            }
            return summary + "...";
        }
    }
}