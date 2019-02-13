using Translate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate.Service
{
    class SearchWords
    {
        private IInputData iInputData;
        private IDictionaryWords iDictionary;
        public SearchWords(IInputData iInputData, IDictionaryWords iDictionary)
        {
            this.iInputData = iInputData;
            this.iDictionary = iDictionary;
        }
        public List<StringBuilder> Translate()
        {
            foreach (StringBuilder data in iInputData.data)
            {
                Dictionary<string, int[]> replaceDictionary = new Dictionary<string, int[]>();
                foreach (KeyValuePair<string, string> dictionaryWord in iDictionary.dictionaryWords)
                {
                    int[] indexes = SearchString(data, dictionaryWord.Key);


                    //for(int i = dictionaryWord.Key.Length; i==0;i--)
                    //{
                    //    dictionaryWord.Key.
                    //}
                    //int[] indexes = SearchString(data, dictionaryWord.Key);
                    //if (indexes.Count() > 0)
                    //{
                    //    replaceDictionary.Add(dictionaryWord.Key, indexes);
                    //}

                }
               
            }
            return iInputData.data;
        }
        private int[] SearchString(StringBuilder str, string pat)
        {
            List<int> retVal = new List<int>();
            int m = pat.Length;
            int n = str.Length;

            int[] badChar = new int[256];

            BadCharHeuristic(pat, m, ref badChar);

            int s = 0;
            while (s <= (n - m))
            {
                int j = m - 1;

                while (j >= 0 && pat[j] == str[s + j])
                    --j;

                if (j < 0)
                {
                    retVal.Add(s);
                    s += (s + m < n) ? m - badChar[str[s + m]] : 1;
                }
                else
                {
                    s += Math.Max(1, j - badChar[str[s + j]]);
                }
            }

            return retVal.ToArray();
        }

        private void BadCharHeuristic(string str, int size, ref int[] badChar)
        {
            int i;

            for (i = 0; i < 256; i++)
                badChar[i] = -1;

            for (i = 0; i < size; i++)
                badChar[(int)str[i]] = i;
        }
    }
}
