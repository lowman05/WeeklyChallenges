using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var addEven = numbers.Where(x => x % 2 == 0);
            var subtractOdd = numbers.Where(x => x % 2 != 0);
            return addEven.Sum() - subtractOdd.Sum();
            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> strings = new List<string>();
            strings.Add(str1);
            strings.Add(str2);
            strings.Add(str3);
            strings.Add(str4);
            var shortestString = strings.Min(s => s.Length);
            return shortestString;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numbers = new List<int>();
            numbers.Add(number1);
            numbers.Add(number2);
            numbers.Add(number3);
            numbers.Add(number4);
            var smallestNumber = numbers.Min();
            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            var newName = new Business();
            newName.Name = "TrueCoders";
            biz.Name = newName.Name;
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            
           if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2)
            {
                return true;  
            }
           else
            {
                return false;
            }
             

        }

        public bool IsStringANumber(string input)
        {
            bool isNumber = double.TryParse(input, out double number);
            if (isNumber)
            {
                return true;
            }
            else { return false; }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int total = objs.Length;
            int nulls = objs.Count(element  => element == null);
            bool isMajorityNull = nulls > total / 2; 
            return isMajorityNull;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            
            int evenSum = 0;
            int evensCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                    evensCount++;
                }
            }
            double evenAverage = evensCount > 0 ?  Convert.ToDouble(evenSum) / evensCount : 0;
            return evenAverage;     
                                         
    
        }

        public int Factorial(int number)
        {

            if (number  < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Factorial is not defined for negative numbers");
            }
            
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number-1);

            }
        }  
    }
}
