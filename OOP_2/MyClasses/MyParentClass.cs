using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2.MyClasses
{    
    public class MyParentClass
    {
        public int myPublicField;
        protected int myProtectedField;
        private int myPrivateField;

        public MyParentClass(int MyPublicField, int MyProtectedField, int MyPrivateField)
        {
            // this - указатель на конкретный экземпляр класса 
            Console.WriteLine(this.GetType().Name);            
        }
    }
}
