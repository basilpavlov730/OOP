using OOP_3.MyClasses;

MyParentClass myParentClass= new MyParentClass();
MyChildClass myChildClass= new MyChildClass();

// Вызов виртуального метода, реализация которого описана в классе-родителе
myParentClass.PrintToOverride();
//Вызов виртуального метода, реализация которого описана в классе-наследнике 
myChildClass.PrintToOverride();

// Приведение ссылочных типов данных допускается лишь в одном направлении от класса-наследника к классу-отцу
// В левой части определяется доступность элементов, в правой части определяется реализация
MyParentClass myParentClass2 = new MyChildClass();

// Вызов виртуального метода, реализация которого описана в классе-наследнике
myParentClass2.PrintToOverride();

// Доступа к элементам, описанным только в MyChildClass - нет
//myParentClass2.MyChildMethod(); // Ошибка! 

// Вызов методов, используя экземпляры классов БЕЗ приведения
myParentClass.MyHiddenMethod();
myChildClass.MyHiddenMethod();

// Вызов сокрытого метода используя представителя класса-родителя, но инициализированного классом-наследником
// В таком случае вызыватеся реализация, описанная в классе-родителе
myParentClass2.MyHiddenMethod();

