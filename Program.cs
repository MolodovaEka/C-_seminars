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

Console.WriteLine("Type a number: ");
int number = int.Parse(Console.ReadLine()!);
int count = 0;
while(count <= number)
{
    Console.Write($"{count} ");
    count +=2;
};














