using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)//ikili değer yollarsak hem bu hem de bu classdaki aşağıdaki  
        {                                            //tek parametreli ctor çalışır.tek yollarsam aşağıdaki
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
