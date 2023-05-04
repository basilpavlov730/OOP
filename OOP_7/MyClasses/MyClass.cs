using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7.MyClasses
{
    public class MyClass
    {
        public int Count;
        public MyClass(int count)
        {
            Count = count; 
        }

        // Основными атрибутами асинхронного метода являются ключевое слово async, указанное в объявлении метода, и инструкция await, применяемая в теле метода
        // В качестве возвращаемых значений могут быть указаны void (лучше избегать), Task (явно не возвращает значение из метода), Task<T> (T - тип возвращаемого значения), ValueTask<T> (схоже по использованию с Task<T>, однако, занимает больший объем памяти при инициализации)
        // Асинхронный метод не может получать параметры in, out, ref
        public async Task MyAsyncMethod()
        {
            Console.WriteLine("AsyncMethod start...");
            await Task.Delay(3000);
            Console.WriteLine("AsyncMethod finish");
        }

        public async Task<int> MyIntAsyncMethod(int param1, int param2)
        {
            await Task.Delay(3000);
            return param1 + param2;
        }
    }
}
