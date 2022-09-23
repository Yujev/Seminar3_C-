/* Формула                   
double                      Это после запятой
Console.WriteLine("d = {d:f3");*/

/*Задача 2. Напиши программу, которая на вход принимает координаты точки, но при этом Х не равно 0 и У не равно 0,
 и выдаёт номер четверти на плоскости которой находится.*/

Console.WriteLine("Введи координаты X: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введи координаты Y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Это Первая четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Это Вторая четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Это Третья четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Это Четвертая четверть");
}
else if (x == 0 && y == 0)
{
    Console.WriteLine("Вы в начале координат");
}
else
{
    Console.WriteLine("Это вообще не четверть!");
}
