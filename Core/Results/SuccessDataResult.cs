using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {
            //data+mesaj+daima true
        }
        public SuccessDataResult(T data):base(data,true)
        {
            //data+daima true
        }
        public SuccessDataResult(string message):base(default,true,message)
        {
            //mesaj+daima true
        }
        public SuccessDataResult():base(default,true)
        {
            //daima true 
        }

    }
}
