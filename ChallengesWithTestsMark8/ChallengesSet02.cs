using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       

        public bool CountOfElementsIsEven(string[] vals)
        {



            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsNumberEven(int number)
        {

            if (number % 2 == 0)
            {
                return true;
            }
            else if (number % 2 == 1)
            {
                return false;
            }
            else
            {
                return false;
            }

        }

        public bool IsNumberOdd(int num)
        {

            if (num % 2 != 0)
            {
                return true;
            }
            else if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return false;
            }

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
           

            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max(); 
            }
        }   
           
                
            
            
            
                
            


        

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
     
        }
        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Sum(); 

            }
        }

        public int SumEvens(int[] numbers)

        {
            int sum = 0; 
            if (numbers == null)
            {
                return 0;
            }

            foreach  (int num in numbers)
            {
                if (num % 2 == 0 )
                {
                    sum += num;
                    
                }
            }
            return sum;
        }
                     
               
                       
                  
       

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            { 
                return false; 
            }

            return (numbers.Sum() % 2 != 0);
                    
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
           if(number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
