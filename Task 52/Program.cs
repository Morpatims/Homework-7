using System;
using static System.Console;

Clear();

Write("Enter the number of rows of the array: ");
int rows = Convert.ToInt32(ReadLine());

Write("Enter the number of columns of the array: ");
int columns = Convert.ToInt32(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
double[] AverageValueColumns = FindMeanElements(array);
WriteLine($"The arithmetic mean of each column = {String.Join("; ", AverageValueColumns)}");

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

double[] FindMeanElements(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j] += array[i, j] / array.GetLength(0);
        }
    }
    return result;
}