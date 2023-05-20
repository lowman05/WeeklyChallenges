using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subrtrahend)
        {
            double diff;
            diff = (minuend - subrtrahend);
            return diff;
        }

        public int Add(int number1, int number2)
        {
            int sum;
            sum = (number1 + number2);
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            int min;
            min = Math.Min(number1, number2);
            return min;
        }

        public long Multiply(long factor1, long factor2)
        {
            long multiple;
            multiple = factor1 * factor2;
            return multiple;
        }

        public string GetGreeting(string nameOfPerson)
        {
            string greeting = ($"Hello, {nameOfPerson}!");

            if (nameOfPerson == "")
            {
                return ("Hello!");
            }
            else
            {
                return greeting; 
            }
            
            
          
        }
        public string GetHey()
        {
            string howdy = "HEY!";
            return howdy;
        }
    }
}
