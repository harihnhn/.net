using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic_using_multilevel_inheritance
{
    class value
    {
        public int a, b, ans;
    }

    class a : value
    {
        public int add()
        {
            return a + b;
        }
    }

    class s : a
    {
        public int sub()
        {
            return a - b;
        }
    }

    class m : a
    {
        public int mul()
        {
            return a * b;
        }
    }

    class d : m
    {
        public int div()
        {
            return a / b;
        }
    }
}
