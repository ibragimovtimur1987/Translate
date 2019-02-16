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
            foreach (Position position in tree.AllPositions)
            {
                data.Replace(position.treeNode.Key, position.treeNode.Data);
            }
        }
    }
}
