﻿//------------------------ Решение задачи 16 ------------------------------
// Напишите программу, которая принимает на вход цифру, обозначающую день 
// недели, и проверяет, является ли этот день выходным.
//------------------------------------------------------------------------

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    try 
    {
        //Парсим число
        int inputNumber = int.Parse(inputLine);

        // Проверяем, что введенное число - день недели
        if (inputNumber < 1 || inputNumber > 7)
        {
            Console.WriteLine("Введенное число не день недели.");
        }
        else
        {
            // Заполняем массив данными о выходных
            int[] weekends = {6, 7};
            
            // Проверяем, входит введенное число в массив и выводим информация
            Console.WriteLine(
                (weekends .Contains(inputNumber)) ? "Введенный день недели {0} - выходной" : "Введенный день недели {0} - рабочий",
                inputNumber);
        }
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
