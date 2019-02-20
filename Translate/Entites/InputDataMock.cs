using Translate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate.Entites
{
    public class InputDataMock: IInputData
    {
        public List<StringBuilder> data
        {
            get
            {
                //StringBuilder test1 = new StringBuilder("ibragimovtimur");
                //StringBuilder test2 = new StringBuilder("timuribragim");
                //StringBuilder test3 = new StringBuilder("ibribrhjklyteedc");
                //StringBuilder test4 = new StringBuilder("hhhhhhhhhhhhh");
                //List<StringBuilder> inn = new List<StringBuilder>();
                //inn.Add(test1);
                //inn.Add(test2);
                //inn.Add(test3);
                //inn.Add(test4);
                //return inn;
                List <StringBuilder> dictionaryWords = new List<StringBuilder>();
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
                    StringBuilder word = new StringBuilder("");
                    for (int j = 1; j <= num_letters; j++)
                    {
                        // Выбор случайного числа от 0 до 25
                        // для выбора буквы из массива букв.
                        int letter_num = rand.Next(0, letters.Length - 1);

                        // Добавить письмо.
                        word.Append(letters[letter_num]);
                    }

                    // Добавьте слово в список.
                    dictionaryWords.Add(word);
                }
                return dictionaryWords;
            }

        }
          
    }
}
