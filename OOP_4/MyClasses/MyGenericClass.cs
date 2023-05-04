using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.MyClasses
{
    // Создание универсального шаблона {Имя класса}<Псевдоним типа>
    // Псевоним типа может быть использован внутри класса как обычный тип
    public class MyGenericClass<T>
    {
        // T - тип данных, который будет передан в класс при инициализации представителя класса
        public T MyGenericProperty { get; set; }

        //T может быть использован как тип данных в методах, объявленных внутри класса, в том числе в конструкторах
        public MyGenericClass(T myPropertyValue)
        {            
            MyGenericProperty = myPropertyValue;
        }
    }
}
