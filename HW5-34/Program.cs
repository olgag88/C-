// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillMass(int[] mass)
{
    for(int i=0; i<mass.Length; i++) mass[i] = new Random().Next(100,1000);
}

void PrintMass(int[] mass)
{
    for(int i=0; i<mass.Length; i++) Console.Write($"{mass[i]} ");
    Console.WriteLine();
}

void Schetchik(int[] mass)
{
    int chek=0;
    for(int i=0; i<mass.Length; i++) 
    {
       if (mass[i]%2 ==0) chek++;
    }
    Console.Write($"Число четных чисел равно: {chek}");
}

Console.Write("Введите сколько чисел хотите вывести: " );
int a=Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
FillMass(array);
PrintMass(array);
Schetchik(array);
