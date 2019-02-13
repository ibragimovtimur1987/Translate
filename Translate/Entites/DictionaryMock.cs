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
        public List<TreeNode<int, string>> treeDictionaryWords
        {
            get
            {
                List<TreeNode<int, string>> treeDictionaryWords = new List<TreeNode<int, string>>();
                TreeNode<int, string> treeNode1 = new TreeNode<int, string>(1,0, "abc", "yyy");
                TreeNode<int, string> treeNode2 = new TreeNode<int, string>(1,1, "ab", "yk");
                TreeNode<int, string> treeNode3 = new TreeNode<int, string>(2, 0, "vfr", "yk");
                TreeNode<int, string> treeNode4 = new TreeNode<int, string>(4, 0, "dea", "ykdea");
                treeDictionaryWords.Add(treeNode1);
                treeDictionaryWords.Add(treeNode2);
                treeDictionaryWords.Add(treeNode3);
                treeDictionaryWords.Add(treeNode4);
                return treeDictionaryWords;
            }
        }
    }
}
