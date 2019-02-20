using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translate.Entites;
using Translate.Interfaces;
using Translate.Service;

namespace Translate
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IInputData>().To<InputDataMock>();
            ninjectKernel.Bind<IDictionaryWords>().To<DictionaryMock>();
            ninjectKernel.Bind<IReplaceWordsService>().To<ReplaceWordsService>();
            IInputData inputData = ninjectKernel.Get<IInputData>();
            IDictionaryWords dictionaryWords = ninjectKernel.Get<IDictionaryWords>();
            IReplaceWordsService replaceWordsService = ninjectKernel.Get<IReplaceWordsService>();
            Console.WriteLine(String.Format("Начало программы " + DateTime.Now.ToLongTimeString()));
            TranslateWordsService translateWords = new TranslateWordsService(inputData, dictionaryWords, replaceWordsService);
            List<StringBuilder> result = translateWords.Translate();
            Console.WriteLine(String.Format("Окончание программы {0} было заменено строк {1}",DateTime.Now.ToLongTimeString(), result.Count));
            Console.ReadKey();
        }
    }
}
