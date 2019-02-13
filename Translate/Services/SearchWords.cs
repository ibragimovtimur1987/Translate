using Translate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translate.Entites;

namespace Translate.Service
{
    class SearchWords
    {
        private IInputData iInputData;
        private IDictionaryWords iDictionary;
        private List<TreeNode<int, string>> findListTreeNode;
        public SearchWords(IInputData iInputData, IDictionaryWords iDictionary)
        {
            this.iInputData = iInputData;
            this.iDictionary = iDictionary;
            findListTreeNode = new List<TreeNode<int, string>>();
        }
        public List<StringBuilder> Translate()
        {
            foreach (StringBuilder data in iInputData.data)
            {
                List<TreeNode<int, string>> tree = new List<TreeNode<int, string>>();
                FillTreeNode(data,0);
            }
            return iInputData.data;
        }

        private void FillTreeNode(StringBuilder data,int index)
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
                    findListTreeNode.Add(treeNode);
                }
            }
        }
    }
}
