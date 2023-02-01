// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");//

/*Console.WriteLine ("Type in your username ");
string username = Console.ReadLine();
Console.Write("Hello, ");
Console.Write(username);*/

/*int numberA = 5;
int numberB = 8;
int result = numberA + numberB;
Console.WriteLine(result);*/

/*int numberA = int.Parse(Console.ReadLine()!);
int numberB = int.Parse(Console.ReadLine()!);
int result = numberA + numberB;
Console.WriteLine(result);*/

/*Console.WriteLine ("Type a number: ");
int number = int.Parse(Console.ReadLine()!);

//with math:
int sqr = number * number;

// with library
int sqr1 = Convert.ToInt32(Math.Pow(number, 2)!);
Console.WriteLine($"The square of {number} equals to: with math {sqr}, with library {sqr1}");*/

/*Console.WriteLine ("Type a number: ");
int num = int.Parse(Console.ReadLine()!);

int num1 = - num;

while (num1 <= num){
    Console.Write($"{num1} ");
    num1 ++;
};*/

//Напишите программу, которая принимает на вход два числе и проверяет, является ли первое квадратом второго
/*Console.WriteLine ("Type number A: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Type number B: ");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA / numberB == numberB){
    Console.WriteLine ("является");
}
else{
    Console.WriteLine ("не является");
};*/


//Задача 1: Напишите программу, которая на вход принимает два числа
//и выдаёт, какое число большее, а какое меньшее.
/*Console.WriteLine("Type number A: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Type number B: ");
int numberB = int.Parse(Console.ReadLine()!);

if(numberA > numberB){
    Console.WriteLine ("max is number A");
}
else{
Console.WriteLine("max is number B");  
};
//В случае, когда вводятся равные числа, программа выдаст на выходе число В*/


//Задача 2: Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.

/*Console.WriteLine("Type number A: ");
int numberA  = int.Parse(Console.ReadLine()!);

Console.WriteLine("Type number B: ");
int numberB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Type number C: ");
int numberC = int.Parse(Console.ReadLine()!);

int max = numberA;

if(numberA > numberB){
    max = numberA;
}
else{
    max = numberB;
};

if(numberC > max){
    Console.WriteLine($"max number is {numberC}");
}
else{
    Console.WriteLine ($"max number is {max}");
};*/

//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.WriteLine("Type a number: ");
int number = int.Parse(Console.ReadLine()!);
if(number % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");

};*/


//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

/*Console.WriteLine("Type a number: ");
int number = int.Parse(Console.ReadLine()!);
int count = 0;
while(count <= number)
{
    Console.Write($"{count} ");
    count +=2;
};*/

// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*Console.WriteLine("Type a number: ");
int number = int.Parse(Console.ReadLine()!);
int number1 = (number / 10);
if(number / 100 < 1 || number / 100 > 9)
{
    Console.WriteLine("The number is not three-figure");
}
else
{
Console.WriteLine($"{number1 % 10}");
};*/

// Задача 2: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

/*Console.WriteLine("Type a number: ");
int number = int.Parse(Console.ReadLine()!);
int Result = (number / 10);
if(Result < 10)
{
Console.WriteLine("There is no thrird figure in that number");
}
else if(Result < 100)
{

    Console.WriteLine($"Third figure is {number % 10}");
}
else if(Result < 1000)
{

    Console.WriteLine($"Third figure is {Result % 10}");
}
else if(Result < 10000)
{
    Console.WriteLine($"Third figure is {Result / 10 % 10}");
}
else
    Console.WriteLine("I don't work with numbers that big");*/

// Вариант решения 2.

// Решение с использованием массива

/*Console.WriteLine("Type a number: ");
string N = Console.ReadLine();
if (N.Length < 3)
{
    Console.WriteLine("There is no third figure in that number");
}
else
{
    Console.WriteLine(N[2]);
};*/

//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7

/*Console.WriteLine("Type a number: ");
int number = int.Parse(Console.ReadLine()!);

if(number < 1 || number > 7)
{
    Console.WriteLine("There is no such weekday");
}
else if(number < 6)
{
    Console.WriteLine("Alas, it's working day");
}
else if(number >= 6)
{
    Console.WriteLine("Hooray, it's weekend!");
};*/


