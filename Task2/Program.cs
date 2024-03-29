﻿//------------------------ Решение задачи 2 ------------------------------
// Напишите программу, которая будет выдавать название дня недели по 
// заданному номеру.
//------------------------------------------------------------------------

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    try 
    {
        //Парсим число
        int inputNumber = int.Parse(inputLine);

        // Заполняем массив днями недели
        string[] dayOfWeek = {
            "понедельник",
            "вторник",
            "среда",
            "четверг",
            "пятница",
            "суббота",
            "воскресенье"
        };

        // Выводим день недели из массива по индексу
        Console.WriteLine(
            "Номеру {0} соотвествует день недели: {1}.",
            inputNumber,
            dayOfWeek[inputNumber-1]
        );
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
