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
            IInputData inputData = ninjectKernel.Get<IInputData>();
            IDictionaryWords dictionaryWords = ninjectKernel.Get<IDictionaryWords>();
            SearchWords searchWords = new SearchWords(inputData, dictionaryWords);
            searchWords.Translate();
        }
    }
}
