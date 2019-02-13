using Translate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translate.Entites;

namespace Translate.Service
{
    class TranslateWordsService : ITranslateWordsService
    {
        private IInputData iInputData;
        private IDictionaryWords iDictionary;
        private IReplaceWordsService iReplaceWordsService;
        public TranslateWordsService(IInputData iInputData, IDictionaryWords iDictionary, IReplaceWordsService ReplaceWordsService)
        {
            this.iInputData = iInputData;
            this.iDictionary = iDictionary;
            this.iReplaceWordsService = ReplaceWordsService;
        }
        public List<StringBuilder> Translate()
        {
            List<StringBuilder> outPutResult = new List<StringBuilder>();
            foreach (StringBuilder data in iInputData.data)
            {
                List<TreeNode<int, string>> result = new List<TreeNode<int, string>>();
                FillTreeNode(data, 0, result);
                iReplaceWordsService.Replace(data, result);
                outPutResult.Add(data);
            }
            return outPutResult;
        }

        private void FillTreeNode(StringBuilder data, int index, List<TreeNode<int, string>> result)
        {
            foreach (TreeNode<int, string> treeNode in iDictionary.treeDictionaryWords.Where(x => x.ParentId == index))
            {
                treeNode.SearchString(data);
                if (treeNode.FindPositions.Count() == 0)
                {
                    FillTreeNode(data, treeNode.Id, result);
                }
                else
                {

                    result.Add(treeNode);
                }
            }
        }
        //private bool CheckForAdd(List<TreeNode<int, string>> result, TreeNode<int, string> treeNode)
        //{
        //    foreach (var treenode in result)
        //    {
        //        foreach (var p in treenode.FindPositions)
        //        {
        //            int min = p.Key;
        //            int max = p.Value;

        //            if (treeNode.FindPositions. < min && treeNode.Value > max)
        //            {
        //            }
        //        }
        //    }
        //}
    }
}
