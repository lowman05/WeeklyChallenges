using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int nextNumber = startNumber + 1;
            while (nextNumber % n != 0)
            {
                nextNumber++;
            }
            return nextNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            var newName = new Business();
            
            newName.Name = "CLOSED";
            for (var i = 0; i < businesses.Length; i++)
            if (businesses[i].TotalRevenue == 0) 
            {
               businesses[i].Name = newName.Name;
            }
          
            
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
           if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
           int sum = 0;
           bool foundEven = false;
            
           for (int i = 0; i < numbers.Length; i++)
            {
                if (foundEven)
                {
                    sum += numbers[i];
                    foundEven = false;
                }
                if (numbers[i] % 2 == 0)
                {
                    foundEven = true;
                }
            }

            return sum;     
                               
            
            
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            char punctuation = '.';
            if (words == null || words.Length == 0)
            {/**/
                return string.Empty;
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string word in words)
            {
                string trimmedWord= word?.Trim();
                if (!string.IsNullOrEmpty(trimmedWord))
                {
                    stringBuilder.Append(trimmedWord);
                    stringBuilder.Append(' ');
                }
            }
            string sentence = stringBuilder.ToString().Trim();
            if (!string.IsNullOrEmpty(sentence))
            {
                sentence = char.ToUpper(sentence[0]) + sentence.Substring(1);
                sentence += punctuation;
            }
            return sentence;                    
        } 
        
               
            
            
         
           

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            List<double> result = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }
           
            return result.ToArray();
        }   

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null)
            {
                return false;
            }
            for (int i =0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
