using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translate.Entites;

namespace Translate.Interfaces
{
    interface IDictionaryV2
    {
        Dictionary<string, string> DictionaryWords
        {
            get;
        }
    }
}
