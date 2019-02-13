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
        public void Replace(StringBuilder data, Tree findTreeNode)
        {
            var indexes = findTreeNode..Select(x =>x.).ToList();


            foreach (TreeNode<int, string> node in findTreeNode)
            {
                data.Replace(node.Key, node.Data);
            }
        }
    }
}
