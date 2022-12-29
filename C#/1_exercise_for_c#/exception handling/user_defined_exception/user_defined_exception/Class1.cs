using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_defined_exception
{
    class MyException : Exception
    {
        public string msg;
        public MyException(string m)
        {
            msg = m;
        }
    }
}
