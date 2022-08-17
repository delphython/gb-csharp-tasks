//------------------------ Решение задачи 51 ------------------------------
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
//------------------------------------------------------------------------

// Расширение стандартного метода NextDouble
double getRandDouble(double min, double max)
{ 
    Random rand = new Random();
    return rand.NextDouble() * (max - min) + min;
}

// Метод fillArray, который заполняет двумерный массив
double[,] fillArray(int m, int n)
{
    double[,] outputArray = new double[m, n];
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            outputArray[i, j] = getRandDouble(-10, 10);
        }
    }
    
    return outputArray;
}

// Метод возвращает цвет консоли по индексу
ConsoleColor getAnotherColor(int index)
{
    ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
    return colors[index];
}

// Метод printTwoDimArray, который выводит двумерный массив в консоль
void printTwoDimArray(double [,] inputArray)
{
    int ind = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            foreach (char c in inputArray[i, j].ToString())
            {
                Console.ForegroundColor = getAnotherColor(ind);
                Console.Write(c);
                if (ind == 15) ind = 0;
                else ind++;
            }
            Console.Write("\t");
        }
        Console.WriteLine();
    }
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
    
    // Запоняем массив
    double[,] outputArray = fillArray(m, n);

    // Выводим информацию в консоль
    printTwoDimArray(outputArray);

}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
