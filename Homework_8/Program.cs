// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int [rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random(). Next(minValue, maxValue + 1);

    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeNumOfRows(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int min = 0; min < array.GetLength(1) - 1; min++)
        {
            if (array[i, min] < array[i, min + 1]) 
            {
                int temp = 0;
                temp = array[i, min];
                array[i, min] = array[i, min + 1];
                array[i, min + 1] = temp;
            }
        }
    }
}
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

ChangeNumOfRows (newArray);
Show2dArray(newArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int [rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random(). Next(minValue, maxValue + 1);

    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinSumOfRow (int [,] array)
{
    int minsum = Int32.MaxValue;;
    int minrow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum+= array [i,j];
        }
        if(minsum > sum)
            {
                minsum = sum;
                minrow = i+1;
            }   
    }
      Console.Write($"Minimum sum of elements in {minrow} row");
}
    
int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

MinSumOfRow(newArray);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
    Console.Write("input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = new int[rows, columns];

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] firstArray = new int [rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            firstArray[i,j] = new Random(). Next(minValue, maxValue + 1);

    return firstArray;
}
void Show2dArray(int[,] firstArray)
{
    for(int i = 0; i < firstArray.GetLength(0); i++)
    {
        for(int j = 0; j < firstArray.GetLength(1); j++)
            Console.Write(firstArray[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] firstArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(firstArray);

int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] secondArray = new int [rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            secondArray[i,j] = new Random(). Next(minValue, maxValue + 1);

    return secondArray;
}
void ShowArray(int[,] secondArray)
{
    for(int i = 0; i < secondArray.GetLength(0); i++)
    {
        for(int j = 0; j < secondArray.GetLength(1); j++)
            Console.Write(secondArray[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] secondArray = CreateRandomArray(rows, columns, minValue, maxValue);
ShowArray(secondArray);

for (int i = 0; i < firstArray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < firstArray.GetLength(1); k++)
        {
            resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
        }
    }
}

ShowArray(resultArray);
*/

// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.7

/*
Console.Write("input a numbers of rows: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("input a numbers of columns: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("input a numbers of deep: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,,] array3D = new int[x, y, z];

void ShowArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ({i}, {j}, {k}); ");
            }
            Console.WriteLine();
        }
    }
}

void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(minValue, maxValue);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(minValue, maxValue);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

CreateArray(array3D);
ShowArray(array3D);
*/

// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.

/*
Console.Write("input the size of the sides for the square array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] sqareArray = new int[size, size];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareArray.GetLength(0) * sqareArray.GetLength(1))
{
    sqareArray[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareArray.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(sqareArray);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

*/