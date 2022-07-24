/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49 */

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

int[,] CheckMatrix(int[,] mtrx1, int[,] mtrx2)
{
    int[,] mtrx = new int[mtrx1.GetLength(0), mtrx2.GetLength(1)];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[0, 0] = mtrx1[0, 0] * mtrx2[0, 0] + mtrx1[0, 1] * mtrx2[1, 0];
            mtrx[0, 1] = mtrx1[0, 0] * mtrx2[0, 1] + mtrx1[0, 1] * mtrx2[1, 1];
            mtrx[1, 0] = mtrx1[1, 0] * mtrx2[0, 0] + mtrx1[1, 1] * mtrx2[1, 0];
            mtrx[1, 1] = mtrx1[1, 0] * mtrx2[0, 1] + mtrx1[1, 1] * mtrx2[1, 1];
        }
        
    }
System.Console.WriteLine("произведение матриц: ");
PrintMatrix(mtrx);
System.Console.WriteLine();
    return mtrx;
    
}

int[,] matrix1 = GetMatrix(2, 2, 0, 5);
int[,] matrix2 = GetMatrix(2, 2, 0, 5);
PrintMatrix(matrix1);
System.Console.WriteLine();
PrintMatrix(matrix2);
System.Console.WriteLine();
CheckMatrix(matrix1, matrix2);