﻿/* Задача 25:
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)   
2, 4 -> 16   */

/*int numberA = ReadInt("Введите число: ");
int numberB = ReadInt("Введите степень: ");
ToDegree(numberA, numberB);


// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}

// Функция ввода
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
} */

int A, B;

Console.Write("Введите число A: ");
A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
B = Convert.ToInt32(Console.ReadLine());

int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    {
        Console.WriteLine();
    }
        Console.WriteLine(A + " в степени " + B + " = " + result);