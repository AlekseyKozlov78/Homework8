// Задача 62. Заполните спирально массив 4 на 4.


int[,] GetArray(int n)
{
    int[,] newArray = new int[n, n];
    int item = 1;
    for (int j = 0; j < n; j++) // заполняем с 1 по 4 горизонтально
    {        
        int i = 0;
        newArray[i, j] = item;
        item ++;
    }
    
    for (int i = 1; i < n; i++) // заполняем с 5 по 7 вертикально
    {        
        int j = n-1;
        newArray[i, j] = item;
        item ++;
    }

    for (int j = n-2; j >=0; j--) // заполняем с 8 по 10 горизонтально 
    {        
        int i = n-1;
        newArray[i, j] = item;
        item ++;
    }

    for (int i = n-2; i >=1; i--) // заполняем с 11 по 12 вертикально
    {        
        int j = 0;
        newArray[i, j] = item;
        item ++;
    }

    for (int j = 1; j< n - 1; j++) // заполняем с 13 по 14 горизонтально 
    {        
        int i = 1;
        newArray[i, j] = item;
        item ++;
    }

    
    for (int j = n-2; j>=1; j--) // заполняем с 15 по 16 горизонтально 
    {        
        int i = n-2;
        newArray[i, j] = item;
        item ++;
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

int n = 4;
int[,] array = GetArray(n);
Console.WriteLine("Заполненный спирально массив 4 на 4");
PrintArray(array);