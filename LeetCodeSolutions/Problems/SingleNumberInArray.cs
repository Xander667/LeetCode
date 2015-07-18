using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems
{
    class SingleNumberInArray
    {
        
        public static int SingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }
            return result;
        }

    }
}