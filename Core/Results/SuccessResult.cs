using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //başarılı resultlar için (True değerler için)
    public class SuccessResult : Result
    {
        public SuccessResult(string message):base(true,message) // iki parametli çalışır
        {

        }
        public SuccessResult() : base(true)//tek parametli olanı çalıştır
        {

        }
    }
}
