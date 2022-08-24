//------------------------ Решение задачи 69 ------------------------------
// Задайте значения M и N. Напишите программу вычисления функции Аккермана
// с помощью рекурсии
//------------------------------------------------------------------------

// Метод SumNaturalNumbers, который считает сумму натруальных чисел от M до N
long GetAkkermanFunc(long m, long n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return GetAkkermanFunc(m-1, 1);
    if (n > 0 && m > 0) return GetAkkermanFunc(m-1, GetAkkermanFunc(m, n-1));
    
    // throw new System.ArgumentOutOfRangeException();
}

// Метод GetConsoleData для считывания данных с консоли
void GetConsoleData(out long m, out long n)
{
    m = 0;
    n = 0;
    
    Console.WriteLine("Введите неотрицательных числа m и n");
    Console.Write("m = ");
    string? inputFirstLine = Console.ReadLine();
    Console.Write("n = ");
    string? inputSecondLine = Console.ReadLine();

    if (inputFirstLine != null && inputSecondLine != null)
    {
        m = long.Parse(inputFirstLine);
        n = long.Parse(inputSecondLine);
    }
}

try 
{
    //Считываем данные с консоли
    long m;
    long n;
    GetConsoleData(out m, out n);

    // Выводим информацию в консоль
    Console.WriteLine($"Результат вычисления функции Аккермана А({m},{n}) = {GetAkkermanFunc(m, n)}");
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
