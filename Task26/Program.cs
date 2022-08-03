//------------------------ Решение задачи 27 ------------------------------
// Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
//------------------------------------------------------------------------

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    try 
    {
        //Парсим число
        int inputNumber = int.Parse(inputLine);
        // Инициализируем переменные
        int multiplication = 1;
        
        // Перемножаем все числам от 1 до N
        for (int i=1 ; i<=inputNumber ; i++)
        {
            multiplication *= i;
        }

        // Выводим результат
        Console.WriteLine($"Произведение всех чисел от 1 до {inputLine} равно {multiplication.ToString()}");
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
