using LeetCodeSolutions.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = SingleNumberInArray.SingleNumber(new int[] { 5, 5, 6, 6, 7 });
            bool result = Palindrome.TestPalindromes(); //true = pass, false = fail
        }
    }
}
