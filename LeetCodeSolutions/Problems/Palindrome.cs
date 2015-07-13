using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems
{
    class Palindrome
    {
            //Check if int is a palindrome, what about single digit, double digit, odd vs even number of digits.
            public static bool IsPalindrome(int x)
            {
                string number = x.ToString();
                string firsth, lasth = "";
                if (number.Length % 2 != 0) //odd number of letters
                {
                    if (number.Length == 1)  //single digit
                    {
                        return true;
                    }
                    firsth = number.Substring(0, (number.Length - 1) / 2); //5 = 4/2 = 2
                    lasth = number.Substring(((number.Length - 1) / 2) + 1); //5 = 4/2 = 2+2 = 4
                }
                else
                {
                    if (number.Length == 2) //2 digits
                    {
                        if (number[0] == number[1])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    firsth = number.Substring(0, number.Length / 2);    //6= 0,3
                    lasth = number.Substring((number.Length / 2));    //6= 4+
                }

                if (firsth == Reverse(lasth))
                {
                    return true;
                }

                return false;
            }

            //Reverses strings
            public static string Reverse(string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }

            public static bool TestPalindromes()
            {
                //Single digit
                if (!IsPalindrome(5))
                    return false;
                if (!IsPalindrome(5665))
                    return false;
                if (IsPalindrome(566))
                    return false;
                if (IsPalindrome(56666666))
                    return false;
                if (!IsPalindrome(55555))
                    return false;
                if (!IsPalindrome(666))
                    return false;
                if (IsPalindrome(-2552))
                    return false;
                if (!IsPalindrome(506212605))
                    return false;
                 
                return true;
            }
        }
    
}
