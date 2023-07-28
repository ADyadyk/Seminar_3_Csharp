/*
Задача 19:
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

//Метод, который запрашивает пятизначное число
int PutNumber()
{
    Console.Write("Введите число: ");
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

//Метод, который проверяет является ли число пятизначным
bool CheckNumber(int someNumber)
{
    string strNum = String.Concat(someNumber);
    if (strNum.Length == 5) return true;
    else
    {
        Console.WriteLine($"{someNumber} не является пятизначным.");
        return false;
    }
}

//Метод, который определяет является ли число палиндромом
void CheckPalindrom(int num)
{
    string strNum = String.Concat(num);
    if (strNum[0] == strNum[4] && strNum[1] == strNum[3])
    {
        Console.WriteLine($"Число {num} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {num} не является палиндромом.");
    }
}

//Программа

int number = PutNumber();
bool OKnumber = CheckNumber(number);

while (OKnumber == false)
{
    number = PutNumber();
    OKnumber = CheckNumber(number);
}

CheckPalindrom(number);