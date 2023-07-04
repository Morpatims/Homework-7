using System;
using static System.Console;

Clear();

Write("Enter the number of rows of the array: ");
int rows = Convert.ToInt32(ReadLine()!);

Write("Enter the number of columns of the array: ");
int columns = Convert.ToInt32(ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();

FindAverageMean(array);

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
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

void FindAverageMean(int[,] inArray)
{
    Write("The arithmetic mean of each column:");
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            summ += inArray[j, i];
        }
        Write($" {summ / inArray.GetLength(0):f1}");
    }
}