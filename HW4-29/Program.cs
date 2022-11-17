// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

Console.Write("Введите длинну массмва N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[N];
int i;
Console.WriteLine("Введите числа:");
for (i=0; i<mass.Length;i++) mass[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введенные числа:");
for (i=0; i<mass.Length;i++) Console.Write("{0} ", mass[i]);


