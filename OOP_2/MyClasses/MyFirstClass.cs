//namespace - пространство имен, определяет видимость классов для использвания
namespace OOP_2.MyClasses
{
    // Объявления класса
    // {Модификатор доступа} class {Имя класса}
    public class MyFirstClass
    {
        // Конструктор - специализированный метод, вызываемый при создании экземпляра класса
        // {модификатор досупа} {Имя класса}
        // В большинстве случаев модификатор доступа конструктора - public

        //Поле
        public int Id;

        // Конструктор без параметров
        public MyFirstClass()
        {
            //Присвоение значения полю. Минимальное значение типа данных int
            Id = int.MinValue;
            //Вызов метода без параметров
            MyMethod();

            // Вызов метода с параметром и возвращение из него значения
            int myIntMethodResult = MyIntMethod(Id);
        }

        // Методы
        // {модификатор доступа} {тип возвращаемого значения} {Имя метода}({тип парметра} {имя парметра})
        // void - метод не возвращает значения
        public void MyMethod()
        {
            Console.WriteLine("MyMethod");
        }

        // Метод для которого объявлен тип возвращаемого значения должен возвращать какое то значение используя return
        public int MyIntMethod(int myMethodParam)
        {
            Console.WriteLine();
            return myMethodParam;
        }

        //Модификаторы доступа 
        // public - элеметн доступен всем
        // private - элемент доступен только внутри класса
        // protected - элемент доступен только внутри класса и классов наследников

        public void MyPublicMethod() { }
        private void MyPrivateMethod() { }
        protected void MyProtectedMethod() { }
    }
}
