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
                StringBuilder test1 = new StringBuilder("ibragimovtimur");
                StringBuilder test2 = new StringBuilder("timuribragim");
                StringBuilder test3 = new StringBuilder("ibribrhjklyteedc");
                StringBuilder test4 = new StringBuilder("hhhhhhhhhhhhh");
                List<StringBuilder> inn = new List<StringBuilder>();
                inn.Add(test1);
                inn.Add(test2);
                inn.Add(test3);
                inn.Add(test4);
                return inn;
            }

        }
    }
}
