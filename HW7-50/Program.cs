// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

void FillMatrix(int[,] mass)
{
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

void PrintMatrix(int[,] mass)
{
    Console.WriteLine("Введенные числа: ");
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] Preobrazovatel(int[,] mass)
{
    int k = 0;
    int[] stroka = new int[mass.GetLength(0) * mass.GetLength(1)];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            
            stroka[k] = mass[i, j];
            k++;
        }
    }
    return stroka;
}

void Vyvod(int[] mass, int n)
{
  if (n>mass.Length || n<1) Console.Write("Такого элемента нет");
  else Console.Write($"Число на позиции {n} = {mass[n-1]}");
}

Console.WriteLine("Введите количество строк матрицы (n): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы (n): ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

FillMatrix(matrix);
PrintMatrix(matrix);

Console.WriteLine("Введите номер элемента (a): ");
int a = Convert.ToInt32(Console.ReadLine());


Vyvod(Preobrazovatel(matrix), a);
