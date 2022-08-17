//------------------------ Решение задачи 53 ------------------------------
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
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

// Метод avgColString, который ищет среднее арифметическое элементов в каждом столбце массива
// и возвращает их через запятую
string avgColString(int[,] inputArray)
{
    int rowLenght = inputArray.GetLength(0);
    int colLenght = inputArray.GetLength(1);
    double[] outputArray = new double[colLenght];
    
    for (int i = 0; i < colLenght; i++)
    {
        double sum = 0;
        for (int j = 0; j < rowLenght; j++)
        {
            sum += inputArray[j, i];
        }
        outputArray[i] = sum / rowLenght;
    }
   
    return string.Join("; ", outputArray);
}

// Метод avgDiagString, который ищет среднее арифметическое элементов в каждой диагонали массива
// и возвращает их через запятую
string avgDiagString(int[,] inputArray)
{
    int rowLenght = inputArray.GetLength(0);
    int colLenght = inputArray.GetLength(1);
    int countFirstDiag = 0;
    double sumFirstDiag = 0;
    int countSecondDiag = 0;
    double sumSecondDiag = 0;
    double[] outputArray = new double[2];
    
    for (int i = 0; i < rowLenght; i++)
    {
        for (int j = 0; j < colLenght; j++)
        {
            if (i == j) {
                sumFirstDiag += inputArray[i, j];
                countFirstDiag++;
            }
            if (i + j == rowLenght - 1) {
                sumSecondDiag += inputArray[i, j];
                countSecondDiag++;
            }
        }
    }

    outputArray[0] = sumFirstDiag / countFirstDiag;
    outputArray[1] = sumSecondDiag / countSecondDiag;
   
    return string.Join("; ", outputArray);
}

// Метод printTwoDimArray, который выводит двумерный массив в консоль
void printTwoDimArray(int [,] inputArray)
{
    int rowLenght = inputArray.GetLength(0);
    int colLenght = inputArray.GetLength(1);

    for (int i = 0; i < rowLenght; i++)
    {
        for (int j = 0; j < colLenght; j++)
        {
            if (i==j) Console.ForegroundColor = ConsoleColor.Red;
            if (i + j == rowLenght - 1) Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{inputArray[i, j]}\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    
    Console.WriteLine($"Среднее арифметическое каждого столбца массива:\n{avgColString(inputArray)}");
    Console.WriteLine($"Среднее арифметическое каждой диагонали массива:\n{avgDiagString(inputArray)}");   
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
    // Считываем данные с консоли
    int m;
    int n;
    getConsoleData(out m, out n);
    
    // Заполняем массив
    int[,] filledArray = fillArray(m, n);

    // Выводим информацию в консоль
    printTwoDimArray(filledArray);
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
