//------------------------ Решение задачи 62 ------------------------------
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента.
//------------------------------------------------------------------------

// Метод FillArray, который заполняет трехмерный массив
int[,,] FillArray(int m, int n, int k)
{
    int[,,] outputArray = new int[m, n, k];
    Random rand = new Random();
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int r = 0; r < k; r++)
            {
                outputArray[i, j, r] = rand.Next(10, 100);
            }
        }
    }
    
    return outputArray;
}

// Метод PrintThreeDimArray, который переводит трехмерный массив в строку для вывода в консоль
string PrintThreeDimArray(int [,,] inputArray)
{
    string outputString = "";
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int r = 0; r < inputArray.GetLength(2); r++)
            {
                outputString += $"{inputArray[i, j, r]}({i}, {j}, {r})\t";
            }
            outputString +="\n";
        }
    }
    
    return outputString;
}

// Метод GetConsoleData для считывания данных с консоли
void GetConsoleData(out int m, out int n, out int k)
{
    m = 0;
    n = 0;
    k = 0;
    
    Console.WriteLine("Введите размер ьрехмерного массива m на n на k");
    Console.Write("m = ");
    string? inputFirstLine = Console.ReadLine();
    Console.Write("n = ");
    string? inputSecondLine = Console.ReadLine();
    Console.Write("k = ");
    string? inputThirdLine = Console.ReadLine();

    if (inputFirstLine != null && inputSecondLine != null && inputThirdLine != null)
    {
        m = int.Parse(inputFirstLine);
        n = int.Parse(inputSecondLine);
        k = int.Parse(inputThirdLine);
    }
}

try 
{
    //Считываем данные с консоли
    int m;
    int n;
    int k;
    GetConsoleData(out m, out n, out k);
    
    // Заполняем массив
    int[,,] filledArray = FillArray(m, n, k);

    // Перемножаем массивы
    // int[,] outputArray = ChangeArray(filledArrayOne, filledArrayTwo);

    // Выводим информацию в консоль
    Console.WriteLine($"Массив:\n{PrintThreeDimArray(filledArray)}");

}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
