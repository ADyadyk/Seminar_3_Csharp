/*
Задача 21:
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

//Метод, который принимает координаты
int TakeCoord(string message)
{
    Console.Write(message);
    int coord = int.Parse(Console.ReadLine()!);
    return coord;
}

//Метод, который ищет расстояние между точками

void GiveDistance(int GDxa, int GDya, int GDza, int GDxb, int GDyb, int GDzb)
{
    double s = Math.Sqrt(
        Math.Pow((GDxb-GDxa), 2) +
        Math.Pow((GDyb-GDya), 2) +
        Math.Pow((GDzb-GDza), 2)
    );
    Console.WriteLine($"Расстояние между точками A и B равно {s:f2}");
}

//Программа

int xa = TakeCoord("Введите координату точки А. Xa = ");
int ya = TakeCoord("Введите координату точки А. Ya = ");
int za = TakeCoord("Введите координату точки А. Za = ");
int xb = TakeCoord("Введите координату точки B. Xb = ");
int yb = TakeCoord("Введите координату точки B. Yb = ");
int zb = TakeCoord("Введите координату точки B. Zb = ");

GiveDistance(xa, ya, za, xb, yb, zb);
