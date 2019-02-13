using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translate.Interfaces;

namespace Translate.Entites
{
    public class Tree
    {
        public List<TreeNode<int, string>> result = new List<TreeNode<int, string>>();
        private IDictionaryWords iDictionary;
        internal Tree(IDictionaryWords iDictionary)
        {
            this.iDictionary = iDictionary;
        }
        public void FillTreeNode(StringBuilder data, int index)
        {
            foreach (TreeNode<int, string> treeNode in iDictionary.treeDictionaryWords.Where(x => x.ParentId == index))
            {
                 
                treeNode.SearchString(data);
                if (treeNode.FindPositions.Count() == 0)
                {
                    FillTreeNode(data, treeNode.Id);
                }
                else
                {
                    result.Add(treeNode);
                }
            }
        }
    }
}
