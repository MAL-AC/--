// Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Write("Input a five-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num < 100000 && num >= 10000 || num > -100000 && num <= -10000)
// {
//     int temp1 = num / 10000;
//     int temp2 = num % 10;
//     if(temp1 == temp2)
// {
//         int temp3 = num / 1000 % 10;
//         int temp4 = num % 100 /10;
    
//         if(temp3 == temp4)
//             Console.WriteLine($"Your number is a palindrome");
//         else Console.WriteLine($"Your number is not a palindrome");
// }
//     else Console.WriteLine($"Your number is not a palindrome");
// }
// else Console.WriteLine($"Your number {num} doesn't have five digits");


// Задача 21.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Distance(double xA, double yA, double zA, double xB, double yB, double zB)
// {
//     double hypotinuse = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
    
//     return hypotinuse;
// }

// Console.WriteLine("Enter first point coordinate x: ");
// double pointAX = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter first point coordinate y: ");
// double pointAY = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter first point coordinate z: ");
// double pointAZ = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter second point coordinate x: ");
// double pointBX = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter second point coordinate y: ");
// double pointBY = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter second point coordinate z: ");
// double pointBZ = Convert.ToDouble(Console.ReadLine());

// double length = Distance(pointAX, pointAY, pointAZ, pointBX, pointBY, pointBZ);

// double result = Math.Round(length, 2, MidpointRounding.AwayFromZero);

// Console.WriteLine($"Distance between point A ({pointAX}; {pointAY}; {pointAZ}) & point B ({pointBX}; {pointBY}; {pointBZ}) is {result}");


// Задача 23.
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void TablePrint(int num)
// {
//     int current = 1;

//     while (current <= num)
//     {
//         Console.WriteLine (Math.Pow(current, 3));
//         current++;
//     }
// }

// Console.WriteLine("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// TablePrint(num);