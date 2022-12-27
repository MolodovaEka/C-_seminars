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












