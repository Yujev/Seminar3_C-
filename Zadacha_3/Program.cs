// Напишите программу, которая на вход принимает координаты двух точек и находит расстояние между ними в 2Д пространстве

Console.WriteLine("Координаты для Х1");
int x1 = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());

Console.WriteLine("Координаты для Y1");
int y1 = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());

Console.WriteLine("Координаты для Х2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Координаты для Y2");
int y2 = int.Parse(Console.ReadLine());

double A = Math.Sqrt(Math.Pow((x1-x2),2) +Math.Pow((y1-y2),2));
Console.WriteLine($"Расстояние между точками: {A:f2}");

/*Второе решение
double result = Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2));
Console.WriteLine($"Расстояние между точками: -> {result:f2}");*/