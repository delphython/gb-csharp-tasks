//------------------------ Решение задачи 35 ------------------------------
// Задайте одномерный массив из 123 случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99]
//------------------------------------------------------------------------

// Метод fillRandArray, который возвращает массив из elementsAmount элементов
// заполненный случайными числами от numberFrom до numberTo
int[] fillRandArray(int elementsAmount, int numberFrom, int numberTo)
{
    
    // Инициализируем переменные
    int[] randIntArray = new int[elementsAmount];
    Random rand = new Random();
    
    // Заполняем массив числами
    for (int i=0; i<elementsAmount; i++)
    {
        randIntArray[i]=rand.Next(numberFrom,numberTo+1);
    }

    return randIntArray;
}

try 
{
    // Входные данные
    int elementsAmount = 123;
    int numberFrom = 1;
    int numberTo = 100;
    int segmentFrom = 10;
    int segmentTo = 99;
    
    // Заполняем массив
    int[] randNumberArray = fillRandArray(elementsAmount, numberFrom, numberTo); 

    // Массив, значения которых лежат в отрезке
    IEnumerable<int> segmentArray = randNumberArray.Where(c => c >= segmentFrom && c <= segmentTo);
      
    // Формируемс строку для вывода массива
    string lineOutput = string.Join(",", randNumberArray);

    // Выводим строку
    Console.WriteLine(@$"В массиве [{lineOutput}] количество элементов, 
    лежащих в отрезке [{segmentFrom}, {segmentTo}] = {segmentArray.Count()}");
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
