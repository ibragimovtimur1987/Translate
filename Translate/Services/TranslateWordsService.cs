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
                Tree tree = new Tree(iDictionary);
                tree.FillTreeNode(data, 0);
                iReplaceWordsService.Replace(data, tree);
                outPutResult.Add(data);
            }
            return outPutResult;
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
