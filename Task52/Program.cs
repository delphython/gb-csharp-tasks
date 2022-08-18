//------------------------ Решение задачи 52 ------------------------------
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Заполнить числами Фиббоначи и выделить цветом найденную цифру
//------------------------------------------------------------------------

// Метод возвращает n-ое число Фиббоначи 
int getFib(int n)  
{  
    if ((n == 0) || (n == 1)) return n;
    return getFib(n - 1) + getFib(n - 2);  
} 

// Метод fillArray, который заполняет двумерный массив
int[,] fillArray(int m, int n)
{
    int[,] outputArray = new int[m, n];
    int count = 0;
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            outputArray[i, j] = getFib(count);
            count++;
        }
    }
    
    return outputArray;
}

// Метод printTwoDimArray, который выводит двумерный массив в консоль
void printTwoDimArray(int [,] inputArray, int m, int n)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (i==m && j==n) Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{inputArray[i, j]}\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    if (m > inputArray.GetLength(0)-1 || n > inputArray.GetLength(1)-1)
        Console.WriteLine($"Элемента с позицией [{m}, {n}] нет в массиве"); 
    else
        Console.WriteLine($"Элемент с позицией [{m}, {n}] помечен красным цветом");   
}

// Метод getConsoleData для считывания данных с консоли
void getConsoleData(out int m, out int n)
{
    m = 0;
    n = 0;
    
    Console.WriteLine("Введите позиции элемента двумерного массива m и n");
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
    int[,] outputArray = fillArray(3, 3);

    // Выводим информацию в консоль
    printTwoDimArray(outputArray, m, n);

}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
