// Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

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

// int GetNegativeSum(int[] array)
// {
//     int sum = 0;

//     for(int i = 0; i < array.Length; i++)
//             if(array[i] < 0)
//                 sum += array[i];
//     return sum;
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);
// int result = GetNegativeSum(newArray);
// Console.WriteLine("Sum of negatives is" + result);




// Задача 2.
// Напишите программу замены элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.

// int[] ChangePosAndNeg(int[] array)
// {
    
//     for(int i = 0; i < array.Length; i++)
//             array[i] = -1 * array[i];

//     return array;
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
// ShowArray(ChangePosAndNeg(newArray));


// Задача 3.
// Задайте массив. Напишите программу, которая определяет,присутствует ли заданное число в массиве.
/*
bool HaveNumber(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)

        if(array[i] == num)
            return true;
   return false;
} 

int[] CreateRandomArray(int size , int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i <size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

        return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

 bool result = HaveNumber(newArray, num);

if(result)

    Console.WriteLine($"YES");
else 
Console.WriteLine($"NO");
*/

// Задача 4.
// Задайте одномерный массив из m случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [a,b].
/*
int HaveNumber(int[] array, int numA, int numB)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] <= numA && array[i] >=numB || array[i] >= numA && array[i] <= numB)
        sum= sum+1;

    return sum;
} 

int[] CreateRandomArray(int size , int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i <size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

        return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

int sum = HaveNumber(newArray, numA, numB);

Console.WriteLine($"Have is {sum}");
*/