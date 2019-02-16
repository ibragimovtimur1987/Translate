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
        public List<Position> AllPositions = new List<Position>();
        public List<TreeNode> treeNodes = new List<TreeNode>();
        private IDictionaryWords iDictionary;
        internal Tree(IDictionaryWords iDictionary)
        {
            this.iDictionary = iDictionary;
        }
        public void FillTreeNode(StringBuilder data, int index)
        {
            foreach (TreeNode treeNode in iDictionary.treeDictionaryWords.Where(x => x.ParentId == index))
            {
                List<Position> findPositions = treeNode.SearchPositions(data, AllPositions);
                //Найдено совпадение в строке по дереву , идем вниз по дереву 
                if (findPositions.Count>0)
                {                    
                    treeNodes.Add(treeNode);
                    AllPositions.OrderBy(x => x.start);
                    foreach(Position newPosition in findPositions)
                    {
                        if (AllPositions.Count == 0 || AllPositions.All(x => (x.finish < newPosition.start)))
                        {
                            AllPositions.Add(newPosition);
                        }
                    }
                                    
                }
                else
                {
                    FillTreeNode(data, treeNode.Id);
                }
            }
        }
    }
}
