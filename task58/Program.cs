// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] Multiplication(int[,] matrix1, int[,] matrix2, int m1, int n1, int m2, int n2)
{
    int[,] result = new int[m1, n2];
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            int sum = 0;
            for (int k = 0; k < n1; k++)
            {
                sum += matrix1[i,k] * matrix2[k,j];
            }
            result[i,j] = sum;
        }  
    }
    return result;
}

Console.Write("Введите кол-во строк в первой матрице: m1 = ");
int m1 = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов в первой матрице: n1 = ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Кол-во строк во второй матрице m2 = n1 = {n1}");
int m2 = n1;
Console.Write("Введите кол-во столбцов во второй матрице: n2 = ");
int n2 = int.Parse(Console.ReadLine());

int[,] matrix1 = GetArray(m1, n1, 0, 10);
Console.WriteLine("Первая матрица:");
PrintArray(matrix1);

int[,] matrix2 = GetArray(m2, n2, 0, 10);
Console.WriteLine("Вторая матрица:");
PrintArray(matrix2);

Console.WriteLine("Произведение двух матриц:");
PrintArray(Multiplication(matrix1, matrix2, m1, n1, m2, n2));