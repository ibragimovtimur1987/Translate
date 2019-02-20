using Translate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate.Entites
{
    public class DictionaryMockV2: IDictionaryV2
    {
        public Dictionary<string, string> DictionaryWords
        {
            get
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                dictionary.Add("human", "человек");
                dictionary.Add("wolf", "волк");
                dictionary.Add("wolfhuman", "человекасобака");
                return dictionary;
            }
        }
    }
}
