/* Напиши программу, которая по заданному номеру четверти, показывает диапазон
возможных координат этой четверти (х и у).
*/

Console.WriteLine("Введи четверть: ");
int number = int.Parse(Console.ReadLine());
switch (number)
{
    case 1:
        {
            Console.WriteLine("Диапазон возможных значений 1 четверти x > 0, y > 0");
            break;
        }

    case 2:
        {
            Console.WriteLine("Диапазон возможных значений 2 четверти x < 0, y > 0");
            break;
        }
    case 3:
        {
            Console.WriteLine("Диапазон возможных значений 3 четверти x < 0, y < 0");
            break;
        }

    case 4:
        {
            Console.WriteLine("Диапазон возможных значений 4 четверти x > 0, y < 0");
            break;
        }
    default:
        {
            Console.WriteLine("Такой четверти нет. Будь внимательней! ");
            break;
        }
}
