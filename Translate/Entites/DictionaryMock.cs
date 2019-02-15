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
                TreeNode treeNode1 = new TreeNode(1,0, "abc", "yyy");
                TreeNode treeNode2 = new TreeNode(1,1, "ab", "yk");
                TreeNode treeNode3 = new TreeNode(2, 0, "vfr", "yk");
                TreeNode treeNode4 = new TreeNode(4, 0, "dea", "ykdea");
                treeDictionaryWords.Add(treeNode1);
                treeDictionaryWords.Add(treeNode2);
                treeDictionaryWords.Add(treeNode3);
                treeDictionaryWords.Add(treeNode4);
                return treeDictionaryWords;
            }
        }
    }
}
