// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int RowElementsSum(int[,] inArray, int rowNumber)
{
    int sum = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        sum = sum + inArray[rowNumber, j];
    }
    return sum;
}
    


Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());
int[,]array = GetArray(rows,columns, 5, 15);
PrintArray(array);
Console.WriteLine();
int minRowNum = 0;
int rowSum = RowElementsSum(array,minRowNum);
for(int i =1; i<array.GetLength(0);i++)
{
    int l = RowElementsSum(array,i);
    if(rowSum>l)
    {
        rowSum = l;
        minRowNum = i;
    }
}
Console.WriteLine ($"{minRowNum+1} - строка с наименьшей суммой элементов");
