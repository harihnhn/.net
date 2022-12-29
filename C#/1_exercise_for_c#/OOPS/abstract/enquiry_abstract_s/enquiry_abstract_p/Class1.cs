using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enquiry_abstract_p
{
    //abstract class
    abstract class enquiry
    {
        public int age, amt;
        public long mob_no;
        public string name, add, gender;
        public abstract void calc_amt();
    }

    //dereieved class
    class student : enquiry
    {
        public string qualification;
        public bool course1, course2, course3;
        public override void calc_amt()
        {
            if(course1 == true)
                amt += 21490;
            if (course2 == true)
                amt += 10000;
            if (course3 == true)
                amt += 20000;
        }
    }

    class employee : enquiry
    {
        public int exp, job;
        public override void calc_amt()
        {
            amt += (job == 1) ? 20000 : (job == 2) ? 25000 : 30000;
            amt *= (exp >= 20) ? 3 : (exp >= 10) ? 2 : 1; 
        }
    }

    class passport : enquiry
    {
        string nationality, dob, f_name;
        public override void calc_amt()
        {
            amt += (job == 1) ? 20000 : (job == 2) ? 25000 : 30000;
            amt *= (exp >= 20) ? 3 : (exp >= 10) ? 2 : 1;
        }
    }


}
