int PromptInt(string message) // Для ввода количества элементов в изначальном массиве
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

string PromptStr(string message) // метод для ввода элементов в изначальный массив
{
    Console.Write(message);
    string arrElement = Console.ReadLine();
    return arrElement;
}

string[] CreateInitialArray(int quantity) // Метод для создания изначального массива
{
    string[] strArray = new string[quantity];
    for (int i = 0; i < quantity; i++)
    {
        string arrayCell = PromptStr($"Type the element #{i + 1} of the initial array: ");
        strArray[i] = arrayCell;
    }
    return strArray;
}


string[] LeaveShortElements(string[] array) // Метод для создания массива с меньшими элементами
{
    string[] result = new string[array.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}

void PrintArray(string[] strArray) // Метод для вывода массива на консоль 
{
    System.Console.Write($"{strArray[0]}");
    for (int i = 1; i < strArray.Length; i++)
    {
        System.Console.Write($", {strArray[i]}");
    }
}

void Execute() // Метод для запуска выполнения программы
{
    int amount = PromptInt("Type the quantity of elements you'd like to have in the initial array: ");
    string[] firstArray = CreateInitialArray(amount);
    string[] secondArray = LeaveShortElements(firstArray);

    Console.Write("\nThe initial array is: ");
    PrintArray(firstArray);

    System.Console.WriteLine();

    Console.Write("\nThe resulting array is: ");
    PrintArray(secondArray);
}

Execute();