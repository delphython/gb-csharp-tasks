//------------------------ Решение задачи 61 ------------------------------
// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц
//------------------------------------------------------------------------

// Метод FillArray, который заполняет двумерный массив
double[,] FillArray(int m, int n)
{
    double[,] outputArray = new double[m, n];
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

// Метод ChangeArray, который заменяет строки на столбцы 
double[,] ChangeArray(double[,] inputArrayOne, double[,] inputArrayTwo)
{
    int rowLenght = inputArrayOne.GetLength(0);
    int colLenght = inputArrayOne.GetLength(1);

    double[,] outputArray = new double[colLenght, rowLenght];

    for (int i = 0; i < rowLenght; i++)
    {
        for (int j = 0; j < colLenght; j++)
        {
            outputArray[i, j] = inputArrayOne[i, j] * inputArrayTwo[i, j];
        }
    }
    
    return outputArray;
}

// Метод PrintTwoDimArray, который переводит двумерный массив в строку для вывода в консоль
string PrintTwoDimArray(double [,] inputArray)
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
    
    // Заполняем первый массив
    double[,] filledArrayOne = FillArray(m, n);

    // Заполняем второй массив
    double[,] filledArrayTwo = FillArray(m, n);

    // Перемножаем массивы
    double[,] outputArray = ChangeArray(filledArrayOne, filledArrayTwo);

    // Выводим информацию в консоль
    Console.WriteLine($"Массивы были:\n{PrintTwoDimArray(filledArrayOne)}\n{PrintTwoDimArray(filledArrayTwo)}");
    Console.WriteLine($"Результат произведения:\n{PrintTwoDimArray(outputArray)}");

}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
