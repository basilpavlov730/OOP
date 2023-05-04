using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.MyClasses
{
    // На псевдоним типа могут быть наложены условия, для ограничения принимаемых типов данных 
    // {имя класса}<Псевдоним типа> where {псевдоним типа} : {ограничения}
    // Ограничения:
    // 1. class - передаваемый тип данных должен быть ссылочным
    // 2. struct - передаваемый тип данных должен быть значимым
    // 3. new() - в передаваемом типе данных должен быть определен конструктор без параметров
    // 4. {Имя класса} - в качестве типа данных может быть передан класс {Имя класса} или классы-наследники
    // в качестве {Имя класса} могут быть использованы интерфейсы
    public class MyGenericClassClassRestrictions<T> where T : class { }

    public class MyGenericClassStructRestrictions<T> where T : struct { }

    public class MyGenericClassNewRestrinctions<T> where T : new() { }

    // Если накладываются ограничения типа {Имя класса}, то внутри класса могут быть использованы элементы клсса {имя класса}
    // для использования элементов класса необходимо создать (или передать) его экземпляр, только если методы не статические
    public class MyGenericClassMyBaseClassRestrictions<T> where T : MyBaseClass
    {
        public MyGenericClassMyBaseClassRestrictions(T myBaseClass)
        {
            myBaseClass.Print();
        }
    }
}
