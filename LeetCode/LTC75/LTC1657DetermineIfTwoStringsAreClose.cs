﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
internal class LTC1657DetermineIfTwoStringsAreClose
{

        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }
            int[] count1 = new int[26];
            int[] count2 = new int[26];

            for (int i = 0; i < word1.Length; i++)
            {
                count1[word1[i] - 'a']++;
                count2[word2[i] - 'a']++;
            }

            for (int i = 0; i < 26; i++)
            {
                if (count1[i] == 0 && count2[i] != 0 || count1[i] != 0 && count2[i] == 0)
                {
                    return false;
                }
            }
            Array.Sort(count1);
            Array.Sort(count2);
            for (int i = 0; i < 26; i++)
            {
                if (count1[i] != count2[i])
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}
