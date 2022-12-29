using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace class_object_student_result_calc_p
{
    class student //class
    {
        public long reg_no, m1, m2, m3, m4, m5, tot, avg, per; //field (or) data member
        public string sname, grade, result; //field (or) data member        
        //tot = m1+m2+m3+m4+m5;        
        public void result_calc()
        {
            tot = m1 + m2 + m3 + m4 + m5;
            avg = tot / 5;
            per = tot / (500 / 100);
            grade = (per >= 90) ? "S" : ((per >= 80)? "A+" : ((per>=70)? "A" : ((per>=60)? "B+" : ((per>=50)? "B" : "U"))));
            result = (m1>=50 && m2>= 50 && m3 >= 50 && m4 >= 50 && m5 >= 50) ? "PASS" : "FAIL";
        }
    }
}
