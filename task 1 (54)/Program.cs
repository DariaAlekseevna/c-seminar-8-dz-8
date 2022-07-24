/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8 */

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] mtrx = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = rnd.Next(min, max + 1);
        }
    }
    return mtrx;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0) System.Console.Write(" | ");
            System.Console.Write($"{mtrx[i, j],2} | ");
        }
        System.Console.WriteLine();
    }
}


int[,] CheckMatrix(int[,] mtrx)
{
    int temp = 0;
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        int min = mtrx[i, 0];
        if (min == mtrx[i, 0])
        {
            for (int j = 0; j < mtrx.GetLength(1); j++)
            {
                if (min > mtrx[i, j])
                {
                    temp = min;
                    min = mtrx[i, j];
                    mtrx[i, j] = temp;
                    mtrx[i, 0] = min;
                }
            }
        }
        min = mtrx[i, 1];
        if (min == mtrx[i, 1])
        {
            for (int j = 1; j < mtrx.GetLength(1); j++)
            {
                if (min > mtrx[i, j])
                {
                    temp = min;
                    min = mtrx[i, j];
                    mtrx[i, j] = temp;
                    mtrx[i, 1] = min;
                }
            }
        }
        min = mtrx[i, 2];
        if (min == mtrx[i, 2])
        {
            for (int j = 2; j < mtrx.GetLength(1); j++)
            {
                if (min > mtrx[i, j])
                {
                    temp = min;
                    min = mtrx[i, j];
                    mtrx[i, j] = temp;
                    mtrx[i, 2] = min;
                }
            }
        }
    }
    return mtrx;
}

int[,] result = GetMatrix(4, 4, 1, 10);
PrintMatrix(result);
CheckMatrix(result);
System.Console.WriteLine();
PrintMatrix(result);