//Задача 19. Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.
/*Console.WriteLine("Type a number: ");
string N = Console.ReadLine();
if(N.Length < 5 || N.Length > 5)
{
    Console.WriteLine("Please type a five-figure number");
}
else if(N[0] == N[4] && N[1] == N[3])
{
    Console.WriteLine("Yes, it's a palindrome");
}
else 
{
    Console.WriteLine("Not a palindrome");
};*/

//Задача 23. Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

/*Console.WriteLine("Type a number: ");
int number = Convert.ToInt32(Console.ReadLine()!);

for(int i = 1; i <= number; i++)
{
    Console.WriteLine(Math.Pow(i,3));
};*/

/*Console.WriteLine("Type a number: ");
int number = Convert.ToInt32(Console.ReadLine()!);
int i = 1;
while(i <= number)
{
    Console.Write($"{Math.Pow(i,3)} ") ;
    i++;
};*/

//Задача 21. Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.

/*Console.WriteLine("Define x parameter for the point A: ");
int Ax = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Define y parameter for the point A: ");
int Ay = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Define z parameter for the point A: ");
int Az = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Define x parameter for the point B: ");
int Bx = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Define y parameter for the point B: ");
int By = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Define z parameter for the point B: ");
int Bz = Convert.ToInt32(Console.ReadLine()!);

double Result = Math.Sqrt(Math.Pow((Ax - Bx),2) + Math.Pow((Ay - By),2) + Math.Pow((Az - Bz),2));
Console.WriteLine($"The distance between the two points is {Result}");*/

// Математический вариант решения задачи 19. (Напишите программу,
//которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом)

/*Console.WriteLine("Type a number: ");
int number = Convert.ToInt32(Console.ReadLine()!);
if(number / 10000 >= 10 || number / 10000 < 1)
{
    Console.WriteLine("This number is not five-figure");
}
else if(number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
{
    Console.WriteLine("Yes, it's a palindrome");
}
else
    Console.WriteLine("No, it's not a palindrome");

//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
Console.Write("Введи число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма чисел от 1 до {A} равна {GetSum(A)}");

//--------------Методы-----------------
/*int GetSum (int A){
    int sum = 0;
    for(int i = 1; i <= A; i++){
        sum = sum + i; // sum += i
    }
    return sum;
}*/
//Принять на вход число А и ввернуть произведение всех чисел от 1 до А

/*Console.WriteLine ("Type a number ");
int A = int.Parse(Console.ReadLine()!);
Console.Write($"Factorial is equal {GetFactorial(A)}");

int GetFactorial (int A)
{
int Factorial = 1;
for (int i = 1; i <= A; i++)
{
    Factorial = Factorial * i;
}
return Factorial;
}*/

// Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе

/*Console.WriteLine ("Type a number ");
int number = int.Parse (Console.ReadLine ()!);
Console.Write($"The number of digits is {GetQuantity(number)}");


int GetQuantity (int A)
{
    int Quantity = 0;
    if (A == 0) return 1;
    while (A > 0)
    {Quantity = Quantity + 1; A = A / 10;}
    return Quantity;
}

Console.WriteLine ("Type a number ");
string Number = Console.ReadLine()!;
Console.Write($"The number of digits is {GetQuantity2(Number)}");

int GetQuantity2 (string Number)
{
    int Quantity2 = Number.Length;
    return Quantity2;
}*/

//Напишите программу, которая выводит массив из восьми элементов,
//заполненный нулями и единицами в случайном порядке


/*int[] Array = GetArray(8);
Console.Write($"[{String.Join(";", Array)}]");

int[] GetArray (int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(2);
    }
    return Array;
}*/


//Напишите программу замены элементов массива: 
// положительные элементы замените на отрицательные, и наоборот

/*int[] GetArray (int size)
{
    int[] Array = new int[size];
    for (int i =0; i < size; i++)
    {
      Array[i] = new Random().Next(-10, 11);  
    }
    return Array;
}
/*int[] Array = GetArray(10);
Console.WriteLine($"[{String.Join(", ",Array)}]");
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = Array[i] * (-1);
}
Console.WriteLine($"[{String.Join(", ",Array)}]");*/

