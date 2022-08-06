//------------------------ Решение задачи 32 ------------------------------
// Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных
// элементов массива.
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
    int elementsAmount = 12;
    int numberFrom = -9;
    int numberTo = 9;
    
    // Заполняем массив
    int[] randNumberArray = fillRandArray(elementsAmount, numberFrom, numberTo); 

    // Сумма положительных элементов массива
    IEnumerable<int> greaterThanZero = randNumberArray.Where(c => c > 0);
    int greaterSum = greaterThanZero.Sum();

    // Сумма отрицательных элементов массива
    IEnumerable<int> lessThanZero = randNumberArray.Where(c => c < 0);
    int lessSum = lessThanZero.Sum();
    
    // Формируемс строку для вывода массива
    string lineOutput = string.Join(",", randNumberArray);

    // Выводим строку
    Console.WriteLine(@$"В массиве [{lineOutput}] 
    сумма положительных элементов = {greaterSum}, 
    сумма отрицательных элементов = {lessSum}");
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
