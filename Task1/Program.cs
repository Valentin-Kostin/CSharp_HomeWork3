/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

void Palindrom(int num)
{    
    if (num / 10000 == num % 10 & (num / 1000) % 10 == (num % 100) / 10) Console.Write(num + " -> да");
    else Console.Write(num + " -> нет");
}

int GetNum(string textGet)
{
    Console.WriteLine(textGet);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int num = GetNum("Введите пятизначное число");

Palindrom(num);