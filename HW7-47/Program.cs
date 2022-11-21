// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк массива (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива (n): ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] mass = new double[m, n];
Random rand = new Random();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = rand.NextDouble() * 100;
        Console.Write("{0,6:F1}", mass[i, j]);
    }
    Console.WriteLine();
}
