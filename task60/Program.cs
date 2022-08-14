// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetArray(int m, int n, int z, int min, int max)
{
    int[,,] newArray = new int[m, n, z];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < z; k++)
            {
                newArray[i, j, k] = new Random().Next(min, max);
            }
        }
    }
    return newArray;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        
    }
}

Console.WriteLine("Введите размеры трехмерного массива ");
Console.Write("Введите размер первого измерения: m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите размер второго измерения: n = ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите размер третьего измерения: z = ");
int z = int.Parse(Console.ReadLine());

int[,,] array = GetArray(m, n, z, 10, 100);
Console.WriteLine("Трехмерный массив с указанием индексов элементов:");
PrintArray(array);
