// string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "Rus",
// "-2", "computer science", "Russia", "Denmark", "Kazan", "GB", "GBU" };
// Console.WriteLine("Введите массив строк через пробел");
// string[] array = Console.ReadLine();


/*
string[] CopyArray(string[] array)
{
    string[] result = new string[array.LongLength];
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length >= 3)
        {
        return result [i] = array [i];
    return result;
        }
}
*/
string [] CreateRandomArray()
{   
    Console.Write("Input a quantity of elements: ");
     int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];

    for(int i = 0; i <size; i++)
    {
        Console.WriteLine($"Input {i+1} element");
        array[i] = Console.ReadLine();
    }
        return array;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length >= 3)
        Console.Write(array[i] + " ");
    }
}


// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
/*
Console.Write("Input a min possible value: ");
string min = Console.ReadLine();
Console.Write("Input a max possible value: ");
string max = Console.ReadLine();

string[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
*/

// string[] newArray = CopyArray(array);
string[] newArray = CreateRandomArray();
ShowArray(newArray);
// ShowArray(array);


