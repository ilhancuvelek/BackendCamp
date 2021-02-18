using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message)//base result sınıfı demek
            : base(true, message)

        {

        }
        public SuccessResult()//bu tek parametreli için mesaj yollamak istemiyorum mesela
            : base(true)
        {

        }
    }
}
