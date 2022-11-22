// Задайте значения M и N. Напишите программу, которая определяет количество натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите натуральное число от которого считать:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число до которого считать:");
int N = Convert.ToInt32(Console.ReadLine());

int SumNaturElem (int m, int n, int sum)
{
    if (m > n) 
    { 
        return sum;
    }
    sum = sum + (m++);
    return SumNaturElem(m, n, sum);
}

Console.WriteLine($"Сумма от натуральных чисел от {M} до {N} равна: {SumNaturElem(M, N, 0)}");
