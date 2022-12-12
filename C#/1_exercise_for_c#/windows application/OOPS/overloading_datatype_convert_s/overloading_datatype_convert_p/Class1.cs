using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading_datatype_convert_p
{
    class stringconvert
    {
        //int to string
        public string convert(int a)
        {
            return a.ToString();        
        }

        //long to string
        public string convert(long a)
        {
            return a.ToString();
        }

        //float to string
        public string convert(float a)
        {
            return a.ToString();
        }

        //double to string
        public string convert(double a)
        {
            return a.ToString();
        }

        //char to string
        public string convert(char a)
        {
            return a.ToString();
        }

        //bool to string
        public string convert(bool a)
        {
            return a.ToString();
        }
    }
}
