﻿void Zadacha2()
{
    Console.WriteLine("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Наибольшее число: ");
        if (a > b)
            Console.WriteLine(a);
        else
            Console.WriteLine(b);
}
void Zadacha4()
{
    Console.WriteLine("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Наибольшее число: ");
    Console.WriteLine(Math.Max(a, Math.Max(b, c)));
}
void Zadacha6()
{
    Console.WriteLine("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
            Console.WriteLine("Число чётное");
        else
            Console.WriteLine("Число нечётное");
}
void Zadacha8()
{
    Console.WriteLine("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите последнее число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Чётные числа: ");
    for (int i = a; i <= b; i++)
            if (i % 2 == 0)
                Console.Write(i + " ");
}
void Zadacha13()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
        if(number > 99) 
        {
            Console.WriteLine(number / 100 % 10);
        }
        else Console.WriteLine("Нет третьего числа");
}
void Zadacha15()
{
    Console.WriteLine("Введите число от 1 до 7: ");
    int number = Convert.ToInt32(Console.ReadLine());
        if (number == 1)
        {
            Console.WriteLine("Нет");
        }
        else if (number == 2)
        {
            Console.WriteLine("Нет");
        }
        else if (number == 3)
        {
            Console.WriteLine("Нет");
        }
        else if (number == 4)
        {
            Console.WriteLine("Нет");
        }
        else if (number == 5)
        {
            Console.WriteLine("Нет");
        }
        else if (number == 6)
        {
            Console.WriteLine("Да");
        }
        else if (number == 7)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Неверно задано значение");
        }
}
