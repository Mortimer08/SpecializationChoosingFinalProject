string[] ArrayInput(int numberOfElements)
{
    string[] arrayOfStings = new string[numberOfElements];
    for (int i = 0; i < numberOfElements; i++)
    {
        Console.Write($"Введите строку № {i + 1}: ");
        arrayOfStings[i] = Console.ReadLine();
    }
    return arrayOfStings;
}

int ShortStringsCount(string[] array, int miniLenght)
{
    int shortStringsCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=miniLenght) shortStringsCount++;
    }
    return shortStringsCount;
}

Console.Write("Введите количество элементов массива: ");
int nStrings = Convert.ToInt32(Console.ReadLine());

string[] stringsArray = ArrayInput(nStrings);
int minStringLenght = 3;

int shorterStings = ShortStringsCount(stringsArray,minStringLenght);

Console.WriteLine(shorterStings);
