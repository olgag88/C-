// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

void FillMass(double[] mass)
{
    Console.WriteLine("Введите числа");
    for (int i = 0; i < mass.Length; i++) mass[i] = Convert.ToDouble(Console.ReadLine());
}

void PrintMass(double[] mass)
{
    Console.Write("Введенные числа: ");
    for (int i = 0; i < mass.Length; i++) Console.Write($"{mass[i]} ");
    Console.WriteLine();
}

double Max(double[] mass)
{
    double max = mass[0];
    for (int i = 1; i < mass.Length; i++)
    {
        if (max < mass[i]) max = mass[i];
    }
    Console.WriteLine($"Максимальное число: {max}");
    return max;
}

double Min(double[] mass)
{
    double min = mass[0];
    for (int i = 1; i < mass.Length; i++)
    {
        if (min > mass[i]) min = mass[i];
    }
    Console.WriteLine($"Минимальное число: {min}");
    return min;
}

Console.Write("Введите сколько чисел хотите вывести: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] array = new double[a];
FillMass(array);
PrintMass(array);
Console.WriteLine("Разница между максимальным и минимальным равна: {0}", Max(array) - Min(array));
