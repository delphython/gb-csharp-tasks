//------------------------ Решение задачи 39 ------------------------------
//  Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом
//------------------------------------------------------------------------

using System.Diagnostics;

// Метод bubbleSortArray, который сортирует массив методом пузырька
double[] bubbleSortArray(double[] inputArray)
{
    double temp;
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

// Метод insertSortArray, который сортирует массив методом вставки
double[] insertSortArray(double[] inputArray)
{
    double[] outputArray = new double[inputArray.Length];
    for (int i=0; i<inputArray.Length; i++)
    {
        int j = i;
        while (j>0 && outputArray[j-1] > inputArray[i])
        {
            outputArray[j] = outputArray[j-1];
            j--;
        }
        outputArray[j] = inputArray[i];
    }
    return outputArray;
}

// Метод countSortArray, который сортирует массив методом подсчета
double[] countSortArray(double[] inputArray)
{
    int inputArrayLength = inputArray.Length;
    int[] countArray = new int[inputArrayLength];
    double[] outputArray = new double[inputArrayLength];
    
    for (int i=0; i<inputArrayLength; i++) 
    {
        countArray[i]=0;
    }   
       
    for (int i=0; i<inputArrayLength; i++)
    {
        for (int j=i+1; j<inputArrayLength; j++)
        {
            if (inputArray[i] > inputArray[j]) ++countArray[i];
            else ++countArray[j];
        }     
            
    }
        
    for (int i=0; i<inputArrayLength; i++) 
    {
        outputArray[countArray[i]] = inputArray[i];
    }
    
    return outputArray;
}

try 
{
    // Входные данные
    double[] inputArray = new double[] {1, 23, 45, 5, -9};

    Stopwatch clock1 = new Stopwatch();
    Stopwatch clock2 = new Stopwatch();
    Stopwatch clock3 = new Stopwatch();
    
    // Сортируем массив метоом пузырьков
    clock1.Start();
    double[] sortedBubleArray = bubbleSortArray(inputArray);
    clock1.Stop();

    // Сортируем массив метоом вставки
    clock2.Start();
    double[] sortedInsertArray = insertSortArray(inputArray);
    clock2.Stop();

    // Сортируем массив метоом подсчета
    clock3.Start();
    double[] sortedCountArray = countSortArray(inputArray);
    clock3.Stop();

    // Разница между последним и первым элементом
    double difference = sortedBubleArray[sortedBubleArray.Length-1] - sortedBubleArray[1];

    // Формируем строки для вывода массивов
    string lineOutputOne = string.Join(",", sortedBubleArray);
    string lineOutputTwo = string.Join(",", sortedInsertArray);
    string lineOutputThree = string.Join(",", sortedCountArray);

    // Выводим строку
    Console.WriteLine(@$"[{lineOutputOne}] - методом пузырьков
    [{lineOutputTwo}] - методом вставки
    [{lineOutputThree}] - методом подсчета
    разница между последним и первым элементом: {difference}");

    Console.WriteLine($"Время выполнения сортировки массив методом пузырьков: {clock1.Elapsed}");
    Console.WriteLine($"Время выполнения сортировки массив методом вставки: {clock2.Elapsed}");
    Console.WriteLine($"Время выполнения сортировки массив методом подсчета: {clock3.Elapsed}");
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
