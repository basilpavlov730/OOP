using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.MyClasses
{
    public class MyChildClass : MyBaseClass
    {
        public MyChildClass(int myIntParam)
        {

        }
        public void MyChildClassPrint()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
