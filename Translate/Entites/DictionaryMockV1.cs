using Translate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate.Entites
{
    public class DictionaryMockV1: IDictionaryV1
    {
        public List<TreeNode> treeDictionaryWords
        {
            get
            {
                List<TreeNode> treeDictionaryWords = new List<TreeNode>();
                TreeNode treeNode1 = new TreeNode(1,0, "ibragim", "ибрагим");
                TreeNode treeNode2 = new TreeNode(2,1, "ibr", "ибр");
                TreeNode treeNode3 = new TreeNode(3, 0, "agim", "ров");
                TreeNode treeNode4 = new TreeNode(4, 3, "agimov", "агимов");
                TreeNode treeNode5 = new TreeNode(5, 0, "movtimur", "мовтимур");
                TreeNode treeNode6 = new TreeNode(6, 0, "timur", "тимур");
                TreeNode treeNode7 = new TreeNode(7, 6, "tim", "тим");
                treeDictionaryWords.Add(treeNode1);
                treeDictionaryWords.Add(treeNode2);
                treeDictionaryWords.Add(treeNode3);
                treeDictionaryWords.Add(treeNode4);
                treeDictionaryWords.Add(treeNode5);
                treeDictionaryWords.Add(treeNode6);
                treeDictionaryWords.Add(treeNode7);
                return treeDictionaryWords;
            }
        }
    }
}
