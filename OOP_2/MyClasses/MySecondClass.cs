using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2.MyClasses
{
    public class MySecondClass
    {
        public int Id { get; set; }
        
        // Конструктор с 1 параметром int
        public MySecondClass(int id)
        {
            Id = id;    
        }
        // В классе может быть объявлено несколько параметров
        // Конструкторы должны отличаться по количеству принмаемых параметров и\или их типу
        public MySecondClass(string myStringParam)
        {

        }
        public MySecondClass(int myFirstIntParam, int mySecondIntParam)
        {

        }

        // Специализированный метод Финализатор, вызывается при высвобождении памяти из под экземлпдяра класса
        // Вызывается в произвольный момент времени между тем как сборщик мусора пометил область памяти как неиспользуемую и фактическим высвобождением памяти
        ~MySecondClass()
        {

        }
    }
}
