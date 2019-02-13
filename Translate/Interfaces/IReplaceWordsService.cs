using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translate.Entites;

namespace Translate.Interfaces
{
    interface IReplaceWordsService
    {
        void Replace(StringBuilder data, List<TreeNode<int, string>> findString);
    }
}
