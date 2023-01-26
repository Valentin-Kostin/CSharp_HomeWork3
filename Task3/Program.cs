/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void Cube(int num)
{
    int count = 1;
    while (count < num)
    {
        Console.Write(Math.Pow(count, 3) + ", ");
        count++;
    }
    Console.Write(Math.Pow(num, 3));
}

int GetNum(string textGet)
{
    Console.WriteLine(textGet);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int num = GetNum("Введите число");

Console.Write(num + "->: ");

Cube(num);
