using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate.Entites
{
    public class Position
    {
        TreeNode treeNode;
        public int start;
        public int finish;
        public Position(int start, int finish, TreeNode treeNode)
        {
            this.start = start;
            this.finish = finish;
            this.treeNode = treeNode;
        }
     
    }
}
