/* Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 */

int[,] GetMatrix(int min, int max)
{
    int[,] matrix = new int[4, 4];


    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (i == 0 && j < 4)
            {
                matrix[i, j] = min;
                min++;
                
            }
            if (i > 0 && j == 3)
            {
                matrix[i, j] = min;
                min++;
            }
 
        }

    }
    return matrix;
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

int[,] result = GetMatrix(1, 16);
PrintMatrix(result);
