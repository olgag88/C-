// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях

void FillMass(int[] mass)
{
    for(int i=0; i<mass.Length; i++) mass[i] = new Random().Next(1,1000);
}

void PrintMass(int[] mass)
{
    for(int i=0; i<mass.Length; i++) Console.Write($"{mass[i]} ");
    Console.WriteLine();
}

void SumNeChet (int[] mass)
{
    double SNC=0;
     for(int i=0; i<mass.Length; i++)
     {
        if(i%2==0) SNC+=mass[i];
     }
     Console.Write($"Сумма нечетных чисел равна: {SNC}");
}

Console.Write("Введите сколько чисел хотите вывести: " );
int a=Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
FillMass(array);
PrintMass(array);
SumNeChet (array);
