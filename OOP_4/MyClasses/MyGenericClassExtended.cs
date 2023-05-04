using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.MyClasses
{
    // Для класса может быть определено несколько псевдонимов типов данных
    public class MyGenericClassExtended<T,G,K>
    {
        public T myTProperty { get; set; } 
        public G myGProperty { get; set; }
        public K myKProperty { get; set; }
    }
    }
}
