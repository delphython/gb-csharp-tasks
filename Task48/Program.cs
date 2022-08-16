//------------------------ Решение задачи 48 ------------------------------
// Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//------------------------------------------------------------------------

// Метод fillArray, который заполняет двумерный массив
int[,] fillArray(int m, int n)
{
    int[,] outputArray = new int[m, n];
    Random rand = new Random();
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            outputArray[i, j] = j + i;
        }
    }
    
    return outputArray;
}

// Метод printTwoDimArray, который переводит двумерный массив в строку для вывода в консоль
string printTwoDimArray(int [,] inputArray)
{
    string outputString = "";
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(0); j++)
        {
            outputString += $"{inputArray[i, j]}\t";
        }
        outputString +="\n";
    }
    
    return outputString;
}

// Метод getConsoleData для считывания данных с консоли
void getConsoleData(out int m, out int n)
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
        n = int.Parse(inputFirstLine);
    }
}

try 
{
    //Считываем данные с консоли
    int m;
    int n;
    getConsoleData(out m, out n);
    
    // Запоняем массив
    int[,] outputArray = fillArray(m, n);

    // Выводим информацию в консоль
    Console.WriteLine($"Массив {m} на {n}:\n{printTwoDimArray(outputArray)}");

}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
