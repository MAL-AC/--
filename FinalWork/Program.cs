string [] CreateArray()
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

string[] CopyArray(string[] array)
{
    string[] result = new string[array.LongLength];
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= 3)
        result [i] = array [i];
    return result;
}

void ShowArray(string[] result)
{
    for(int i = 0; i < result.Length; i++)
    {
        Console.Write(result[i] + " ");
    }
}

string[] newArray = CreateArray();
ShowArray(CopyArray(newArray));



