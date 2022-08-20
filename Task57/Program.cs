//------------------------ Решение задачи 57 ------------------------------
// Составить частотный словарь элементов двумерного массива. Частотный словарь
//  содержит информацию о том, сколько раз встречается элемент входных данных
//------------------------------------------------------------------------

// Метод FillArray, который заполняет двумерный массив
int[,] FillArray(int m, int n)
{
    int[,] outputArray = new int[m, n];
    Random rand = new Random();
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            outputArray[i, j] = rand.Next(0, 100);
        }
    }
    
    return outputArray;
}

// Метод TwoDimArrayToList преобразует двумерный массив в список
List<int> TwoDimArrayToList(int[,] inputArray)
{
    int[] tmp = new int[inputArray.GetLength(0) * inputArray.GetLength(1)];    
    Buffer.BlockCopy(inputArray, 0, tmp, 0, tmp.Length * sizeof(int));
    return new List<int>(tmp);
}

// Метод GetFreqDict, который возвращает частотный словарь двумерного массива 
Dictionary<int, int> GetFreqDict(int[,] inputArray)
{
    Dictionary<int, int> freq = new Dictionary<int, int>();

    // Преобразуем двумерный массив в список
    List<int> inputList = TwoDimArrayToList(inputArray);

    // Заполняем частотный словарь
    foreach(int number in inputList)
    {            
        if(freq.ContainsKey(number))
            ++freq[number];
        else 
            freq[number] = 1;
    }
    
    return freq;
}

// Метод PrintTwoDimArray, который переводит двумерный массив в строку для вывода в консоль
string PrintTwoDimArray(int [,] inputArray)
{
    string outputString = "";
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            outputString += $"{inputArray[i, j]}\t";
        }
        outputString +="\n";
    }
    
    return outputString;
}

// Метод PrintDictionary, который переводит словарь в строку для вывода в консоль
void PrintDictionary(Dictionary<int, int> inputDict)
{
    foreach(KeyValuePair<int, int> pair in inputDict)
        Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
}

// Метод GetConsoleData для считывания данных с консоли
void GetConsoleData(out int m, out int n)
{
    m = 0;
    n = 0;
    
    Console.WriteLine("Введите размер двумерного массива m на n");
    Console.Write("m = ");
    string? inputFirstLine = Console.ReadLine();
    Console.Write("n = ");
    string? inputSecondLine = Console.ReadLine();

    if (inputFirstLine != null && inputSecondLine != null)
    {
        m = int.Parse(inputFirstLine);
        n = int.Parse(inputSecondLine);
    }
}

try 
{
    //Считываем данные с консоли
    int m;
    int n;
    GetConsoleData(out m, out n);
    
    // Заполняем массив
    int[,] filledArray = FillArray(m, n);

    // Формируем частотный словарь
     Dictionary<int, int> freqDict = GetFreqDict(filledArray);

    // Выводим информацию в консоль
    Console.WriteLine($"Для массива:\n{PrintTwoDimArray(filledArray)}\nЧастотный словарь:");
    PrintDictionary(freqDict);

}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
