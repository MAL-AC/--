// Задача 10.
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// Console.Write("Input a three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if ((99 < num && num < 1000) || (-1000 < num && num < -99))
// {
//     int CutNumber(int num)
//      {
//         int result = num/ 10 % 10;
//         return result;
//      }
//      int newNumber = CutNumber(num);

//     Console.WriteLine($"Your twice digit {newNumber} of three-digit number {num}");
// }
// else
// Console.WriteLine($"Your number {num} not three-digit number");


// Задача 13. 
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int temp = num;
// if (num >= 100 || num <= -100)
// {   
//     while (temp >= 1000 || temp <= -1000 )
//             temp = temp / 10;
//     int result = temp % 10;

//     Console.WriteLine($"the third digit of {num} is {result}");
// }
// else
// Console.WriteLine($"the number {num} does not consist of three digits");


// Задача 15.
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 8)
// {
//     if (num < 6)
//     Console.WriteLine($"the day {num} is worker");
// else
// Console.WriteLine($"the day {num} is weekend");
// }
// else 
// Console.WriteLine($"in a week of 7 days, You entered {num}");