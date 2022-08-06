﻿//------------------------ Решение задачи 34 ------------------------------
// Задайте массив. Напишите программу, которая определяет, присутствует ли 
// заданное число в массиве.
//------------------------------------------------------------------------

try 
{
    // Входные данные
    int[] perfectArray = new int[] {1,-2,3,-4,5,-6};
    int desiredNumber = 6;
    
    // Определяем, есть ли число в массиве
    bool isInArray = perfectArray.Contains(desiredNumber);
    
    // Формируемс строку для вывода массива
    string lineOutput = string.Join(",", perfectArray);

    // Выводим информацию
    Console.WriteLine("В массиве [{0}] число {1}" + ((isInArray) ? " присутствует." : " отсутствует."), lineOutput, desiredNumber);
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
