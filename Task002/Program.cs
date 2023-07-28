/*
Задача 2: Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.Write("Введите координату x точки A: ");
int xa = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату y точки A: ");
int ya = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату x точки B: ");
int xb = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату y точки B: ");
int yb = int.Parse(Console.ReadLine()!);


double s = Math.Sqrt(Math.Pow((xb-xa), 2)+Math.Pow((yb-ya), 2));
Console.WriteLine($"Расстояние между A и B равно {s:f2}");