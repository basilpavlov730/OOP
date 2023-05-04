using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5.MyClasses
{
    public class MyBaseClass
    {  
        public MyVoidDelegate voidDelegate { get; set; }

        // Объявление события
        public event Action<int> myAction
        {
            // Метод add вызывается каждый раз когда происходит подписка на событие (добавление метода)
            add
            {
                Console.WriteLine();
            }
            // Метод remove вызывается каждый раз когда происходит отписка от события (удаление метода)
            remove
            {
                Console.WriteLine();
            }
        }

        public void MyBaseClassPrint()
        {
            Console.WriteLine("MyBaseClass Print");
        }

        public int Counter(int param)
        {
            return param += 1;
        }

        public void PrintInt(int param)
        {
            Console.WriteLine($"Param value = {param}");
        }

        // Если передаваемый параметр - четный => true
        public bool CheckValue(int param) => param % 2 == 0 ? true : false;
        

        //Делегат может быть передан в метод как обычный параметр
        public void InvokeDelegate(MyVoidDelegate delegateToInvoke)
        {
            delegateToInvoke?.Invoke();
        }
    }
}
