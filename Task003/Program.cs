/*
Задача 3: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
*/

Console.Write("Введите N: ");
int number = int.Parse(Console.ReadLine()!);

int count = 1;

Console.WriteLine($"Таблица квадратов числа {number}");

while (count <= number)
{
    Console.Write($"{Math.Pow(count, 2)}  ");
    count = count+1;
}