//  Задайте массив и напишите программу,
// определяет, присутствует ли ли заданное число в массиве
/*int[] GetArray (int size)
{
    int[] Array = new int[size];
    for (int i =0; i < size; i++)
    {
      Array[i] = new Random().Next(-10, 11);  
    }
    return Array;
}

int[] Array = GetArray(10);
int Find = -5;
Console.WriteLine($"[{String.Join(", ",Array)}]");
if (FindElement(Array, Find))
{
Console.WriteLine($"Данный элемент найден");
}
else
{
    Console.WriteLine($"Данный элемент не найден");
}

bool FindElement (int[] Array, int Find)
{
foreach (int ArrayEl in Array)
{
    if (ArrayEl == Find)
    {
        return true;
    }
}
return false;
}*/

// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

/*int[] Array = GetArray(123);

int[] GetArray (int size)
{
    int[] Array = new int[size];
    for (int i =0; i < size; i++)
    {
      Array[i] = new Random().Next(0, 1001);  
    }
    return Array;
}
Console.WriteLine($"[{String.Join(", ",Array)}]");
int count = 0;
for (int i = 0; i <= 122; i++)
{
if (Array[i] >= 10 && Array[i] < 100)
{
    count = count + 1; 
}
}
Console.WriteLine($"Количество цифр в данном диапазоне {count}");*/



// --------------------Домашка к семинару 12 января---------------------------------

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B

/*Console.WriteLine("Type number A ");
int A = int.Parse (Console.ReadLine()!);
Console.WriteLine("Type number B ");
int B = int.Parse (Console.ReadLine()!);
Console.Write($"{A} raised to the power {B} equals to {RaiseToPower(A)}");

int RaiseToPower (int A)
{
    int result = 1;
    for (int count = 1; count <= B; count++)
{
    result = result * A;
}
    return result;
}*/


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//и выводит их на экран. (числа берете любые)
/*int[] Array = GetArray(8);
Console.Write($"[{String.Join(";", Array)}]");

int[] GetArray (int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(30);
    }
    return Array;
}*/

//Задача 27: Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.

/*Console.WriteLine ("Type a number ");
int[] Number = Console.ReadLine()!;
Console.Write($"The sum of figures equals to {GetFiguresSum(Number)}");

int GetFiguresSum (int[] Number)
{
    int sum = 0;
    int i = 0;
    int size = Number.Length;
    while (i <= size)
    {sum = sum + Convert.ToInt32(Number[i]); i++;}
    return sum;
}*/

//Задача 27: Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.

/*Console.WriteLine ("Type a number ");
int Number = int.Parse(Console.ReadLine()!);
Console.Write($"The sum of figures equals to {GetFiguresSum(Number)}");

int GetFiguresSum (int Number)
{
   int sum = 0;
   while (Number > 0)
   {
    sum = sum + Number % 10;
    Number = Number / 10;
   }
   return sum; 
}*/

// --------------------Домашка к семинару 16 января---------------------------------

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*int[] Array = GetArray(12);
Console.Write($"[{String.Join(",", Array)}] ");

int[] GetArray (int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(100,1000);
    }
    return Array;
}
int count = 0;
for (int i = 0; i <= 11; i++)
{
if (Array[i] % 2 == 0)
{
    count = count + 1; 
}
}
Console.WriteLine($"There are {count} even numbers in this array.");*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных индексах.

/*int[] Array = GetArray(12);
Console.Write($"[{String.Join(",", Array)}] ");

int[] GetArray (int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(1,10);
    }
    return Array;
}
int count = 0;
for (int i = 1; i <= 11; i+=2)
{
    count = count + Array[i]; 
}
Console.WriteLine($"The sum of elements with odd indexes is {count}.");*/


// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
/*;int[] Array = GetArray(13);
Console.Write($"[{String.Join(",", Array)}] ");

int[] GetArray (int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(1,10);
    }
    return Array;
}

int[] NewArray = GetNewArray(Array.Length / 2);
Console.Write($"[{String.Join(",", NewArray)}] ");

int[] GetNewArray (int size)
{
    int[] NewArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        NewArray[i] = Array[i] * Array[Array.Length - i - 1];
    }
    return NewArray;
}
/*Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)*/
/*int[] array = GetArray(5, 0, 20);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] resultArray = ReverseArray2(array);
Console.WriteLine($"[{String.Join(",", resultArray)}]");

ReverseArray1(array);
Console.WriteLine($"[{String.Join(",", array)}]");


// ------Методы------------------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReverseArray1(int[] array){
    for(int i = 0; i < array.Length/2; i++){
        int k = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = k;
    }
}

int[] ReverseArray2(int[] array){
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        result[i] = array[array.Length - i - 1];
    }
    return result;
}*/

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

/*Console.WriteLine("Введите число 1: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 3: ");
int C = int.Parse(Console.ReadLine()!);

if((A > 0 && B > 0 && C > 0) || (A < B + C && B < A + C && C < A + B)) Console.WriteLine("Такой треугольник возможен");
else Console.WriteLine("Такой треугольник невозможен");

// Опрделить, является ли заданное шестизначное число счастливым. 
// (Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его последних трех цифр).

Console.WriteLine("Введите шестизначное число: ");
string X = (Console.ReadLine()!);
int size = X.Length;
if(size != 6) System.Console.WriteLine("Число не шестизначное");
else Check(X);

//-------------

void Check(string X)

{
int Sum1 = 0;
int Sum2 = 0;

int i = 0;
while(i<size/2)
{Sum1 += Convert.ToInt32(Convert.ToString(X[i]));
i++;}
while(i<size)
{Sum2 += Convert.ToInt32(Convert.ToString(X[i]));
i++;}
if(Sum1 == Sum2) {System.Console.WriteLine("Это счастливое число");}
else {System.Console.WriteLine("Это не счастливое число");}
}*/

//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
//Числа Фибоначчи — числовая последовательность, каждый элемент которой равен сумме двух предыдущих.

/*Console.WriteLine("Введите число N: ");
int size = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"[{String.Join(",",Fibonacci(size))}]");


//-------------------------
int[] Fibonacci(int size)
{
    int[] res = new int[size];

    res[0] = 0;
    res[1] = 1;
    for (int i = 2; i < size; i++)
    {
    res[i] = res[i-1] + res[i-2];
    }
    return res;
}*/

// --------- Семинар 23 января -------------------------- 
// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);*/



// -------------------Методы---------------------------------
/*int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}*/
// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);



// -------------------Методы---------------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}*/

// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.

/*int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
    for(int j = 0; j < n; j++){
    result[i,j] = i + j;
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}*/

// **Задача 49:** Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(GetArray2(array));

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
    for(int j = 0; j < n; j++)
    {
    result[i,j] = i + j;
    }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++)
    {
    for(int j = 0; j < array.GetLength(1); j++)
    {
    Console.Write($"{array[i,j]} ");
    }
        Console.WriteLine();
    }
}

int[,] GetArray2(int[,] array)
{
   // int[,] Array2 = new int[rows,columns];
    for(int i = 0; i < array.GetLength(0); i++)
    {
    for(int j = 0; j < array.GetLength(1); j++)
    {
    if (i % 2 == 0 && j % 2 == 0) 
    array[i,j] = array[i,j] * array[i,j];
    }
    }
    return array;
}*/
//Задача 51:** Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали
//(с индексами (0,0); (1;1) и т.д.
/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine($"The sum is equal to {GetSumOfElements(array)}");

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
    for(int j = 0; j < n; j++)
    {
    result[i,j] = i + j;
    }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++)
    {
    for(int j = 0; j < array.GetLength(1); j++)
    {
    Console.Write($"{array[i,j]} ");
    }
        Console.WriteLine();
    }
}

int GetSumOfElements(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for(int j = 0; j < array.GetLength(1); j++)
    {
    if (i == j) 
    sum = sum + array[i,j];
    }
    }
    return sum;
}
*/
// -------------- Домашка 19 января ------------------------

