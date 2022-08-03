//------------------------ Решение задачи 29 ------------------------------
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе
// * Сделать оценку времени алгоритма через вещественные числа и строки
//------------------------------------------------------------------------

using System;
using System.Diagnostics;

// Объявляем метод printNumberSumByString, который считает сууму цифр через строку
void printNumberSumByString(string number)
{
    // Парсим строку на символы, конвертируем их в int и добавляем в массив
    int[] digits = Array.ConvertAll(number.ToCharArray(), s => (int)Char.GetNumericValue(s));

    // Считаем сумму всех чисел массива, переводим в строку и выводим ее
    Console.WriteLine($"Сумма всех цифр числа {number} равно {digits.Sum().ToString()}");
}

// Объявляем метод printNumberSumByDouble, который считает сууму цифр через вещественные числа
void printNumberSumByDouble(string number)
{
    // Парсим число
    int inputNumber = int.Parse(number);

    // Считаем сумму всех цифр числа
    int digitsSum = 0;
    while (inputNumber != 0) 
    {
        digitsSum += inputNumber % 10;
        inputNumber /= 10;
    }

    // Выводим сумму
    Console.WriteLine($"Сумма всех цифр числа {number} равно {digitsSum.ToString()}");
}

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    try 
    {
        // Проверяем, что введено число
        int Num;
        bool isNum = int.TryParse(inputLine, out Num);

        Stopwatch clock = new Stopwatch();
        
        // Если число, то выводим результат, если нет, то выводим соответствующее сообщение
        if (isNum)
        {
            Stopwatch clock1 = new Stopwatch();
            Stopwatch clock2 = new Stopwatch();
            
            clock1.Start();
            printNumberSumByString(inputLine);
            clock1.Stop();

            clock2.Start();
            printNumberSumByDouble(inputLine);
            clock2.Stop();

            Console.WriteLine($"Время выполнения printNumberSumByString: {clock1.Elapsed}");
            Console.WriteLine($"Время выполнения printNumberSumByDouble: {clock2.Elapsed}");
        }
        else
        {
            Console.WriteLine("Введено не число!");
        }

    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
