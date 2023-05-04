// Thread (поток) - независимый "процесс", который может выполняться одновременно с другими потоками
// Работа с потоками (многопоточностью) осуществляется с помощью экзампляра класса Thread
// Конструктор может принимать либо делегат ThreadStart, либо ParameterizedThreadStart
// public delegate void ThreadStart();
// delegate void ParameterizedThreadStart(object? obj);

using OOP_7.MyClasses;

Thread mySecondThread = new Thread(Print);
Thread myThirdThread = new Thread(PrintObj);

//mySecondThread.Start(); // Запуск потока
//myThirdThread.Start(new MyClass(0)); // Запуск потока и передача параметра в метод

//for(int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"Main thrad - {i}");
//    Thread.Sleep(500); // Задерка выполнения - 0.5с
//}

MyClass myClass = new MyClass(0);

////Потоки одновременно могут работать с одними и теми же данными одновременно изменяя их
//for (int i = 0; i < 5; i++)
//{
//    Thread myThread = new Thread(Count);
//    myThread.Name = i.ToString();
//    myThread.Start();
//}

//// Синхронизация потоков - определение стратегии доступа к используемым ресурсам

//for(int i = 0; i < 5; i++)
//{
//    Thread myThread = new Thread(CountLocked);
//    myThread.Name = i.ToString();
//    myThread.Start();
//}

//Thread myFifthTread = new Thread(CountLocked);
//myFifthTread.Start();

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"Main thread - {myClass.Count}");
//    Thread.Sleep(500);
//    myClass.Count++;
//}

// Для реализации параллельного программирования испольуется класс Task
// Класс Task упрощает работы с потоками и рекомендуется использовать именно его
// Task описывает отдельную задачу, которая запускается асинхронно в одном из потоков из пула потоков

//// Конструктор Task принимает делегат Action<T>
//Task myFirstTask = new Task(Print);
//myFirstTask.Start();

//// Оператор Wait блокирует вызывающий поток, в котором запущена задача, пока эта задача не завершит свое выполнение 
//myFirstTask.Wait(); 

//// Без ожидания выполнения программа (основной поток) завершится не дожидаясь выполнения всех запущенных Task
//Task mySecondTask = Task.Factory.StartNew(Print);
//Task myThirdTask = Task.Run(Print);

//myFirstTask = Task.Run(Print);

//Task[] taskList = new Task[3];
//taskList[0] = myFirstTask;
//taskList[1] = mySecondTask;
//taskList[2] = myThirdTask;

//// Ожидание завершения всех Task
//Task.WaitAll(taskList);

// Задача продолжения (continuation task) позволяет определить задачу, которая будет выполна после завершения текущей
//Task task1 = Task.Run(Print);

//// Сначала выполнится задача task1, после нее начется выполнение задачи task2
//// Метод, запускаемый в .ContinueWith, должен принимать на вход Task<T>
//Task task2 = task1.ContinueWith(PrintTask);
//task2.Wait();

//Task myNewTask = Task.Factory.StartNew(MethodWithChildTask);
//myNewTask.Wait();

//// Для возврата значения из Task необходимо инициализировать (<T>) его тем типом данных, который вернется из Task
//Task<double> myTask = new Task<double>(() => Sqrt(25));
//myTask.Start();

//// Результат выполнения Task хранится в .Result
//// При доступе к Result поток будет дожидаться завершения Task
//Console.WriteLine($"Sqrt = {myTask.Result}");

// При таком запуске асинхронных методов программа будет выполняться 9 секунд - ожидая завершения каждого метода
//await myClass.MyAsyncMethod();
//await myClass.MyAsyncMethod();
//await myClass.MyAsyncMethod();

// При таком запуске асинхронных методов программа выполняется от 3 секунд до 9. Потому что мы сначала запускаем все методы, а только после этого ожидаем их завершения
// Таким образом 3 задачи будут выполняться параллельно
var task1 = myClass.MyAsyncMethod();
var task2 = myClass.MyAsyncMethod();
var task3 = myClass.MyAsyncMethod();

await task1;
await task2;
await task3;

// Конструкцию выше можно заменить на Task.WhenAll(...); - дожидаемся выполнения всех задач
await Task.WhenAll(task1, task2, task3);
// Task.WhenAny(); - дожидаемся выполнения одной любой задачи из списка

// Без использования инструкции await в taskResult попадет Task<int> - задача
var taskResult = myClass.MyIntAsyncMethod(5, 6);
// await позволяет дождаться выполнения метода и вернуть значение из данного метода
var intResult = await taskResult;

void Print()
{
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Second thread - {i}");
        Thread.Sleep(1000); // Задерка выполнения - 1с
    }
}

void PrintObj(object? param)
{
    var myClass = param as MyClass; // Приведение object к MyClass

    for(int i = 0; i < 5; i++)
    {
        myClass.Count = i;
        Console.WriteLine($"Third thread - {myClass.Count}");
        Thread.Sleep(800);
    }
}

void Count()
{
    myClass.Count = 0;
    for (int i = 0; i < 5; i++)
    {        
        Console.WriteLine($"{Thread.CurrentThread.Name} - {myClass.Count}");
        myClass.Count++;
        Thread.Sleep(1000);
    }
}

void CountLocked()
{
    // Оператор lock запрещает доступ к объекту (ссылочного типа данных!) из других потоков
    // Другие потоки ожидают завершения работы с объектом и только после этого начинают выполнение операций

    lock (myClass)
    {
        myClass.Count = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} - {myClass.Count}");
            Thread.Sleep(1000);
            myClass.Count++;
        }
    }
}

void MethodWithChildTask()
{
    Console.WriteLine("Outer task starting...");

    // Параметр TaskCreationOptions.AttachedToParent, передаваемый в метод Task.Factory.StartNew, позволяет "прикрепить" вложенную задачу к текущему потоку
    // Таким образом внешний поток будет воспринимать их как один и продолжит выполнение только после выполнения всех вложенных потоков

    var inner = Task.Factory.StartNew(() =>  // вложенная задача
    {
        Console.WriteLine("Inner task starting...");
        Thread.Sleep(2000);
        Console.WriteLine("Inner task finished");
    }
    , TaskCreationOptions.AttachedToParent);
    Thread.Sleep(1000);
}

double Sqrt(int param)
{
    Thread.Sleep(1000);
    return Math.Sqrt(param);
}

void PrintTask(Task parentTask)
{
    Console.WriteLine($"Id задачи: {Task.CurrentId}");
    Console.WriteLine($"Id предыдущей задачи: {parentTask.Id}");
    Thread.Sleep(3000);
}