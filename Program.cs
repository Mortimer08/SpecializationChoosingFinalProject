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



Console.Write("Введите количество элементов массива: ");
int nStrings = Convert.ToInt32(Console.ReadLine());

string []stringsArray = ArrayInput(nStrings);