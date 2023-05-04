// Создание экземпляра делегата и инициализация его. В конструктор в качестве параметра передается ссылка на метод, который удовлетворяет
// описанной делегатом сигнатуре
using OOP_5.MyClasses;

MyVoidDelegate voidDelegate = new MyVoidDelegate(Print);
MyBaseClass myBaseClass= new MyBaseClass();

// Добавление в делегат еще одной ссылки. Делегат - многоадресный 
// В делегат может быть добавлен метод, описанный внутри класса. Для его добавление необходимо использовать представителя класса
voidDelegate += myBaseClass.MyBaseClassPrint;

// Метод Counter не может быть добавлен в делегат, он имеет другую сигнатуру
//voidDelegate += Counter; // Ошибка!

// Вызов делегата - будут вызваны все методы, добавленные в этот делегат. Методы вызываются в порядке добавления
voidDelegate();

// Удаление ссылки на метод из делегата
voidDelegate -= Print;
voidDelegate -= myBaseClass.MyBaseClassPrint;

// Если вызывать делегат, который не содержит ссылки на методы, то будет ошибка. Для отлова ошибки можно использовать try..catch
// voidDelegate(); // Ошибка!

// Метод .Invoke вызывает все методы, ссылки на которые есть ссылки в делегате. Вызывая метод Invoke
// Используя оператор проверки на null "?" можно избежать возникновения ошибки в случае если нет ссылок на методы
voidDelegate?.Invoke();

voidDelegate += Print;
myBaseClass.InvokeDelegate(voidDelegate);

// Action<T> => delegate void MyDeledate(T)
// Action используется для методов, которые не возвращают значение и принимают на вход определенный набор параметор
// Action<int> => void Method(int param); Action<int, string> => void Method(int param1, string param2); и т.д

Action<int> myAction = new Action<int>(myBaseClass.PrintInt);

// Вызов делегата Action ничем не отличается от вызова обычного делегата
myAction(15);
// В случае если делегат многоадресный, то значение входного параметра передается во все методы
myAction?.Invoke(15);

// Func<T, P> => delegate P MyDelegate(T)
// Func используется для методов, которые возвращают какое то значение и принимают на вход определенный набор параметров
// Func<int> => int Method(); Func<string, int> => int Method(string param)
Func<int, int> myFunc = new Func<int, int>(myBaseClass.Counter);

// В случае если делегат возвращает какое либо значение, то его можно записать в переменную
// В случае если объявлен многоадресный делегат, то в переменную будет записан результат последнего метода
var myFuncResult = myFunc?.Invoke(15);

// Predicate<T> => delegate bool MyDeledate(T)
// Predicate используется для методов, которые возвращают значение bool и принимают только один параметр
// Predicate<int> => bool Method(int param);
Predicate<int> myPredicate = new Predicate<int>(myBaseClass.CheckValue);
var myPredicateResult = myPredicate?.Invoke(14);

MyClass myClass = new MyClass();

// Ковариантность позволяет передать в делегат метод, возвращаемый тип которого является производным от типа делегата
// Ожидаемый тип данных, который должен вернуть метод - MyBaseClass, мы передаем в делегат метод, который возвращает MyChildClass
// MyChildClass - наследник (производный класс) от MyBaseClass 
var myFuncDelegate = new Func<MyBaseClass>(myClass.ReturnMyChildClass);

// Контвариантность позволяет присвоить делегату метод, тип параметра которого является более универсальным по отношению к типу параметра делегата
// Ожидаемый тип данных принимаемого параметра - MyChildClass, мы передаем в делегат метод, который принимает на вход один параметр - MyBaseClass
var myActionDelegate = new Action<MyChildClass>(myClass.ReceiveMyBaseClass);

// Подписка на событие, вызов метода add
myBaseClass.myAction += myBaseClass.PrintInt;
// Отписка от события, вызов метода remove
myBaseClass.myAction -= myBaseClass.PrintInt;

void Print()
{
    Console.WriteLine("Print Method");
}

//Объявление делегата, который может содержать в себе ссылки на методы, не имеющие возвращаемого значения
// и не принимающего параметры
public delegate void MyVoidDelegate();

//Объявление делегата, который может содержать в себе ссылки на методы, возвращащие тип данных int
//и принимающие 1 параметр типа int
public delegate int MyIntDelegate(int param);