using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            char[] splitString = word.ToCharArray();
            char[] compare = new char[splitString.Length];
            int count = 0;
            for(int i = splitString.Length - 1; i >= 0; i--)
            {
                compare[count] = splitString[i];
                count++;
            }
            for(int i = 0; i < splitString.Length; i++)
            {
                if (splitString[i] != compare[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
