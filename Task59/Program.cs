//------------------------ Решение задачи 59 ------------------------------
// Вывести первые N строк треугольника Паскаля.Сделать вывод в виде 
// равнобедренного  треуголника 
//------------------------------------------------------------------------

// Метод GetFactorial, который считает факториал числа
double GetFactorial(int n)
{
    double i, fact = 1;
    
    for (i = 1; i <= n; i++)
        fact *= i;

    return fact;
}

// Метод PrintPascalTriangle, который печатает треугольник Паскаля
void PrintPascalTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= (n - i); j++)
            Console.Write(" "); 
        for (int k = 0; k <= i; k++)
        {
            Console.Write(" ");
            Console.Write(GetFactorial(i) / (GetFactorial(k) * GetFactorial(i - k)));
        }
        Console.WriteLine();
    }
}

// Метод GetConsoleData для считывания данных с консоли
void GetConsoleData(out int n)
{
    n = 0;
    
    Console.WriteLine("Введите размер двумерного массива n на n");
    Console.Write("n = ");
    string? inputFirstLine = Console.ReadLine();

    if (inputFirstLine != null)
        n = int.Parse(inputFirstLine);
}

try 
{
    //Считываем данные с консоли
    int n;
    GetConsoleData(out n);
    
    // Выводим информацию в консоль
    PrintPascalTriangle(n);
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
