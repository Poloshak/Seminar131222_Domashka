// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.



void OrganizeArray(int[,]arr)
{
    for(int n = 0; n<arr.GetLength(0);n++)
    {
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = i+1; j < arr.GetLength(1); j++)
        {
            if(arr[n,i]>arr[n,j])
            {
                int k=arr[n,i];
                arr[n,i]=arr[n,j];
                arr[n,j]=k;
            }
        }
    }
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());
int[,]array = GetArray(rows,columns, 5, 15);
PrintArray(array);
Console.WriteLine();
OrganizeArray(array);
PrintArray(array);

