// Метод, который записывает отфильтрованные значения в новый массив
void FilterLongString(string[] array)
{
    string[] new_array = new string[array.Length];

    for (int i = 0, j = 0; i < array.Length; i++, j++)
    {
        if (array[i].Length > 3) j--;
        else new_array[j] = array[i];
    }

    PrintArray(new_array);
}

// Метод вывода на экран результата
void PrintArray(string[] array)
{
    Console.Write("\nРезультат решения: ");

    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
}

string[] array = new string[5];

Console.WriteLine("Введите слово, символ или строку:");
for (int i = 0; i < 5; i++)
{
    array[i] = Console.ReadLine();
    if (array[i] == "")
    {
        Console.Write("Попробуйте еще....\n");
        i--;
    }
}

FilterLongString(array);