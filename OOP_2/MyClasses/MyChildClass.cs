using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2.MyClasses
{
    // Наследование
    // Наследование реализуется с использованием символа :
    // Множественное наследование классов не допускается, у класса-наследника может быть только один класс родитель
    // При наследовании класс-наследник "переменимает" все методы и свойства класса-родителя.
    // Доступ к метода и свойстам класса-родителя определяется модификаторами доступа
    public class MyChildClass : MyParentClass
    {
        // В случае если в классе-родителе явно описан конструктор с параметрами, то и в классе-наследнике
        // должен быть объявлен конструктор, который передаст значения в класс-родитель
        // Передача значений в конструктор-родителя осуществляется через ключевое слово base
        // {модификатор доступа}{Класс наследник}({тип параметра}{наименование параметра}, {тип параметра} {наименование параметра}, {тип параметра} {наименование параметра}) : base({наименование параметра}, {наименование параметра}, {наименование параметра})
        public MyChildClass(int MyPublicField, int MyProtectedField, int MyPrivateField) 
            : base(MyPublicField, MyProtectedField, MyPrivateField)
        {
            Console.WriteLine(this.GetType().Name);
        }

        // В конструкторе класса-наследника может быть объявлено больше параметров, чем требуется для передачи в конструктор класса-родителя
        public MyChildClass(int MyPublicField, int MyProtectedField, int MyPrivateField, string MyStingParam, double MyDoubleParam)
            :base(MyPublicField, MyPrivateField, MyProtectedField)
        {

        }
        public void myMethodChildClass()
        {
            // Public поле класса-родителя
            myPublicField = 5;

            // Protected поле класса-родителя
            myProtectedField = 5;

            // Private поле класса-родителя
            // myPrivateField = 5; // Ошибка!
        }
    }
}
