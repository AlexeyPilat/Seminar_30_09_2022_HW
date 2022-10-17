/*Задача 34 Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] - 2  */

Console.WriteLine("Введите размер массива:  ");

int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);  
Console.WriteLine("массив: ");
PrintArray(numbers);

int count = 0;

for (int n = 0; n < numbers.Length; n++)
if (numbers[n] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");


void FillArrayRandomNumbers(int[] numbers)       // Функция-метод заполнения массива
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] numbers)                   // Функция-метод вывод массива на экран
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}