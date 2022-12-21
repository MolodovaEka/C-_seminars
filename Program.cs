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

Console.WriteLine ("Type a number: ");
int num = int.Parse(Console.ReadLine()!);

int num1 = - num;

while (num1 <= num){
    Console.Write($"{num1} ");
    num1 ++;
};




