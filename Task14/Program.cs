﻿// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 12 мин
// 46 -> нет
// 161 -> да

bool DevidedByTwoNumbers(int num, int num1, int num2)
{
    if ((num % num1 == 0) && (num % num2 == 0)) return true;
    else return false;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
bool myresult = DevidedByTwoNumbers(number, 7, 23);
Console.WriteLine(myresult ? "Да" : "Нет");