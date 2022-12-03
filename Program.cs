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

string[] ShorterStringsArrayCreate(string[] baseArray, int miniLength)
{
    int shortStringsCount = 0;
    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i].Length <= miniLength) shortStringsCount++;
    }
    string[] targetArray = new string[shortStringsCount];
    int j = 0;
    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i].Length <= miniLength) targetArray[j++] = baseArray[i];
    }
    return targetArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"");
        Console.Write(i < array.Length - 1 ? "," : "");
    }
    Console.Write("]");
}

Console.Write("Введите количество элементов массива: ");
int nStrings = Convert.ToInt32(Console.ReadLine());
string[] stringsArray = ArrayInput(nStrings);

int minStringLenght = 3;

string[] shorterStringsArray = ShorterStringsArrayCreate(stringsArray, minStringLenght);

PrintArray(stringsArray);
Console.Write("->");
PrintArray(shorterStringsArray);
Console.WriteLine();