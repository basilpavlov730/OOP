// Создание переменных:
// {тип данных} Имя переменной;
// Каждая инструкция завершается ;
// Инициализация переменных - присовение значение переменной, может быть выполнено при создании переменных
int myFirstIntVariable = 0;
double? myFirstDoubleVariable = 0.0d;
float myFirstFloatVariable = 0.0f;
string myFirstStringVariable = "String variable value!";

//Выведение результатов выполнения программы на консоль
Console.WriteLine(myFirstStringVariable);
Console.WriteLine($"{myFirstDoubleVariable}");
Console.WriteLine(myFirstIntVariable + " - " + myFirstFloatVariable);

//Чтение данных с консоли
// После чтения данных с консили значение должно быть преведено в требуемому типу
// По умолчанию метод .ReadLine возвращает строку (string)
myFirstIntVariable = Convert.ToInt32(Console.ReadLine());
myFirstDoubleVariable = Convert.ToDouble(Console.ReadLine());

//if - тело выполняется если выражение в скобках истинно
//Результат выражения должен быть bool, могут использоваться операторы <, >, <=, >=, ==, !=
// Тело цикла, оператора и тд, состоящее больше чем из 1 комманды объединяется в { тело } 
if(myFirstIntVariable == 0)
{
    //Оператор "Инкремент"
    myFirstIntVariable++;
}
// если выражение ложно, то выполняется блок else. Может отсутствовать
else
{
    myFirstIntVariable--;
}

// Массивы
// {тип данных[]} Имя массива = new {тип данных[]}({Размерность массива})
// В качестве размерности массива может быть использовано значение переменной
int[] myFirstIntArray = new int[myFirstIntVariable];

//Массив может быть сразу инициализирован значениями типа {тип данных}
int[] mySecontIntArray = new int[] { 5, 6, 7, 8 };

//Доступ к элементу массива для записи
myFirstIntArray[1] = 5;

//Многомерные массивы
int[,] myFirstTwoDementionsArray = new int[3, 4];
//Для чтения
Console.WriteLine(mySecontIntArray[0]);

// Рваные\зубчатые\ступенчатые массивы
// Объявление ступенчатого массива из 4 строк, в каждой строке может быть разное количесвто элементов
int[][] myFirstRaggedArray = new int[4][];

// Каждый массив - представитель класса Array. Можно использовать методы и свойства данного класса
//.Length - длинна массива, количество элементов
Console.WriteLine(myFirstIntArray.Length);

//.GetLength({номер измерения}) - количество элементов в {номер измерения}
Console.WriteLine(myFirstTwoDementionsArray.GetLength(0)); // кол-во строк
Console.WriteLine(myFirstTwoDementionsArray.GetLength(1)); // кол-во столбцов и т.д.

// Циклы
// Внутри тела цикла могут быть объявлены другие циклы
// С предусловием - сначала проверяется условие продолжения цикла, потом выполняется тело
// while - тело выполняется до тех пор, пока выражение в скобках истинно 
while(myFirstIntVariable >= 0)
{
    Console.WriteLine(myFirstIntVariable);
    myFirstIntVariable--;
}

//for - тело цикла выполняется пока истиио выражение, стоящее на 2 месте
//for({обявления переменной-счетчика цикла}; {условие продолжения цикла}; {изменения счетчика})
for(int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
//Выражение изменения счетчика может быть пропущено, в таком случае изменения счетчика должно быть 
// описано в теле цикла, иначе цикл - бесконечный

for(int i = 0; i < 5; )
{
    Console.WriteLine(i);
    i++;
}
//Если пропущено выражение {условие продолжения цикла}, то выход из цикла прописыватеся внутри тела цикла
// иначе цикл - бесконечный
for (int i = 0; ; )
{
    Console.WriteLine(i);    
    if(i > 10)
        break; // оператор выхода из цикла
}

//foreach - тело цикла будет выполнено для каждого элемента коллекции (массива, списка)
//foreach ({тип элемента коллекции} {переменная, в которую помещается следующий элемент коллекции} in {коллекция значений})
// var - неявный тип переменной, тип переменной определяется компилятором в момент выполения программы
foreach(var mySecondArrayItem in mySecontIntArray)
{
    // Внутри тела foreach мы можем использовать {переменную, в которую помещается следующий элемент коллекции}
    Console.WriteLine(mySecondArrayItem);
    // Но не можем изменять значение
    // mySecondArrayItem = 5; // Ошибка!
}

// Отличие for от foreach - в for мы можем сами определить по каким элементам коллекции будет выполнен цикл, например, кажое 2 значение
// foreach пройдет по всем элементам коллекции

// Циклы с постусловием - сначала выполняется тело, а потом выполняется условие продолжения цикла
// do ... while()

do
{ 
    Console.WriteLine(myFirstIntVariable);
    myFirstIntVariable--;
}
while(myFirstIntVariable >= 0);
