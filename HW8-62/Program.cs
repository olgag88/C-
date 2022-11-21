// Напишите программу, которая заполнит спирально массив 4 на 4
int[,] Spiral(int[,] matrix)
{
    int ind = 0;
    int m = 0;
    int n;
    int i, j;
    if (matrix.GetLength(0) > matrix.GetLength(1)) n = matrix.GetLength(1);
    else n = matrix.GetLength(0);
    while (m < n / 2)
    {
        for (i = m; i < matrix.GetLength(0) - m; i++)
        {
            ind++;
            matrix[i, m] = ind;
        }

        for (j = m + 1; j < matrix.GetLength(1) - (m + 1); j++)
        {
            ind++;
            matrix[matrix.GetLength(0) - (m + 1), j] = ind;
        }
        for (i = m; i < matrix.GetLength(0) - m; i++)
        {
            ind++;
            matrix[matrix.GetLength(0) - 1 - i, matrix.GetLength(1) - (m + 1)] = ind;
        }
        for (j = m + 1; j < matrix.GetLength(1) - (m + 1); j++)
        {
            ind++;
            matrix[m, matrix.GetLength(1) - 1 - j] = ind;
        }
        m++;
    }
    if (n % 2 != 0)
    {
        if (matrix.GetLength(0) < matrix.GetLength(1))
        {
            for (j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[matrix.GetLength(0) - ((matrix.GetLength(0) / 2) + 1), j] == 0)
                {
                    ind++;
                    matrix[matrix.GetLength(0) - ((matrix.GetLength(0) / 2) + 1), j] = ind;
                }
            }
        }
        if (matrix.GetLength(0) > matrix.GetLength(1))
        {
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, matrix.GetLength(1) - ((matrix.GetLength(1) / 2) + 1)] == 0)
                {
                    ind++;
                    matrix[i, matrix.GetLength(1) - ((matrix.GetLength(1) / 2) + 1)] = ind;
                }
            }
        }
        if (matrix.GetLength(0) == matrix.GetLength(1))
        {
            ind++;
            matrix[matrix.GetLength(0) - ((matrix.GetLength(0) / 2) + 1), matrix.GetLength(1) - ((matrix.GetLength(1) / 2) + 1)] = ind;
        }
    }
    return matrix;
}

// Метод вывода матрицы

void PrintMatrix(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write("{0,6:F1} ", mat[i, j]);
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите число строк (n): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов (m): ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] mass = new int[n, m];

PrintMatrix(Spiral(mass));

