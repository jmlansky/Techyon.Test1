using System;
using System.Linq;

namespace FirstTest
{
    public static class Words
    {

        public static bool AreAnagramWords(string word1, string word2)
        {
            word1 = word1.ToLower();
            word2 = word2.ToLower();

            if (word1.Length != word2.Length)
                return false;

            if (word1.Equals(word2))
                return true;

            var w1 = string.Concat(word1.OrderBy(c => c));
            var w2 = string.Concat(word2.OrderBy(c => c));

            return w1.Equals(w2);
        }

        public static bool IsPalindrome(string word)
        {
            word = word.Replace(" ", "");
            return word.SequenceEqual(word.Reverse());
        }       
    }
}