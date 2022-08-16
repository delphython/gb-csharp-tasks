//------------------------ Решение задачи 50 ------------------------------
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
// диагонали (с индексами (0,0); (1;1) и т.д.
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
            outputArray[i, j] = rand.Next(1, 10);
        }
    }
    
    return outputArray;
}

// Метод sumDiagonalArray, который ищет сумму элементов дмагонали двумерного массива
int sumDiagonalArray(int[,] inputArray)
{
    int colLenght = inputArray.GetLength(0);
    int rowLenght = inputArray.GetLength(1);
    int sum = 0;
    
    for (int i = 0; i < colLenght; i++)
    {
        for (int j = 0; j < rowLenght; j++)
        {
            if (i==j) sum += inputArray[i, j];
        }
    }
    
    return sum;
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
    // Считываем данные с консоли
    int m;
    int n;
    getConsoleData(out m, out n);
    
    // Заполняем массив
    int[,] filledArray = fillArray(m, n);

    // Выводим информацию в консоль
    Console.WriteLine($"Сумма элементов диагонали массива \n{printTwoDimArray(filledArray)}= {sumDiagonalArray(filledArray)}");
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
