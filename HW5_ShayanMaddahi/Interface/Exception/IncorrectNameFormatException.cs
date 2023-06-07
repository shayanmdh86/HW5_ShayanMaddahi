using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_ShayanMaddahi.Interface.Exception
{
    public  class IncorrectNameFormatException : ApplicationException
    {
        public override string Message => "Productname is Notcorrect";
    }
}
