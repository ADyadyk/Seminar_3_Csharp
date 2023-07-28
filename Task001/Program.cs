/*
Задача 1: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/



Console.Write("Введите номер координатной четверти: ");
int number = int.Parse(Console.ReadLine()!);

switch (number)
{
    case 1:
        Console.WriteLine("х>0 and y>0");
        break;
    case 2:
        Console.WriteLine("х<0 and y>0");
        break;
    case 3:
        Console.WriteLine("х<0 and y<0");
        break;
    case 4:
        Console.WriteLine("х>0 and y<0");
        break;
    default:
        Console.WriteLine("Такой четверти не существует");
        break;
}