using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //c = 'c'
            //or c = 'C'
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string uppercaseAlplhabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char letter in lowercaseAlphabet)
            {
                if (c == letter)
                {
                    return true;
                }
            }
            foreach ( char letter2 in uppercaseAlplhabet)
            {
                if (c == letter2)
                {
                return true;
                }
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //{"1 string", "2 string"} <-- this collection has 2 strings. 2 is an even number so it is true
            //10 / 2 = 5 remainder 0
            //2/9 = 4 remainer 1
            if (vals.Count() % 2 == 0)
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
            //vars check = (number % 2 == 0) ? true : false; 
            //return check
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num < 0)
            {
                num = num * -1;
            }
            if (num % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }

            double minValue = numbers.Min();
            double maxValue = numbers.Max();
            return minValue + maxValue;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Count() == str2.Count())
            { 
                return str1.Count(); 
            }
            if (str1.Count() > str2.Count())

            {
                return str2.Count();
            }
            else
            {
                return str1.Count();
                    
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var temporaryList = new List<int>();
            for (int k = 0; k < numbers.Length; k++)
            {
                if (numbers[k] % 2 == 0)
                {
                    temporaryList.Add(numbers[k]);
                }
            }
            return temporaryList.Sum();

        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            return false;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            // return 0 if negative number
            // number = 10
            // is 1 odd? yes count it!
            // is 2 odd? no skip it
            // is 3 odd? yes count it
            // continue to 10
            // count = 5
            if (0 >= number) 
            {
                return 0;
            }
            else  
            {
                return (number / 2);
            }
        }
    }
}
