//------------------------ Решение задачи 58 ------------------------------
// Задайте двумерный массив. Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен наименьший элемент массива
//------------------------------------------------------------------------

// Метод FillArray, который заполняет двумерный массив
int[,] FillArray(int m, int n)
{
    int[,] outputArray = new int[m, n];
    Random rand = new Random();
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            outputArray[i, j] = rand.Next(0, 100);
        }
    }
    
    return outputArray;
}

// Метод GetMinTwoDimArray находит наименьший элемент в двумерной
// матрице. Игнориует совпадение минимальных элементов
int[] GetMinTwoDimArray(int[,] inputArray)
{
    int rowLenght = inputArray.GetLength(0);
    int colLenght = inputArray.GetLength(1);
    
    int minElement = inputArray[0, 0];
    int[] outputArray = new int[2];

    for (int i = 0; i < rowLenght; i++)
    {
        for (int j = 0; j < colLenght; j++)
        {
            if (inputArray[i, j] < minElement) 
            {
                minElement = inputArray[i, j];
                outputArray[0] = i;
                outputArray[1] = j;  
            }
        }
    }

    return outputArray;
}

// Метод ChangeArray, который ищет минимальное значение массива
// и удаляет строку и столбец, где расположен этот элемент
int[,] ChangeArray(int[,] inputArray)
{
    int rowLenght = inputArray.GetLength(0);
    int colLenght = inputArray.GetLength(1);

    List<int> tmpList = new List<int>();
    int[,] outputArray = new int[rowLenght-1, colLenght-1];

    int r =0;

    int[] minPosArray = GetMinTwoDimArray(inputArray);
    
    for (int i = 0; i < rowLenght; i++)
    {
        if (i!=minPosArray[0])
        {
            // Переносим строку массива в список
            tmpList = Enumerable.Range(0, colLenght).Select(j => inputArray[i, j]).ToList();
            // Удаляем элемент из списка
            tmpList.RemoveAt(minPosArray[0]);

            // Добавляем его как строку в новый массив
            for (int k = 0; k < tmpList.Count(); k++)
            {
                outputArray[r, k] = tmpList[k];
            }
            r++;
        }
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
void GetConsoleData(out int n)
{
    n = 0;
    
    Console.WriteLine("Введите размер двумерного массива n на n");
    Console.Write("n = ");
    string? inputFirstLine = Console.ReadLine();

    if (inputFirstLine != null)
    {
        n = int.Parse(inputFirstLine);
    }
}

try 
{
    //Считываем данные с консоли
    int n;
    GetConsoleData(out n);
    
    // Заполняем массив
    int[,] filledArray = FillArray(n, n);

    // Меняем массив согласно условиям задачи
    int[,] outputArray = ChangeArray(filledArray);

    // Выводим информацию в консоль

    Console.WriteLine($"Массив был:\n{PrintTwoDimArray(filledArray)}\nМассив стал:\n{PrintTwoDimArray(outputArray)}");
    Console.WriteLine($"Из массива удалили строку с индексом {GetMinTwoDimArray(filledArray)[0]} и столбец с индексом {GetMinTwoDimArray(filledArray)[1]}");
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
