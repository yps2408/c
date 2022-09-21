// 
string [] array = new string [10];

string [] FillStringArray(string [] array)
{
    for(int i = 0; i < array.Length; i = i + 2)
    {
        int temp = new Random().Next(-10000, 10000);
        array[i] = Convert.ToString(temp);
    }
    for(int i = 1; i < array.Length; i = i + 2)
    {
       Console.WriteLine("Введите символы элемента строки: ");
       array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string [] FillStringArrayAvailableValues(string [] array, int N)
{
    string [] result = new string [N];
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
             result[j] = array[i];
             j++;
        }
    }
    return result;
}

int NumberOfCharactersPerLine(string [] array)
{
    int N = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
            N++;
        }
    }
    return N;
}


FillStringArray(array);
PrintArray(array);

int N = NumberOfCharactersPerLine(array);
Console.WriteLine(N);

string [] newArray = FillStringArrayAvailableValues(array, N);
PrintArray(newArray);

