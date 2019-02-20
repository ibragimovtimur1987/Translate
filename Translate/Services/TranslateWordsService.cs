﻿using Translate.Interfaces;
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
            int i = 0;
            foreach (StringBuilder data in iInputData.data)
            {
                i++;
                Tree tree = new Tree(iDictionary);
                tree.FillTreeNode(data, 0);
                bool isReplaced = iReplaceWordsService.Replace(data, tree);
                if(isReplaced) outPutResult.Add(data);
                if (i == 5)  Console.WriteLine("Строка номер {0} {1}",i ,DateTime.Now.ToLongTimeString());
                if (i == 10) Console.WriteLine("Строка номер {0} {1}",i ,DateTime.Now.ToLongTimeString());
                if (i ==20 ) Console.WriteLine("Строка номер {0} {1}",i ,DateTime.Now.ToLongTimeString());
                if (i == 50) Console.WriteLine("Строка номер {0} {1}",i ,DateTime.Now.ToLongTimeString());
                if (i == 100)Console.WriteLine("Строка номер {0} {1}", i, DateTime.Now.ToLongTimeString());
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
