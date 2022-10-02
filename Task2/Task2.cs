//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

        int a, b;
 
        Console.WriteLine("Введите два числа :  ");
 
        a = Convert.ToInt32(Console.ReadLine()); 
        b = Convert.ToInt32(Console.ReadLine());
 
        if (a > b)
        { 
            //Console.WriteLine("{0} наибольшее число", a);
            Console.WriteLine("Число "+a+" большее, а число "+b+" меньшее"); 
        }
        else if (b > a)
        { 
            //Console.WriteLine("{0} наибольшее число ", b);
            Console.WriteLine("Число "+b+" большее, а число "+a+" меньшее");      
        }
        else
        {
           Console.WriteLine("Число "+a+" и число "+b+" равны");     
        }