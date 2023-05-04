using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.MyClasses
{
    public class MyChildClass : MyParentClass
    {
        public override void PrintToOverride()
        {
            Console.WriteLine("MyChildClass");
        }
        public override void Print()
        {
            // base может быть использован и для вызова методов, объявленных в классе-родителе
            base.Print();
        }

        public void MyChildMethod()
        {
            Console.WriteLine("MyChildMethod");
        }

        // В случае если в классе-наследнике описан метод с такой же сигнатурой, что и в классе-родителе, то он скрывает реализацию, оисанную в классе-родителе
        public void MyHiddenMethod()
        {
            Console.WriteLine("MyChildClass.MyHiddenMethod");
        }
    }
}
