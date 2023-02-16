// Задача 1.
// Напишите программу, которая выводит случайное трёхзначное 
// число и удаляет вторую цифру этого числа.
// Пример из числа 345 - число 35

// int CutNumber(int num) 
// {
//     int hundreds = num / 100;
//     int units = num % 10;
//     int resolt = hundreds * 10 + units;

//     return resolt;
// }

// int randNumber = new Random().Next(100,1000);
// int newNumber = CutNumber(randNumber);

// Console.WriteLine($"New version of {randNumber} is {newNumber}");


// Задача 2.
// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно a и b.
// IsMultiplyed - кратное,  && - и

// Вариант 1
// bool IsMultiplyedBest(int num, int div1, int div2)
// {
//     return num % div1 == 0 && num % div2 == 0;
// }

// Вариант 2
// bool IsMultiplyed(int num, int div1, int div2)
// {
//     if(num % div1 == 0 && num % div2 == 0)  // Или  if(num % div1*div2 ==0)         
//         return true;
//     else
//         return false;
// }

// Console.Write("Input a number for checking: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a first divider: ");
// int divider1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second divider: ");
// int divider2 = Convert.ToInt32(Console.ReadLine());

// bool result = IsMultiplyed(number, divider1, divider2);
// if(result)

//     Console.WriteLine($"Your number {number} is divisible by the {divider1} and {divider2}");
// else 
// Console.WriteLine($"Your number {number} is not divisible by the {divider1} and {divider2}");


// Задача 3.
// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа

// int maxNumber (int num)
// {
//     int tens = num / 10;
//     int units = num % 10; 
//     if (units > tens)
//         return units;
//     else
//         return tens;
// }

// int randNumber = new Random().Next(10,100);
// int max = maxNumber(randNumber);
// Console.WriteLine($"The max sing of number {randNumber} is {max}");


// Задача. 4
// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// ||- или

// Console.Write("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// bool SquareOrNot(int num1, int num2)
// {
//     return (num1 / num2 ==num2|| num2 / num1 == num1);
// }

// bool resolt = SquareOrNot(num1, num2);
// if(resolt)
//     Console.WriteLine($"Number {num1} or number {num2} is square of the another number");
// else
// Console.WriteLine($"Number {num1} or number {num2} is not square of the another number");