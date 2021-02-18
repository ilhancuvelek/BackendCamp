using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message)//base result sınıfı demek
            : base(false, message)

        {

        }
        public ErrorResult()//bu tek parametreli için mesaj yollamak istemiyorum mesela
            : base(false)
        {

        }
    }
}
