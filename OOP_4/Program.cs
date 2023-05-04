using OOP_4.MyClasses;

// Вместо псевдонима Т, использованного при описании класса, при инициализации будет подставлен тип данных int
MyGenericClass<int> myIntClass = new MyGenericClass<int>(5);

// Все методы и свойства внутри класса будут иметь тип данных int
// Только для экземпляра класса myIntClass!
Console.WriteLine(myIntClass.MyGenericProperty.GetType().Name);

MyGenericClass<string> myStringClass= new MyGenericClass<string>("MyString");
// Для экземпляра myStringClass T - string
Console.WriteLine(myStringClass.MyGenericProperty.GetType().Name);

//В качестве типа данных могут быть переданы не только станлартные типы данных, но и классы, созданные пользователем 
MyGenericClass<MyBaseClass> myBaseClass = new MyGenericClass<MyBaseClass>(new MyBaseClass());
Console.WriteLine(myBaseClass.MyGenericProperty.GetType().Name);

// При объявлении класса с несколькими псевдонимами типов они указываются через , в <>
MyGenericClassExtended<int, string, MyBaseClass> myGenericClassExtended = new MyGenericClassExtended<int, string, MyBaseClass>();

// При объявлении касса с несколькими псевдонимами типов они могут дублироваться
MyGenericClassExtended<int, int, int> myGenericClassExtendedInt = new MyGenericClassExtended<int, int, int>();

//MyBaseClass - ссылочный тип данных
MyGenericClassClassRestrictions<MyBaseClass> myBaseClassGenericClassRestrictions = new MyGenericClassClassRestrictions<MyBaseClass>();
//int - значимый тип данных
//MyGenericClassClassRestrictions<int> myIntGenericClassClassRestrinctions = new MyGenericClassClassRestrictions<int>(); // Ошибка!

MyGenericClassStructRestrictions<int> myIntGenericClassClassRestrinctions = new MyGenericClassStructRestrictions<int>();
//MyGenericClassStructRestrictions<MyBaseClass> myBaseClassGenericClassRestrictions = new MyGenericClassStructRestrictions<MyBaseClass>(); //Ошибка!

//MyBaseClass - явно не обяъявлен конструктор без параметра, однако, при отсуствии иных конструкторов, по умолчанию создается конструктор без параметров
MyGenericClassNewRestrinctions<MyBaseClass> myBaseClassGenecricClassNewRestrictions = new MyGenericClassNewRestrinctions<MyBaseClass>();
//MyChildClass - явно объявлен конструктор с 1 параметров, конструктора без параметров по умолчанию - нет
//MyGenericClassNewRestrinctions<MyChildClass> myChildClassGenericClassNewRestrictions = new MyGenericClassNewRestrinctions<MyChildClass>(); Ошибка!

//MyChildClass - наследник MyBaseClass
MyGenericClassMyBaseClassRestrictions<MyChildClass> myChildClassGenericClassMyBaseClassRestrictions = new MyGenericClassMyBaseClassRestrictions<MyChildClass>(new MyChildClass(5));
//MyGenericClassMyBaseClassRestrictions<MyClass> myClassGenericClassMyBaseClassRestrictions = new MyGenericClassMyBaseClassRestrictions<MyClass>();// Ошибка!
