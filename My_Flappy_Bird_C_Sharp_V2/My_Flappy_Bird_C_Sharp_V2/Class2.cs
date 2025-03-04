using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Flappy_Bird_C_Sharp_V2
{
    internal class Class2 : Class1
    {
        //---------------------------------------------------------------------------------------------------------------------------
        public void method_2()

        {
            father_method_1();
            Debug.WriteLine("Method_2");
        }
        //---------------------------------------------------------------------------------------------------------------------------
        public static void method_3()

        {
            father_method_1();
            Debug.WriteLine("Method_3");

        }
        //---------------------------------------------------------------------------------------------------------------------------
        public static new void father_method_1()
        {
            Debug.WriteLine("overried father_Method_1");

        }
    }
}
