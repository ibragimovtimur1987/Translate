using Translate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate.Entites
{
    public class DictionaryMock: IDictionaryWords
    {
        public Dictionary<string, string> dictionaryWords
        {
            get
            {
                var _dictionaryWords = new Dictionary<string, string>();
                _dictionaryWords.Add("abc", "yyy");
                return _dictionaryWords;
            }
        }
    }
}
