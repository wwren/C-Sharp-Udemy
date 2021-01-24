using System;
using System.Linq;

namespace System
{
    public static class StringExtensions // naming convention
    {
        public static string Shorten(this String str, int numberOfWords) //this String str*, it allows us to use static method on an instance object
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0.");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}