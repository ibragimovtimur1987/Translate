using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate.Entites
{
    public class TreeNode
    {
        public int Id;
        public int ParentId;
        public string Key;
        public string Data;
        public int Lenght;
        List<Position> FindPositions;
        public TreeNode(int id,int parentId, string key, string data)
        {
            ParentId = parentId;
            Key = key;
            Data = data;
            Id = id;
            Lenght = Key.Length;
            FindPositions = new List<Position>();
        }
        public List<Position> SearchPositions(StringBuilder str, List<Position> allPositions)
        {
            int m = Key.Length;
            int n = str.Length;

            int[] badChar = new int[256];

            BadCharHeuristic(Key, m, ref badChar);

            int s = 0;
            while (s <= (n - m))
            {
                int j = m - 1;

                while (j >= 0 && Key[j] == str[s + j])
                    --j;

                if (j < 0)
                {
                    Position newPosition = new Position(s, s + Lenght, this);
                    FindPositions.Add(newPosition);
                    s += (s + m < n) ? m - badChar[str[s + m]] : 1;
                }
                else
                {
                    s += Math.Max(1, j - badChar[str[s + j]]);
                }
            }
            return FindPositions;
        }
        private void BadCharHeuristic(string str, int size, ref int[] badChar)
        {
            int i;

            for (i = 0; i < 256; i++)
                badChar[i] = -1;

            for (i = 0; i < size; i++)
                badChar[(int)str[i]] = i;
        }
    }
}
