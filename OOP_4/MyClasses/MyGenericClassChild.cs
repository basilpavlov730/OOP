using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.MyClasses
{
    // При наследовании универсальнго шаблона необходимо явно указать вместо псевдонима типа тип данных, который
    // будет использован при создании класса-наследника
    public class MyGenericClassChild : MyGenericClass<int>
    {
        //Конструктор нужен потому что в базовом классе объявлен конструктор, принимающий один параметр Т
        //Так как при наследовании указан явно тип данных int, то должен быть объявлен конструктор, принимающий и передающий дальше int
        public MyGenericClassChild(int myPropertyValue) : base(myPropertyValue)
        {
        }
    }
}
