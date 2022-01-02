using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
            //data+mesaj+daima true
        }
        public ErrorDataResult(T data) : base(data, false)
        {
            //data+daima true
        }
        public ErrorDataResult(string message) : base(default, false, message)
        {
            //mesaj+daima true
        }
        public ErrorDataResult() : base(default, false)
        {
            //daima true 
        }
    }
}