//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

/*Console.WriteLine("Enter an array of numbers separated by spaces");
string numbers = Console.ReadLine()!;
string[] array = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
Console.Write($"The sum of negative numbers in this array is {GetSumOfNegatives(array)}");

int GetSumOfNegatives(string[] array)
{
    int size = array.Length;
    int sum = 0;
    int i = 0;
    while(i < size)
{
    if (Convert.ToInt32(Convert.ToString(array[i])) < 0)
    sum += 1;
    i++;
}
return sum;
};*/

// Задача 43: Написать программу, которая на вход принимает массив
// из любого количества элементов (не менее 6) в промежутке от 0 до 100,
// а на выходе выводит этот же массив, отсортированный по возрастанию.

/*int[] array = GetArray(10);
Console.Write($"[{String.Join(",", array)}] ");
Console.WriteLine();

SortAscendingOrder(array);
Console.Write($"[{String.Join(",", array)}] ");
Console.WriteLine();

ArrayAscending(array);
Console.Write($"[{String.Join(",", array)}] ");

// ----------------- methods ---------------------------------
int[] GetArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
};

void SortAscendingOrder (int[] array)
{
    int size = array.Length;
    int temp;
    for (int i = 0; i < size; i++)
    {
    for (int j = i + 1; j < size; j++)
    {
    if (array[i] > array[j])
    {
    temp = array[i];
    array[i] = array[j];
    array[j] = temp;
    } 
    }
    }               
}

int[] ArrayAscending (int[] array)
{
    int i = 0;
    while (i < array.Length - 1)
    {
    int j = i + 1;
    int min = i;
    if (array[j] < array[min]) min = j;
    {
    int temp = array[min];
    array[min] = array[i];
    array[i] = temp;
    }
    i++;
    } 
    return array; 
}*/




// -------------- СЕМИНАР 26 ЯНВАРЯ ----------------------------------------------
//Задача 53: Задайте двумерный массив.
//Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*Console.Write("Enter a number of rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter a number of columns: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

ChangeLine(array);
PrintArray(array);


// ------------------- methods -----------------------------
/*int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();

    }
}

void ChangeLine (int[,] array)
{
for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0,j];
        array[0,j] = array[array.GetLength(0)-1, j];
        array[array.GetLength(0)-1, j] = temp;
    }
}*/

//Задача 55: Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести
// сообщение для пользователя.

/*Console.Write("Enter a number of rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter a number of columns: ");
int columns = int.Parse(Console.ReadLine()!);

if (rows != columns)
{
    Console.WriteLine("Такая замена невозможна");
}
else 
{
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

int[,] NewArray = ChangeRowsToColumns(array);
PrintArray(NewArray);
}

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();

    }
}

int[,] ChangeRowsToColumns (int[,] array)
{

    int[,] NewArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0 ; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            NewArray[j,i] = array[i,j];
        }
    }
    return NewArray;
}*/

// Задача 59: Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.

/*Console.Write("Enter a number of rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter a number of columns: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

int[] Indexes = FindIndexesOfMin(array);
Console.WriteLine($"{Indexes[0]}, {Indexes[1]}");
Console.WriteLine();
PrintArray(NewArray(array, FindIndexesOfMin(array)));

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();

    }
}

int[] FindIndexesOfMin(int[,] array)
{
    int min = array[0,0];
    int[] MinIndexes = new int[2];

    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        if (array[i,j] < min)
        {min = array[i, j];
        MinIndexes[0] = i;
        MinIndexes[1] = j;
        }

        }
    }
return MinIndexes;
}

int[,] NewArray(int[,] array, int[] Indexes)
{
int[,] NewArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
int rows = 0;
int columns = 0;
for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == Indexes[0]) continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
        if (j == Indexes[1]) continue;
        NewArray[rows,columns] = array[i,j];
        columns++;
        }
        columns = 0;
        rows++;
    }
    return NewArray;
}*/


// ------------- Домашка 23 января -----------------------------------

// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

