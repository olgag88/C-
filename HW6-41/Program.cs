// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

double BolZero(double[] mass)
{
    int chek=0;
    for(int i = 0; i< mass.Length;i++)
    {
        if(mass[i]>0)
        {
            chek++;
        }
    }
    return chek;
}

void FillMass(double[] mass)
{
    Console.WriteLine("Введите числа:");
    for (int i = 0; i < mass.Length; i++) 
    {
        mass[i] = Convert.ToDouble(Console.ReadLine());
    }
}

Console.Write("Введите сколько чисел хотите вывести(M): ");
int M = Convert.ToInt32(Console.ReadLine());
double[] array = new double[M];
FillMass(array);
Console.Write("Количество положительных чисел равно: {0}", BolZero(array));
