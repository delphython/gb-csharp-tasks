//------------------------ Решение задачи 11 ------------------------------
// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число некратно
// первому, то программа выводит о статок от деления.
//------------------------------------------------------------------------

// Считываем данные с консоли
string? inputFirstLine = Console.ReadLine();
string? inputSecondLine = Console.ReadLine();

if (inputFirstLine != null && inputSecondLine != null)
{
    try 
    {
        //Парсим первое число
        int inputFirstNumber = int.Parse(inputFirstLine);
        //Парсим второе число
        int inputSecondNumber = int.Parse(inputSecondLine);
        
        // Проверяем, есть ли остаток от деления и выводим данные в консоль
        Console.WriteLine("Число {0}" + (
            (inputSecondNumber % inputFirstNumber == 0) ? " кратно {1}" : " не кратно {1} и остаток от деления = {2}"
        ), inputSecondNumber, inputFirstNumber, inputSecondNumber % inputFirstNumber);

    }
    catch
    {
        // Выводим сообщение об ошибке
        Console.WriteLine("error!");
    }
}