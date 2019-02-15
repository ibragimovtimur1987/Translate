using Translate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translate.Entites;

namespace Translate.Service
{
    class ReplaceWordsService: IReplaceWordsService
    {
        public void Replace(StringBuilder data, Tree tree)
        {
            foreach (TreeNode node in tree.treeNodes)
            {
                data.Replace(node.Key, node.Data);
            }
        }
    }
}
