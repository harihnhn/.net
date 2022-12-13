using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace types_of_class_p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 1. abstract class
            //class13 obj1 = new class13();            
            //MessageBox.Show("\n1. abstract class\n" + obj1.method13());
            #endregion

            #region 2. sealed class
            //class21 obj2 = new class21();
            //obj2.method21();
            #endregion

            #region 3. partial class
            //class31 obj3 = new class31();
            //obj3.method311();
            //obj3.method312();

            //class32 obj32 = new class32();
            //obj32.method32();
            #endregion

            #region 4. nested class
            //class41.class42 obj42 = new class41.class42();
            //obj42.method42();            
            #endregion

            #region 5. static class
            ////we can access static class members through classname
            //class51.method5();
            #endregion

            #region property
            class6 obj6 = new class6();
            obj6.Name = "hariharan";
            MessageBox.Show(obj6.Name);
            obj6.method6();
            #endregion
        }
    }

    #region 1. abstract class & sealed method
    //it contains both abstract method and non-abstract method
    // we can't create object for this class, so to use this class we must inherit it from another class
    abstract class class11
    {
        public int n1 = 10, n2 = 20;

        //non abstract method(normal method)
        public int add()
        {
            return n1 + n2;
        }

        //abstract method
        //abstract method doesn't have definition, it have only declaration with abstract key word
        abstract public double arithmetic();
    }

    //Child class of abstract class 
    class class12 : class11
    {
        //abstract method definition 
        //to define abstract method use keyword override
        sealed public override double arithmetic()
        {
            return add() + 1.5;
        }
    }

    class class13 : class12
    {
        public double method13()
        {
            return (arithmetic() + 1.5);
        }
    }
    #endregion

    #region 2.Sealed class
    //sealed class can't inherit to another class
    //we can use this class through object only
    sealed class class21
    {
        public string name = "hariharan";
        public long mob_no = 9003700826;

        public void method21()
        {
            MessageBox.Show("2. sealed class method: \n" + name + "\n" + mob_no);
        }
    }

    //class class22 : class21
    //{

    //}
    #endregion

    #region sealed method
    //we can use sealed method in overrided class only
    #endregion

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

    #region 4. nested class
    //a class created within another class
    class class41
    {
        public static int n11 = 10, n12 = 20;
        public static void method41()
        {
            MessageBox.Show((n11 + n12).ToString());
        }
        public class class42
        {
            public int n11 = 40;
            public void method42()
            {
                method41();
                MessageBox.Show((n11 + n12).ToString());
            }
        }

    }

    //nested class inheritance
    class class43 : class41.class42
    {
        public void method43()
        {
            method42();
        }
    }
    #endregion

    #region 5. static class
    //static class contains static fields and static methods
    //static class can't inherit to another class
    static class class51
    {
        public static int n1 = 10, n2 = 20;
        static public void method5()
        {
            MessageBox.Show((n1 + n2).ToString());
        }
    }

    class class52
    {
        public void method52()
        {
            class51.method5();
        }
    }
    #endregion

    #region property
    class class6
    //using properties we can access private fields
    {
        private string name;
        public string Name  //property
        {
            get { return name; }    //get method
            set { name = value; }   //set method
        }

        public void method6()
        {
            MessageBox.Show(name);
        }
    }
    #endregion
}

