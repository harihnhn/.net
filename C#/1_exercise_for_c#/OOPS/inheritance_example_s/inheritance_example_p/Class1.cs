using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_example_p
{
    class employee
    {
        //class members
        public string name; //field
        public int id, des, age; //field
        public float exp, sal = 0;

        //method
        public float salary()
        {
            //return (des == 1) ? 100000 : ((des == 2) ? 50000 : 25000);
            sal = (des == 1) ? 100000 : ((des == 2) ? 50000 : 25000);
            sal += sal * (exp / 10);
            return sal;
        }
    }

    class insentive : employee
    {
        //method or member function
        public float ins()
        {
            if (age <= 35)
                return ((sal / 100) * 10);
            else
                return ((sal / 100) * 20);  
        }

        public float bon()
        {
            return (2 * sal);
        }
    }
}