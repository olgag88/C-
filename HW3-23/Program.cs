// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число для нахождения ряда кубов чисел до него начиная с 1: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[a];
int i;
for (i=0; i<a; i++)
{
    mass[i] = (i+1)*(i+1)*(i+1);
    Console.WriteLine("{0} {1}", i+1, mass[i]);
}