/*Console.Write("Enter a number of rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter a number of columns: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

----------------- methods ----------------------
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++){
    result[i,j] = Math.Round(new Random().NextDouble()
    + new Random().Next(minValue,maxValue),1); 
    }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
};*/

// Задача 50. Напишите программу, которая на вход принимает число,
// и проверяет есть ли такое число в двумерном массиве,
// а также возвращает сообщение о том, что оно найдено
// или же указание, что такого элемента нет.

/*Console.Write("Enter a number of rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter a number of columns: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 30);
PrintArray(array);
Console.WriteLine();

Console.Write("What number are we looking for? ");
int Number = int.Parse(Console.ReadLine()!);
CheckNumber(array, Number);

// ------------------- Methods ---------------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
if (CheckNumber(array, Number))
    {Console.WriteLine($"The Number {Number} is present in this array");}
    else
    {Console.WriteLine("There is no such number in this array");}

bool CheckNumber (int[,] array, int Number)
{
    foreach (int arrayEl in array)
    {
    if (arrayEl == Number)
        {return true;}
    }
    return false;
}*/

// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

/*Console.Write("Enter a number of rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter a number of columns: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

int[] Sum = ColumnsSum (array);
Console.Write($"[{String.Join(",", Sum)}]");
Console.WriteLine();

double[] Mean = GetArithmeticMean(Sum);
Console.Write($"[{String.Join(";", Mean),1}]");

// ------------------- methods -----------------------------

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[] ColumnsSum (int[,] array)
{
    int size = array.GetLength(1);
    int [] Sum = new int[size];
    int sum = 0;
    int i = 0;
    int j = 0;

    while(j < size)
        {
            while (i < array.GetLength(0)) 
            {
                sum = sum + array[i,j];
                i++;
                Sum[j] = sum;
            }
            i = 0;
            sum = 0;
            j++;
        }
        return Sum;
}

double[] GetArithmeticMean(int[] Sum)
{
    int size = array.GetLength(1);
    double[] Mean = new double[size];
    for(int j = 0; j < size; j++)
        {
            Mean[j] = Convert.ToDouble(Sum[j]) / size;
        }
    return Mean;
}*/

// Задача 63:** Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"

// N = 6 -> "1, 2, 3, 4, 5, 6"

/*Console.Write("Введи число: ");
int N  = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(1,N));

// ------------------Метод------------------
string PrintNumbers(int start, int end)
{
    if(start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}*/


//Задача 65: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

/*Console.WriteLine("Введите число  N");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число  M");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N,M));


string PrintNumbers(int start, int end)
{
    if(start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}*/

// Принять на вход число, вернуть сумму его цифр

/*Console.WriteLine("Введите число  N");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumberFiguresSum(N));

int NumberFiguresSum(int N)
{
    if(N == 0) return 0;
    return (N % 10 + NumberFiguresSum(N / 10));
}*/

// Возведите число А в степень Б с помощью рекурсии

/*Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine(PoweredBy(A,B));

// --------------method-------------------

int PoweredBy(int A, int B)
{
    if(B == 0) return 1;
    if(B == 1) return A;
    return (A * PoweredBy(A, B - 1));
}*/

// Найдите факториал числа c помощью рекурсии

/*Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(FactorialOf(N));

int FactorialOf(int N)
{
    if(N == 0) return 1;
    if(N == 1) return 1;
    return (N * FactorialOf(N - 1));
}*/


// ------------------ Домашка 30 января --------------------------------
// Задача 64: Выполнить с помощью рекурсии.Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

/*Console.Write("Enter a number: ");
int N  = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N,1));

// ------------------Метод------------------
string PrintNumbers(int start, int end)
{
    if(start == end) return start.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
}*/

// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.

/*Console.WriteLine("Enter number M");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number N");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumOfFiguresBetweenMAndN(M,N));

int SumOfFiguresBetweenMAndN(int M, int N)
{
    if (M == N) return M;
    return (M + SumOfFiguresBetweenMAndN(M + 1, N));
}*/

// Задача 68: Выполнить с помощью рекурсии.
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
 
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(n, m));

int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akkerman(n - 1, 1);
    if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
    return Akkerman(n,m);
}