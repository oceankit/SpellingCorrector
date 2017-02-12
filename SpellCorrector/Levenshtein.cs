using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCorrector
{
    class Levenshtein
    {
        public List<KeyValuePair<int, string>> CalculationDistance(string []lines, string word)
        {
            List<KeyValuePair<int, string>> ans = new List<KeyValuePair<int, string>>();
            int size = lines.Length;
            for (int i = 1; i < size; i++)
            {
                int temp = LevenshteinAlgorythm(lines[i], word);
                ans.Add(new KeyValuePair<int, string>(temp, lines[i]));
            }
            return ans;
        }

        public int LevenshteinAlgorythm(string a, string b)
        {
            int sizeofa = a.Length;
            int sizeofb = b.Length;
            int[,] D = new int[sizeofa+1, sizeofb+1];
            int min = 0;
            if (sizeofa == 0)
            {
                return sizeofb;
            }
            if (sizeofb == 0)
            {
                return sizeofa;
            }
            for (int i = 0; i <= sizeofa; i++)
            {
                D[i,0] = i;
            }
            for (int j = 0; j <= sizeofb; j++)
            {
                D[0,j] = j;
            }
            for (int i = 1; i <= sizeofa; i++)
            {
                for (int j = 1; j <= sizeofb; j++)
                {
                    int diff;
                    if (b[j - 1] == a[i - 1])
                    {
                        diff = 0;
                    }
                    else diff = 2;

                    int f = D[i - 1, j] + 1;
                    int s = D[i, j - 1] + 1;
                    int t = D[i - 1, j - 1] + diff;
                    min = f;
                    if (s < min)
                    {
                        min = s;
                    }
                    if (t < min)
                    {
                        min = t;
                    }
                    D[i, j] = min;
                }
            }
            return D[sizeofa, sizeofb];
        }
        
    }
}
