// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите часло: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a!=0)
{
    if (a%2 == 0) Console.Write("{0} - Число четное", a);
    else Console.Write("{0} - Число нечетное", a);
}
else Console.Write("Это ж 0");


