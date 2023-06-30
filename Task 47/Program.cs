using System;
using static System.Console;

Clear();

Write("Enter the number of rows of the array: ");
int rows = Convert.ToInt32(ReadLine());

Write("Enter the number of columns of the array: ");
int columns = Convert.ToInt32(ReadLine());

double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (maxValue - minValue + 1) + minValue;
        }
    }
    return result;
}
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]:f2} ");
        }
        WriteLine();
    }
}