//------------------------ Решение задачи 55 ------------------------------
// Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
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
            outputArray[i, j] = rand.Next(-100, 100);
        }
    }
    
    return outputArray;
}

// Метод ChangeArray, который упорядочит по 
// убыванию элементы каждой строки двумерного массива
int[,] ChangeArray(int[,] inputArray)
{
    int rowLenght = inputArray.GetLength(0);
    int colLenght = inputArray.GetLength(1);

    List<int> tmpList = new List<int>();
    int[,] outputArray = new int[rowLenght, colLenght];

    for (int i = 0; i < rowLenght; i++)
    {
        // Переносим строку массива в список
        tmpList = Enumerable.Range(0, colLenght).Select(j => inputArray[i, j]).ToList();
        // Сортируем его
        tmpList.Sort();
        // Добавляем его как строку в новый массив
        for (int k = 0; k < colLenght; k++)
        {
            outputArray[i, k] = tmpList[k];
        }
    }
    
    return outputArray;
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

    // Меняем массив согласно условиям задачи
    int[,] outputArray = ChangeArray(filledArray);

    // Выводим информацию в консоль
    Console.WriteLine($"Массив был:\n{PrintTwoDimArray(filledArray)}\nМассив стал:\n{PrintTwoDimArray(outputArray)}");

}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
