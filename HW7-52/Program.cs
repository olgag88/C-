// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void RandomMatrix(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintMatrix(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write("{0,6:F1}", mass[i, j]);
        }
        Console.WriteLine();
    }
}

double[] SrArifmStolb(int[,] mass)
{
    int m = 0;
    double[] massiv = new double[mass.GetLength(1)];
    double sum;
    while (m < mass.GetLength(1)) // Психолгически удобнее использовать while
    {
        sum =0;
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            sum += mass[i, m];
        }
        massiv[m] =sum/mass.GetLength(0); 
        m++;
    }
    return massiv;
}

void Vyvod(double[] mass)
{
    Console.WriteLine("Среднее арифметическое столбцов:");
    for (int j = 0; j < mass.Length; j++)
    {
        Console.Write("{0,6:F2} ", mass[j]);
    }
}

Console.WriteLine("Введите количество строк матрицы (n): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы (n): ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

RandomMatrix(matrix);
PrintMatrix(matrix);
Vyvod(SrArifmStolb(matrix));
