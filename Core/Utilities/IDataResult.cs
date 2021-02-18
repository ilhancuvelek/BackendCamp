using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public interface IDataResult<T> : IResult//IResult a ek bir datamız olacak
    {
        T Data { get; set; }
    }
}
