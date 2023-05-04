using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.MyClasses
{
    public class MyParentClass
    {
        public virtual void PrintToOverride()
        {
            Console.WriteLine("MyParentClass");
        }

        public virtual void Print()
        {
            Console.WriteLine();
        }

        public void MyHiddenMethod()
        {
            Console.WriteLine("MyParentClass.MyHiddenMethod");
        }
    }
}
