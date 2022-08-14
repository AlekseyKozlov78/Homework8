// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = new Random().Next(min, max);
        }
    }
    return newArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] GetRowSum(int[,] array, int m, int n)
{
    int[] sumArray = new int[m];

    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += array[i, j];
        }
        sumArray[i] = sum;
    }
    return sumArray;
}

void MinRowSum(int[] sumArray)
{
    int minSum = sumArray[0];
    int minIndex = 0;
    for (int i = 0; i < sumArray.Length; i++)
    {
        if (sumArray[i] < minSum) 
        {
            minSum = sumArray[i];
            minIndex = i;
        }
    }
    Console.WriteLine($"Строка с индексом {minIndex} имеет наименьшую сумму элементов, равную {minSum}");
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[] sumArray = GetRowSum(array, rows, columns);

MinRowSum(sumArray);
