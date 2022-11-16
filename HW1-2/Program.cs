// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a, b;
Console.Write("Введите a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
b = Convert.ToInt32(Console.ReadLine());
if (a==b) Console.WriteLine("Числа a и b равны");
else
{
    Console.WriteLine("Максимальное число: ");
    if (a>b) Console.WriteLine("a = {0}", a);
    else  Console.WriteLine("b = {0}", b);
}
