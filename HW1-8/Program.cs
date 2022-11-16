// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число, до которого нужно вывести четные числа от 1: ");
int n = Convert.ToInt32(Console.ReadLine());
int k = n/2;
Console.WriteLine("Число четных чисел равно {0}", k);
int[] mass = new int[k];
int i;
Console.WriteLine("Четные числа до введенного числа:");
for (i=0; i<k; i++)
{
    mass[i] = 2*(i+1);
    Console.Write("{0} ",mass[i]);
}
