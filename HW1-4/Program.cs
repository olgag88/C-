// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int[] mass = new int[3];
int n = mass.Length;
int i = 0;
int max = mass[0];
Console.WriteLine("Введите числа:");
while (i<n)
{
    mass[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
for (i=1; i<n;i++)
{
    if(mass[i]>max) max = mass[i];
}
Console.WriteLine("Максимальное число: {0}", max);
