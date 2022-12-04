/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber(string text)
{
    int result = 0;
    bool isCorrect = false;
    Console.WriteLine(text);

    while (!isCorrect)
    {
    if (int.TryParse(Console.ReadLine(), out result)) isCorrect = true;
    else Console.WriteLine("Ввели не число");
    } 
    return result;
}

int xa = GetNumber("Введите координату Ха:");
int ya = GetNumber("Введите координату Ya:");
int za = GetNumber("Введите координату Za:");

int xb = GetNumber("Введитк координату Xb:");
int yb = GetNumber("Введите координату Yb:");
int zb = GetNumber("Введите координату Zb:");

// формула расстояния между 2-мя точками, точность - 2 знака после запятой:
double res = Math.Round(Math.Abs(Math.Pow(Math.Pow((xb-xa), 2) + Math.Pow((yb-ya), 2) + Math.Pow((zb-za), 2), 0.5)), 2); 

Console.WriteLine($"Расстояние между точками А и В :  {res}.");