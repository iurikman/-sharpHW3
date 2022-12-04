/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetNumber(string text) // функция проверяет на ввод 5-значного числа
{
    int result = 0;
    bool isCorrect = false;
    while (isCorrect == false) 
    {
        Console.WriteLine(text);
        if (int.TryParse(Console.ReadLine(), out result) && result < 100000 && result > 9999) 
        {
            isCorrect = true;
        }
        else Console.WriteLine("Ввели НЕ пятизначное число");
    }
    return result;
}

int number = GetNumber("Введите пятизначное число");

// проверяем на полиндром через перевод числа в строку и выводим результат:
if (number.ToString()[0] == number.ToString()[4])
{
    if (number.ToString()[1] == number.ToString()[3]) Console.WriteLine("Да");
}
else Console.WriteLine("Нет");