/* Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11;  82 -> 10;  9012 -> 12   */

/* int number = ReadInt("Введите число: ");  // number == 82

int len = NumberLen(number);
SumNumbers(number, len);

// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;    // a = a/10
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10; // sum = sum + n % 10
        n /= 10;       // n = n / 10
    }
    Console.WriteLine($"сумма цифр {sum}");
}

// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} */

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int S = 0;

while (A > 0)
{
        S = S + A % 10;
        A = A /10;
}
Console.WriteLine($"Сумма цифр {S}");