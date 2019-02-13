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
                StringBuilder test = new StringBuilder("abcdeabcdeabcde");
                List<StringBuilder> inn = new List<StringBuilder>();
                inn.Add(test);
                return inn;
            }

        }
    }
}
