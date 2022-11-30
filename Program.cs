string[] Input_string(int a)
{
    string[] result = new string[a];
    for(int i = 0; i<a; i++)
    {
        Console.Write($"Введите {i} элемент: ");
        result[i]= Console.ReadLine();
    }
    return result;
}

int Input_razmer()
{
    Console.WriteLine("Введите кол-во элементов массива: ");
    return Convert.ToInt32(Console.ReadLine());
}

string[] calculation(string[] array)
{
    int a = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            a++;                       
        }
    }
    string[] result = new string[a];
    a = -1;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
           a++;
           result[a]= array[i];                       
        }
    }
    return result;
}

void Print(string[] array)
{
    Console.WriteLine(string.Join(' ', array));
}

Print(calculation(Input_string(Input_razmer())));