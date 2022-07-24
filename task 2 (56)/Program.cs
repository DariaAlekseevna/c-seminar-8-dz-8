/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        if (position == 0 && (count - 1) == 0)
        {
            Console.WriteLine("[" + array[position] + "]");
        }
        else if (position == 0)
        {
            Console.Write("[" + array[position] + ", ");
        }
        else if (position == (count - 1))
        {
            Console.WriteLine(array[position] + "]");
        }
        else
        {
            Console.Write(array[position] + ", ");
        }
        position++;
    }
}

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

    int[] arr = new int[4];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            arr[i] += mtrx[i, j];
        }

    }
    PrintArray(arr);
   
    int n = 0;
    int maxn = 0;
    int max = arr[n];
    while (n < arr.Length)
    {
        if (max < arr[n])
        {
            max = arr[n];
            maxn = n;
        }
        n++;

    }
    System.Console.WriteLine("номер строки с наименьшей суммой элементов: " + maxn);

    return mtrx;
}

int[,] result = GetMatrix(4, 4, 1, 10);
PrintMatrix(result);
System.Console.WriteLine();
CheckMatrix(result);
System.Console.WriteLine();

  
