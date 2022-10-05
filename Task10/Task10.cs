/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Давай поработаем, ммм...");
string username = Console.ReadLine();
Console.WriteLine("Аа да, да - " + username);

int n;
Console.WriteLine("Введите трёхзначное число:");
n = Convert.ToInt32(Console.ReadLine());

if (n>=100)
{
 int second = (n%100)/10; 
 Console.WriteLine(second+ " ");
}
else
{
 Console.WriteLine(username+", Вы ввели нетрёхзначное число");   
}