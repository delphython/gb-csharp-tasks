//------------------------ Решение задачи 54 ------------------------------
// Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.
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
            outputArray[i, j] = rand.Next(-100, 100);
        }
    }
    
    return outputArray;
}

// Метод changeArray, который меняет местами первую и псоледнюю строку массива,
int[,] changeArray(int[,] inputArray)
{
    int rowLenght = inputArray.GetLength(0);
    int colLenght = inputArray.GetLength(1);

    int[,] outputArray = inputArray.Clone() as int[,];

    int rowIndexFirst = 0;
    int rowIndexSecond = rowLenght-1;

    for (int i = 0; i < colLenght; i++)
    {
        int tmp = outputArray[rowIndexFirst, i];
        outputArray[rowIndexFirst, i] = outputArray[rowIndexSecond, i];
        outputArray[rowIndexSecond, i] = tmp;
    }
    
    return outputArray;
}

// Метод printTwoDimArray, который переводит двумерный массив в строку для вывода в консоль
string printTwoDimArray(int [,] inputArray)
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
        n = int.Parse(inputSecondLine);
    }
}

try 
{
    //Считываем данные с консоли
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
