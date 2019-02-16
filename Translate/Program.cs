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
            // ISearchWordsService searchWordsService = ninjectKernel.Get<ISearchWordsService>();
            IReplaceWordsService replaceWordsService = ninjectKernel.Get<IReplaceWordsService>();
            TranslateWordsService translateWords = new TranslateWordsService(inputData, dictionaryWords, replaceWordsService);
            List<StringBuilder> result = translateWords.Translate();

            Console.ReadKey();
        }
    }
}
