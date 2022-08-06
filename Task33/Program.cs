//------------------------ Решение задачи 33 ------------------------------
// Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
//------------------------------------------------------------------------

try 
{
    // Входные данные
    int arrayLength = 5;
    int[] firstArray = new int[] {10,-20,30,-40,50};
    int[] secondArray = new int[arrayLength];
    
    // Замена знака на противоположный
    for (int i=0; i<arrayLength; i++)
    {
        secondArray[i]=-firstArray[i];
    }
    
    // Формируемс строки для вывода массивов
    string lineOutputOne = string.Join(",", firstArray);
    string lineOutputTwo = string.Join(",", secondArray);

    // Выводим информацию
    Console.WriteLine($"Был массиве [{lineOutputOne}], а стал [{lineOutputTwo}]");
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
