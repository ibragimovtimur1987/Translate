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
        public List<TreeNode> _treeDictionaryWords ;
        
        public List<TreeNode> treeDictionaryWords
        {
            get
            {
                if (_treeDictionaryWords != null) return _treeDictionaryWords;
                else
                {

                    _treeDictionaryWords = new List<TreeNode>();
                    int num_words = 100000;
                    // Создаем массив букв, которые мы будем использовать.
                    char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

                    // Создаем генератор случайных чисел.
                    Random rand = new Random();

                    // Делаем слова.
                    for (int i = 1; i <= num_words; i++)
                    {
                        Random randKey = new Random();
                        int num_Key = randKey.Next(1, 8);
                        Random randValue = new Random();
                        int num_Value = randValue.Next(1, 20);
                        // Сделайте слово.
                        StringBuilder word = new StringBuilder("");
                        for (int j = 1; j <= num_Key; j++)
                        {
                            // Выбор случайного числа от 0 до 25
                            // для выбора буквы из массива букв.
                            int letter_num = rand.Next(0, letters.Length - 1);

                            // Добавить письмо.
                            word.Append(letters[letter_num]);
                        }
                        string wordStr = word.ToString();
                        TreeNode treeNode = new TreeNode(i, GetParentID(wordStr), wordStr, RandomString(num_Value));
                        // Добавьте слово в список.
                        _treeDictionaryWords.Add(treeNode);
                    }
                    return _treeDictionaryWords;
                }
            }
        }
        private int GetParentID(string word)
        {
            TreeNode parent =_treeDictionaryWords.FirstOrDefault(x => x.Key.Contains(word.ToString()));
            if (parent != null)
                return parent.Id;
            else return 0;

        }
            private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}
