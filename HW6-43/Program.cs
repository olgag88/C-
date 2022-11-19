// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void FillMass(double[] mass)
{
    for (int i = 0; i < mass.Length; i++) 
    {
        mass[i] = Convert.ToDouble(Console.ReadLine());
    }
}

double x, y;

double[] Line1 = new double[2];
double[] Line2 = new double[2];

Console.WriteLine("Введите k1 и b1: ");
FillMass(Line1);
Console.WriteLine("Введите k2 и b2: ");
FillMass(Line2);

// k2*x+b2 = k1*x+ b1;
// (k2-k1)*x= b1 - b2;
// x = (b1 - b2)/(k2 - k1)
// y = k1*x+b1;

if(Line1[0] == Line2[0]) 
{
    Console.WriteLine("Линии параллельны, общих точек нет");
}
else
{
    x=(Line1[1] - Line2[1])/(Line2[0]-Line1[0]);
    y=Line1[0]*x + Line1[1];
    Console.Write($"координаты общих точек: x={x} и y={y}");
}
