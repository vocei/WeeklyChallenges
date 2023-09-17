using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {

            return vals != null && vals.Length != 0 && vals.Contains(false);
        }
        
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;    
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                { 
                    sum += number; 
}
            }

            return sum % 2 != 0;

                //return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
            }

            public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isDigit = false;
            bool isUpper = false;
            bool isLetter = false;

            foreach (var letter in password)
            {
                if (char.IsLower(letter))
                {
                    isLetter = true;
                }
                if (char.IsDigit(letter))
                {
                    isDigit = true;
                }
                if (char.IsUpper(letter))
                {
                    isUpper = true;
                }
            }

            return isDigit && isUpper && isLetter;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            decimal result = 0;
            if (divisor == 0)
            {
                return 0;
            }
            if (dividend == 1) 
            {
                return 0;
            }
            return dividend / divisor;

            // return divisor == 0 ? 0 : divident / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            int difference = nums[^1] - nums[0];
            return difference;
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();
            //int index = 0;
            //int[] myArray = new int[50];
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                   odds.Add(i);
                }
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++) 
            {
            words[i] = words[i].ToUpper();
            }
        }
    }
}
