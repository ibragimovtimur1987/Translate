using Translate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate.Entites
{
    public class DictionaryMock: IDictionaryWords
    {
        public List<TreeNode> treeDictionaryWords
        {
            get
            {
                List<TreeNode> treeDictionaryWords = new List<TreeNode>();
                TreeNode treeNode1 = new TreeNode(1,0, "ibragim", "petrov");
                TreeNode treeNode2 = new TreeNode(2,1, "ibr", "pet");
                TreeNode treeNode3 = new TreeNode(3, 0, "agim", "rov");
                TreeNode treeNode4 = new TreeNode(4, 3, "agimov", "trov");
                TreeNode treeNode5 = new TreeNode(5, 0, "movtimur", "trovivan");
                TreeNode treeNode6 = new TreeNode(6, 0, "timur", "ivan");
                TreeNode treeNode7 = new TreeNode(7, 6, "tim", "iv");
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
