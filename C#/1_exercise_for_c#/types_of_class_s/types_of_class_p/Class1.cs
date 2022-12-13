using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace types_of_class_p
{
    #region 3. partial class
    //using  partial key word we can specify multiple classes at same classname
    partial class class31
    {
        public int n11 = 10, n12 = 2;
        public void method311()
        {
            MessageBox.Show((n11 + n12).ToString());
        }
    }

    partial class class31
    {
        public int n21 = 10, n22 = 2;
        public void method312()
        {
            MessageBox.Show((n21 * n22).ToString());
        }
    }

    class class32 : class31
    {
        public void method32()
        {
            method311();
            method312();
        }
    }
    #endregion
}
