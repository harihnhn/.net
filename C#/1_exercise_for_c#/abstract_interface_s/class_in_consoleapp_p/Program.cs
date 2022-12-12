using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. why i can't acces these fields in  main method without creating object
//2. how could i acces these fields through object even it is private
//3. why string[] args in main method
//4. what does it mean "static"

namespace class_in_consoleapp_p
{
    class class1
    {
        public int c1n1 = 10;
        public int c1n2 = 20;
        public virtual int fun11()
        {
            //class21 obj = new class21();
            class2 obj = new class2();
            Console.WriteLine(obj.fun4());
            return c1n1 + c1n2;
        }
    }

    class class2 : class3, Iclass4
    {
        public int c2n1 = 10;
        public int c2n2 = 2;

        //method definition for abstract class method
        public override int fun11()
        {
            return (c2n1 / c2n2);
        }

        //method definition for interface method
        public int fun4()
        {
            return c2n1 - c2n2;
        }

        static void Main(string[] args)
        {
            //args = new string[] { "hariharan", "narahirah" };
            //Console.WriteLine(args[0]);

            //create object
            class2 obj;
            obj = new class2();

            Console.WriteLine(obj.fun11());
            Console.WriteLine(obj.fun4());

            class1 obj1 = new class1();
            obj1.fun11();

        }
    }

    #region class 3 (abstract class)
    //abstract class should have fields, methods and abstract mthods
    //it must be inherit to another class
    abstract class class3
    {
        public int c3n1 = 100;
        public int c3n2 = 200;
        public abstract int fun11(); //abstract methods doesn't have definition it only have declaration 
    }
    #endregion


    #region class4 (Interface)
    //interface should not have fields, it have only methods
    //it must be inherit to another class
    //we can inherit multiple interfaces in one class
    interface Iclass4
    {
        //interface methods shouldn't have access specifier and it doesn't have defenition it only have method declaration
        int fun4();
    }
    #endregion
}


namespace namespace2
{
    class class21
    {
        int n = 1;
        public int n1 = 2;
        public int niam()
        {
            return n += 1;
        }
    }
}