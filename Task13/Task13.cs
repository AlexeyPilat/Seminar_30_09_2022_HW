/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

void Task13()
{
    Console.Write("Введи число: ");
    int n = Convert.ToInt32(Console.ReadLine());  // конвертация прочитанного значения из терминала в вещественное число n
    string nText = Convert.ToString(n);           // Конвертация числа n в строковую запись
    if (nText.Length > 2)                         // Условие при котором строковая длина числа n сравнивается с порядковым индексом данного числа
    {
        Console.WriteLine("третья цифра -> " + nText[2]);
    }
    else
    {
        Console.WriteLine("-> третьей цифры нет");
    }
}

//Task13();

void Task13_()
{
    Console.Write("Введи число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    n = Math.Abs(n);

    if (n > 99)
    {
        while (n > 999)
        {
            n /= 10;
        }
        Console.WriteLine($"третья цифра числа = {n % 10}");
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}
Task13_();