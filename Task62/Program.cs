//Задача 62: Заполните спирально массив 4 на 4.

int[,] GetArray(int[,] arr)
{
    int sum = 1;

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int i = 0;
        arr[i, j] = sum;
        sum++;
    }
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        arr[i, arr.GetLength(1) - 1] = sum;
        sum++;
    }
    for (int j = arr.GetLength(1) - 2; j >= 0; j--)
    {
        int i = arr.GetLength(0) - 1;
        arr[i, j] = sum;
        sum++;
    }
    for (int i = arr.GetLength(0) - 2; i >= 1; i--)
    {
        int j = 0;
        arr[i, j] = sum;
        sum++;
    }
    for (int j = 1; j < arr.GetLength(1) - 1; j++)
    {
        int i = 1;
        arr[i, j] = sum;
        sum++;
    }
    for (int j = arr.GetLength(1) - 2; j >= 1; j--)
    {
        int i = 2;
        arr[i, j] = sum;
        sum++;
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}


int[,] array = new int[4, 4];
GetArray(array);
PrintArray(array);