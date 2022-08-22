//------------------------ Решение задачи 63 ------------------------------
// Задайте двумерный массив. Напишите программу, которая заменяет строки на
// столбцы. В случае, если это не возможно, программа должна вывести
// сообщение для пользователя
//------------------------------------------------------------------------

// Метод FillArray, который заполняет двумерный массив по спирали
int[,] FillArray(int m)
{
    int[,] outputArray = new int[m, m];
    
    int value = 1;
    int i = 0, j = 0;

    while (m != 0)
    {
        int k = 0; 
        
        do {outputArray[i, j++] = value++;} 
            while (++k < m - 1);
        for (k = 0; k < m - 1; k++) 
            outputArray[i++, j] = value++;
        for (k = 0; k < m - 1; k++) 
            outputArray[i, j--] = value++;
        for (k = 0; k < m - 1; k++) 
            outputArray[i--, j] = value++;

        ++i;
        ++j;
        m = m < 2 ? 0 : m - 2;
    }
    
    return outputArray;
}

// Метод PrintTwoDimArray, который переводит двумерный массив в строку для вывода в консоль
string PrintTwoDimArray(int [,] inputArray)
{
    string outputString = "";
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            outputString += $"{inputArray[i, j]}\t";
        }
        outputString +="\n";
    }
    
    return outputString;
}

// Метод GetConsoleData для считывания данных с консоли
void GetConsoleData(out int m)
{
    m = 0;
    
    Console.WriteLine("Введите размер двумерного массива m на m");
    Console.Write("m = ");
    string? inputFirstLine = Console.ReadLine();

    if (inputFirstLine != null)
    {
        m = int.Parse(inputFirstLine);
    }
}

try 
{
    //Считываем данные с консоли
    int m;
    GetConsoleData(out m);
    
    // Заполняем массив по спирали
    int[,] filledArray = FillArray(m);

    // Выводим информацию в консоль
    Console.WriteLine($"Массив получился:\n{PrintTwoDimArray(filledArray)}");

}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
