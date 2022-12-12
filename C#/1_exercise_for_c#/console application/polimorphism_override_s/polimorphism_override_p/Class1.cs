using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorphism_override_p
{
    //overriding
    //same method name and same arg but in different class
    // base class
    class class1
    {
        string name = "www.google";        
        public virtual void showdata()
        {
            Console.WriteLine("Website Name: " + name);
        }
    }
   
    class class2 : class1
    {
        string s = "Computer Science";
        public override void showdata()
        {
            base.showdata();
            Console.WriteLine("About: " + s);
        }
    }
}
