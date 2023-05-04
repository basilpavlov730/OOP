// Подключение пространства имен, где объявдены классы MyFirstClass и MySecondClass
using OOP_2.MyClasses;

// При инициализации класса используется ключевое слово new
// В скобках указываются параметры, которые передаются в конструктор
// Возможность создания экземляра класса определяется модификатором доступа класса 
// Конструктор без параметров
MyFirstClass MyFirstClass = new MyFirstClass();

// Конструктор с 1 параметром
MySecondClass MySecondClass = new MySecondClass(5);

//Вызывается конструктор только класса-родителя
MyParentClass myParentClass = new MyParentClass(5, 6, 7);

// Вызываются конструкторы сначала класса-родителя, затем класса-наследника
// Значения 5,6,7 будут переданы через конструктор класса-наследника в конструктор класса-родителя
MyChildClass myChildClass = new MyChildClass(5, 6, 7, "StringValue", 12.75d);


//Доступ к элементам класса осуществляется через экземляр класса и оператор точка (.)
// Возможность доступа определяется модификатором доступа элемента
// public
MyFirstClass.MyPublicMethod();
// private 
//MyFirstClass.MyPrivateMethod(); // Ошибка!

// protected
//MyFirstClass.MyProtectedMethod(); // Ошибка!