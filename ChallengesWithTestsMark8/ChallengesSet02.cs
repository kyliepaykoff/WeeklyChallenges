﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
           
            foreach (var letter in alphabet) 
            { 
                if (letter == c) return true;            
            }
           return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            { return true; }
            else return false; 
        }

        public bool IsNumberEven(int number)
        {
           if (number % 2 ==0) { return true;}
           return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0) { return true; } else return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }

            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (double number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }

            return min + max;
        }




        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
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
            else return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
           if(numbers == null) { return 0; }
           return numbers.Where(x => x % 2 ==0).Sum();
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {  return false; }
            return numbers.Sum() % 2 != 0;
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
