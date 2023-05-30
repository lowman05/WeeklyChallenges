using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false); 
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) return false;
            int sumOfOdds = 0;
            foreach (int num  in numbers)
            {
                if (num % 2 != 0)
                {
                    sumOfOdds += num;
                }
            }
            bool isSumOfOddsOdd = sumOfOdds % 2 != 0; 
            return isSumOfOddsOdd;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool digit = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    upper = true;
                }
                else if (char.IsLower(c))
                {
                    lower = true;
                }
                else if (char.IsDigit(c))
                {
                    digit =  true;
                }
                if(upper && lower && digit)
                {
                    break; 
                }               

            }  
            if (upper && lower && digit)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public char GetFirstLetterOfString(string val)
        {
            char firstLetter = val.First(); 
            return firstLetter;
        }

        public char GetLastLetterOfString(string val)
        {
            char firstLetter = val.Last();
            return firstLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            int numfirst = nums.First();
            int numlast = nums.Last();  
            return numlast - numfirst;
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddNumbers = new List<int>(); 
            for (int i = 1; i < 100; i += 2)
            {
                oddNumbers.Add(i);
            }
            int[] oddNumbersArray = oddNumbers.ToArray();
            return oddNumbersArray;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i  = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
