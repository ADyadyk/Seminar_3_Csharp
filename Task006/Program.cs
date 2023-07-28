/*
Задача 23:
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

//Метод, который запрашивает число
int PutNumber()
{
    Console.Write("Введите число N: ");
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

//Метод, который выводит таблицу кубов от 1 до N
void GiveCubeTable(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.Write($"{Math.Pow(count, 3)}  ");
        count = count+1;
    }
}

//Программа
int N = PutNumber();
GiveCubeTable(N);


