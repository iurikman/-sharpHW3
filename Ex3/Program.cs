/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string text)
{

    int result = 0;
    bool isCorrect = false;
    Console.WriteLine(text);
    while (!isCorrect) 
    {
        if ((int.TryParse(Console.ReadLine(), out result)) && result != 0) isCorrect = true;
        else Console.WriteLine("Ввели не число или 0");
    }
    return result;
}

int number = GetNumber("Введите число, а программа выдаст таблицу кубов всех чисел от 1 до этого числа.");

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i} в степени 3 = {i*i*i} ");
}
