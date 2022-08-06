//------------------------ Решение задачи 36 ------------------------------
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый
//  и последний элемент, второй и предпоследний и т.д. Результат запишите в 
//  новом массиве.
//------------------------------------------------------------------------

try 
{
    // Входные данные
    int[] inputArray = new int[] {1,2,3,4,5};
    int outputArrayLength;
    
    if (inputArray.Length%2 == 0) outputArrayLength = inputArray.Length/2;
    else outputArrayLength = inputArray.Length/2+1; 
    
    int[] outputArray = new int[outputArrayLength];
    int r = 0;
    int n = inputArray.Length-1;

    // Умножение пар чисел
    for (int i=0; i<outputArrayLength; i++)
    {
        if ((n-r) >= 0)
        {
            if (r==n) outputArray[i]=inputArray[r];
            else outputArray[i]=inputArray[r]*inputArray[n];
            r++;
            n--;
        }
    }
    
    // Формируемс строку для вывода массива
    string lineOutputOne = string.Join(",", inputArray);
    string lineOutputTwo = string.Join(",", outputArray);

    // Выводим информацию
    Console.WriteLine($"Был массив [{lineOutputOne}], а стал [{lineOutputTwo}]");
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
