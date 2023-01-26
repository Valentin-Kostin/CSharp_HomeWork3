/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

void FindCoordinat(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double dist = Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2) + Math.Pow((zA - zB), 2));
    Console.WriteLine($"A({xA},{yA},{zA}); B({xB},{yB},{zB}) -> " + dist);
}

int GetNum(string textGet)
{
    Console.WriteLine(textGet);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Ввод данных от пользователя координат x, y и z
int numAx = GetNum("Введите Х для А");
int numAy = GetNum("Введите Y для А");
int numAz = GetNum("Введите Z для А");
int numBx = GetNum("Введите Х для В");
int numBy = GetNum("Введите Y для В");
int numBz = GetNum("Введите Z для B");

// найти расстояние
FindCoordinat(numAx, numAy, numAz, numBx, numBy, numBz);