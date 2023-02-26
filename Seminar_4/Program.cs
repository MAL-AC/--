// Задача 1.
// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

// int GetSum(int a)
// {
//     int sum = 0;

//     for(int current = 1; current <= a; current++)
//         sum += current;

//         return sum;
// }

// Console.WriteLine("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = GetSum(number);
// Console.WriteLine($"Sum of numbers from 1 to {number} is {result}");


// Задача 2.
// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.

// int Digits(int num)
// {
//    int digits = 0;
//     if (num == 0) digits = 1;

//     for(;num!=0; digits++)  
//     num /= 10;

//     return digits;
// }
// Console.Write("Input number ");
// int number = Convert.ToInt32(Console.ReadLine());

// int dig = Digits(number);

// Console.WriteLine($"There are {dig} digits in {number}");


// Задача 3.
// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.

// int Factorial (int num)
// {
//     int result = 1;

//     for (int current = 1; current <= num; current++)
//     {
//         result *= current;
//     }

//     return result;
// }

// Console.Write("Input number ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = Factorial(number);

// Console.WriteLine($"Factorial of number {number} is {result}");


// Задача 4. Массивы

// int[] CreateRandomArray(int size , int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i <size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

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
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);


