// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.

Console.Write("Введите число, которое хотите возвести в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число равное степени: ");
int b = Convert.ToInt32(Console.ReadLine());
int c=1;
for (int i = 0; i < b; i++) c*=a;
Console.Write("Число {0} в степени {1} равно {2}", a, b, c);
