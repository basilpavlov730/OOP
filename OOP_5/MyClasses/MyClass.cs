using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5.MyClasses
{
    public class MyClass
    {
        public MyChildClass ReturnMyChildClass()
        {
            return new MyChildClass();
        }

        public void ReceiveMyBaseClass(MyBaseClass param)
        {

        }
    }
}
