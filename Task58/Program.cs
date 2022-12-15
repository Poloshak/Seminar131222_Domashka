// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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


int[,] MatrixProizvedenie(int[,] arrA, int[,] arrB)
{
    int[,] arrayProizvedenie = new int[arrA.GetLength(0), arrB.GetLength(1)];

    for (int i = 0; i < arrayProizvedenie.GetLength(0); i++)
    {
        for (int j = 0; j < arrayProizvedenie.GetLength(1); j++)
        {
            int sum = 0;
            for (int n = 0; n < arrB.GetLength(1) - 1; n++)
            {
                sum = sum + arrA[i, n] * arrB[n, j];
            }
            arrayProizvedenie[i, j] = sum;
        }
    }

    return arrayProizvedenie;
}


Console.Write("Введите количество строк массива1: ");
int rows1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива1: ");
int columns1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк массива2: ");
int rows2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива2: ");
int columns2 = int.Parse(Console.ReadLine());
int[,] array1 = GetArray(rows1, columns1, 0, 5);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(rows2, columns2, 0, 5);
PrintArray(array2);
Console.WriteLine();
if (columns1==rows2)
{
int[,] array3 = MatrixProizvedenie(array1, array2);
PrintArray(array3);
}
else Console.WriteLine("Матрицы умножить нельзя"); 



