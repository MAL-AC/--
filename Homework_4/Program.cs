// Задача 25.
//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int composition(int numA, int numB)
// {
//    int sum = 1;

//    for(int current = 1; current <= numB; current++)
//         sum = sum * numA;

//         return sum;
// }
// Console.Write("input a number A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("input a number B: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// int result = composition (numA, numB);
// Console.WriteLine($"number A to the power of B is equal to {result}");


// Задача 27.
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum (int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }

    return sum;
}


Console.Write("input a umber: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = Sum (num);
 Console.WriteLine($"Resolt is {result}");