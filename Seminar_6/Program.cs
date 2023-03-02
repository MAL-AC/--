// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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

// void ReversArray(int[] array)
// {
//     for(int i =0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);
// ReversArray(newArray);
// ShowArray(newArray);


// Задача 2.
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// bool CheckTria (int a, int b, int c)
// {
//     if(a < (b + c) && b < (a+c) && c < (a + b)) return true;
//     return false;
// }

// Console.Write("Input a number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// bool result =CheckTria (a,b, c);
// if (result) Console.WriteLine ( "Треугольник есть");
// else Console.WriteLine ( "Треугольника нет");


// Задача 3.
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: a и b.

// int [] Fibonachi(int size, int a, int b)
// {
//     int[] arr = new int [size];
//     arr [0] = a;
//     arr [1] = b;
//     for(int i = 2; i < arr.Length; i++)
//     {
//         arr [i] = arr [i - 1] + arr [i-2]; 
//     }
//     return arr;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
    
//     Console.WriteLine();
// }

// Console.Write("Input a size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int [] result = Fibonachi (size, a, b);
// ShowArray(result);


// Задача 4.
// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

// int[] CopyArray(int[] array)
// {
//     int[] result = new int[array.LongLength];
//     for(int i = 0; i < array.Length; i++)
//         result [i] = array [i];
//     return result;
// }

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

// ShowArray(CopyArray(newArray));





// Задача 5.
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
string ConvertToBin(int number)
{
string res="";
int remainder;
while (number>0)
{
remainder = number % 2;
number = number / 2;

if (remainder>0) res="1"+res;
else res="0"+res;
}

return res;
}

Console.Write("Input dec number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ConvertToBin(number));
*/
/*
string ConvertToBin(int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number = number / 2;
    }
    return result;
}
Console.Write("Input dec number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ConvertToBin(number));
*/