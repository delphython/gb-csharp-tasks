//------------------------ Решение задачи 49 ------------------------------
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
//  и замените эти элементы на их квадраты.
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

// Метод changeArray, который ищет элементы, у которых оба индекса чётные,
// и заменяет эти элементы на их квадраты.
int[,] changeArray(int[,] inputArray)
{
    int colLenght = inputArray.GetLength(0);
    int rowLenght = inputArray.GetLength(1);

    int[,] outputArray = new int[colLenght, rowLenght];
    Random rand = new Random();
    
    for (int i = 0; i < colLenght; i++)
    {
        for (int j = 0; j < rowLenght; j++)
        {
            if (i%2==0 && j%2==0) outputArray[i, j] = inputArray[i, j] * inputArray[i, j];
            else outputArray[i, j] = inputArray[i, j];
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
    // Считываем данные с консоли
    int m;
    int n;
    getConsoleData(out m, out n);
    
    // Заполняем массив
    int[,] filledArray = fillArray(m, n);

    // Меняем массив согласно условиям задачи
    int[,] outputArray = changeArray(filledArray);

    // Выводим информацию в консоль
    Console.WriteLine($"Массив был:\n{printTwoDimArray(filledArray)}\nМассив стал:\n{printTwoDimArray(outputArray)}");
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
