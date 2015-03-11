using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMLComparator
{
    public static class clsCompare
    {
        public static double percentage(string a, string b)
        {            
            double percent;

            if (a == b) //Same string, no iteration needed.
                return percent = 100;
            if ((a.Length == 0) || (b.Length == 0)) //One is empty, second is not
            {
                return percent = 0;
            }
            double maxLen = a.Length > b.Length ? a.Length : b.Length;
            int minLen = a.Length < b.Length ? a.Length : b.Length;
            int sameCharAtIndex = 0;
            for (int i = 0; i < minLen; i++) //Compare char by char
            {
                if (a[i] == b[i])
                {
                    sameCharAtIndex++;
                }
            }
            percent = sameCharAtIndex / maxLen * 100;
            return percent;
          }        
       }
    }
