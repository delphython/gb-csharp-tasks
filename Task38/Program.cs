//------------------------ Решение задачи 38 ------------------------------
//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// * Найдите все пары в массиве и выведите пользователю
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
    int elementsAmount = 20;
    int numberFrom = -99;
    int numberTo = 99;
    
    // Заполняем массив
    int[] randNumberArray = fillRandArray(elementsAmount, numberFrom, numberTo); 

    // Сумма элементов массива на нечетных позициях
    IEnumerable<int> arrayOddPosition = randNumberArray.Where((item, index) => index % 2 != 0);
    int oddSum = arrayOddPosition.Sum();

    // Одинаковые элементы массива
    int [] arraySimilar = randNumberArray.Where(s => randNumberArray.Count(с => с == s) > 1).Distinct().ToArray();

    // Формируем строки для вывода массивов
    string lineOutputOne = string.Join(",", randNumberArray);
    string lineOutputTwo = string.Join(",", arraySimilar);

    // Выводим строку
    Console.WriteLine(@$"В массиве [{lineOutputOne}] 
    сумма элементов массива на нечетных позициях = {oddSum},
    одинаковые элементы в массиве: {lineOutputTwo}");
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
