//------------------------ Решение задачи 44 ------------------------------
// Напишите программу, которая будет создавать копию заданного одномерного
//  массива с помощью поэлементного копирования
//------------------------------------------------------------------------

// Метод copyArray, который копирует поэлементно одномерный массив
int[] copyArray(int[] inputArray)
{
    int[] outputArray = new int[inputArray.Length];

    for(int i = 0; i < inputArray.Length; i++)
        outputArray[i] = inputArray[i];
    
    return outputArray;
}

try 
{
    // Входные данные
    int[] perfectArrayInput = new int[] {1,-2,3,-4,5};
    
    // Копируем массив 
    int[] perfectArrayOutput = copyArray(perfectArrayInput);

    // Формируем строки для вывода массивов
    string lineOutputOne = string.Join(",", perfectArrayInput);
    string lineOutputTwo = string.Join(",", perfectArrayOutput);

    // Выводим информацию
    Console.Write(
        @$"Cкопированный массив с [{lineOutputOne}]
        на [{lineOutputTwo}]"
    );
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
