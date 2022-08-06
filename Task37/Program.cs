//------------------------ Решение задачи 37 ------------------------------
//  Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// * Отсортировать массив методом пузырька
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

// Метод bubbleSortArray, который сортирует массив методом пузырька
int[] bubbleSortArray(int[] inputArray)
{
    int temp;
    for (int i=0; i<inputArray.Length-1; i++)
    {
        for (int j=0; j<inputArray.Length-i-1; j++)
        {
            if (inputArray[j+1] < inputArray[j])
            {
                temp = inputArray[j+1];
                inputArray[j+1] = inputArray[j];
                inputArray[j] = temp;
            }
        }
    }
    return inputArray;
}

try 
{
    // Входные данные
    int elementsAmount = 20;
    int numberFrom = 100;
    int numberTo = 999;
    
    // Заполняем массив
    int[] randNumberArray = fillRandArray(elementsAmount, numberFrom, numberTo); 
    
    // Сортируем массив
    int[] sortedArray = bubbleSortArray(randNumberArray);

    // Количество четных элементов массива
    IEnumerable<int> arrayEvenNumber = sortedArray.Where(c => c % 2 == 0);
    int evenSum = arrayEvenNumber.Count();

    // Формируем строку для вывода массива
    string lineOutputOne = string.Join(",", sortedArray);

    // Выводим строку
    Console.WriteLine(@$"В массиве [{lineOutputOne}] 
    количество четных элементов массива = {evenSum}");
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
