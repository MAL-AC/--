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

// int Sum (int num)
// {
//     int sum = 0;

//     while (num > 0)
//     {
//         sum = sum + num % 10;
//         num = num / 10;
//     }

//     return sum;
// }

// Console.Write("input a umber: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = Sum (num);
//  Console.WriteLine($"The result of the sum of all digits of the number {num} is {result}");


// Задача 29.
//  Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i <size; i++)
//     {
//         Console.Write("input a number : ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//         return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
    
//     Console.WriteLine();
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());


// int[] newArray = CreateArray(size);
// ShowArray(newArray);
