using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translate.Interfaces;

namespace Translate.Services
{
    class TranslateServiceV2
    {
        private IInputData iInputData;
        IDictionaryV2 iDictionaryV2;
        public TranslateServiceV2(IInputData iInputData, IDictionaryV2 iDictionaryV2)
        {
            this.iInputData = iInputData;
            this.iDictionaryV2 = iDictionaryV2;
        }
        public List<StringBuilder> TranslateWord()
        {
            Dictionary<string, string> dictionary = iDictionaryV2.DictionaryWords;
            //dictionary.Add("human", "человек");
            //dictionary.Add("wolf", "волк");
            //string inputStr1 = "humancameout";
            //string inputStr2 = "wolf";
            List<StringBuilder> listOut = new List<StringBuilder>();
            foreach (StringBuilder inputStr in iInputData.data)
            {
                StringBuilder outData = new StringBuilder();
                StringBuilder strCheck = new StringBuilder();
                for (int i = 0; i < inputStr.Length; i++)
                {
                    strCheck.Append(inputStr[i]);
                    if (dictionary.ContainsKey(strCheck.ToString()))
                    {
                        string value = "";
                        dictionary.TryGetValue(strCheck.ToString(), out value);
                        outData.Append(value);
                        strCheck.Clear();
                    }
                    else if (i == inputStr.Length - 1)
                    {
                        outData.Append(strCheck);
                    }
                }
                listOut.Add(outData);
            }
            return listOut;
        }
    }
}
