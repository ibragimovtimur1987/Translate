using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate.Entites
{
    class InputData 
    {
        public List<string> lstWords;
        public List<string> GetInputData()
        {
            lstWords = new List<string>();
            // Получаем количество слов и букв за слово.
            int num_letters = 100;
            int num_words = 100;

            // Создаем массив букв, которые мы будем использовать.
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            // Создаем генератор случайных чисел.
            Random rand = new Random();

            // Делаем слова.
            for (int i = 1; i <= num_words; i++)
            {
                // Сделайте слово.
                string word = "";
                for (int j = 1; j <= num_letters; j++)
                {
                    // Выбор случайного числа от 0 до 25
                    // для выбора буквы из массива букв.
                    int letter_num = rand.Next(0, letters.Length - 1);

                    // Добавить письмо.
                    word += letters[letter_num];
                }
                lstWords.Add(word);
            }
            return lstWords;
            // Добавьте слово в список.

        }
    }
}
