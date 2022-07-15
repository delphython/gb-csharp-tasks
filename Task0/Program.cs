//------------------------ Решение задачи 0 ------------------------------
// Напишите программу, которая на вход принимает число и выдаёт его квадрат
//------------------------------------------------------------------------

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    try 
    {
        //Парсим число
        int inputNumber = int.Parse(inputLine);

        // Считаем квадрат числа
        int outputNumber = (int)Math.Pow(inputNumber, 2);

        // и выводим его
        Console.WriteLine(outputNumber);
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
