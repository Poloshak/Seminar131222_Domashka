// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] GetArray(int m, int n, int k, int minValue, int maxValue)
{
    int[] addarr = new int[m * n * k];
    int q = 0;
    for (int i = 0; i < addarr.Length; i++)
    {
        addarr[i] = new Random().Next(minValue, maxValue + 1);
        q = addarr[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (addarr[i] == addarr[j])
                {
                    addarr[i] = new Random().Next(minValue, maxValue + 1);
                    j = 0;
                    q = addarr[i];
                }
                q = addarr[i];
            }
        }
    }
    int[,,] result = new int[m, n, k];
    int d = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int f = 0; f < result.GetLength(2); f++)
            {
                result[i, j, f] = addarr[d];
                d++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int f = 0; f < inArray.GetLength(2); f++)
            {
                Console.Write($"{inArray[i, j, f]}[{i},{j},{f}]\t ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов1 массива: ");
int columns1 = int.Parse(Console.ReadLine());
int[,,] array = GetArray(rows, columns, columns1, 10, 100);
PrintArray(array);


