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

int ShortStringsCount(string[] array, int miniLength)
{
    int shortStringsCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= miniLength) shortStringsCount++;
    }
    return shortStringsCount;
}

string[] ShorterStringsArrayCreate(string[] baseArray, int targetArrayLength, int miniLength)
{
    string[] targetArray = new string[targetArrayLength];
    int j = 0;
    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i].Length <= miniLength) targetArray[j++] = baseArray[i];
    }
    return targetArray;
}

Console.Write("Введите количество элементов массива: ");
int nStrings = Convert.ToInt32(Console.ReadLine());
string[] stringsArray = ArrayInput(nStrings);

int minStringLenght = 3;
int shorterStings = ShortStringsCount(stringsArray, minStringLenght);

string[]shorterStringsArray = ShorterStringsArrayCreate(stringsArray,shorterStings,minStringLenght);
Console.WriteLine(shorterStings);
