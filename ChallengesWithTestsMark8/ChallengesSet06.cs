using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;
            foreach (var item in words)
            {
                if (string.Compare(item, word, ignoreCase) == 0)
                {
                    return true;
                }
            }
            return false;
        }   

        public bool IsPrimeNumber(int num)
        {
            if(num <= 1)
            {
                return false;
            }
            for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
            {
                if (num % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            for (int i = str.Length -1; i >= 0; i--)
            {
                char currentChar = str[i];
                if (letters.ContainsKey(currentChar))
                {
                    letters[currentChar]++;
                }
                else
                {
                    letters[currentChar] = 1;
                }
            }
            for (int i =str.Length -1;i >= 0; i--)
            {
                char currentChar = str[i]; ;
                if (letters[currentChar] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int max = 0;
            int current = 0;
            for (int i =0; i < numbers.Length; i++)
            {
                if (i > 0 && numbers[i] == numbers[i - 1])
                {
                    current++;
                }
                else
                {
                    current = 1; 
                }
                if (current > max)
                {
                    max = current;
                }                
            }
            return max;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n < 0)
            {
                return new double[0];
            }
            List<double> result = new List<double>();
            for (int i = n-1; i < elements.Count(); i += n)
            {

                result.Add(elements [i]);
            }
            return result.ToArray();
        } 
    }
}
