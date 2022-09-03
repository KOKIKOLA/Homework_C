void Zadacha2()
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
    number = Math.Abs(number);
    if(number < 100) 
        {
            Console.WriteLine("Нет третьего числа");
        }
    else
    {
        while (number > 999)
        {
            number /= 10;
        }
        Console.WriteLine(number%10);
    }
}
void Zadacha15()
{
    Console.WriteLine("Введите число от 1 до 7: ");
    int number = Convert.ToInt32(Console.ReadLine());
        if (number == 1)
        {
            Console.WriteLine("Будни");
        }
        else if (number == 2)
        {
            Console.WriteLine("Будни");
        }
        else if (number == 3)
        {
            Console.WriteLine("Будни");
        }
        else if (number == 4)
        {
            Console.WriteLine("Будни");
        }
        else if (number == 5)
        {
            Console.WriteLine("Будни");
        }
        else if (number == 6)
        {
            Console.WriteLine("Выходной");
        }
        else if (number == 7)
        {
            Console.WriteLine("Выходной");
        }
        else
        {
            Console.WriteLine("Неверно задано значение");
        }
}
void Zadacha19()
{
// 19. Программа, которая проверяет, является ли пятизначное число палиндромом.
    Console.WriteLine("Введите положительное пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int num1 = number;
    int result = 0;
    while (number > 0)
    {
        result *= 10;
        result += number % 10;
        number /= 10;
    }
    if (num1 == result)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
void Zadacha21()
{
// 21. Программа вычисляет расстояние между двумя точками в 3D пространстве.
    Console.WriteLine("Введите 1ю координату точки А: ");
    int xa = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2ю координату точки А: ");
    int ya = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 3ю координату точки А: ");
    int za = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 1ю координату точки B: ");
    int xb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2ю координату точки B: ");
    int yb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 3ю координату точки B: ");
    int zb = Convert.ToInt32(Console.ReadLine());
    double result =Math.Pow(Math.Pow((xb-xa), 2) + Math.Pow((yb-ya), 2) + Math.Pow((zb-za), 2), 0.5);
    Console.WriteLine($"Расстояние между точками {(Math.Truncate(100 * result) / 100)}");
}
void Zadacha23()
{
//23. Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    Console.WriteLine("Введите число: ");
    int finishnumber = Convert.ToInt32(Console.ReadLine());
    int startnumber = 1;
    while (startnumber <= finishnumber)
    {
        Console.WriteLine((Math.Pow(startnumber, 3)));
        startnumber++;
    }
}
void Zadacha25()
{
// 25. Цикл, который принимает на вход два числа (А и В) и возводит А в натуральную степень В.
    int a = 5;
    int b = 3;
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result *= a;
    }
    Console.WriteLine($"{a}^{b} = {result}");
}
void Zadacha27()
{
// 27. Программа, которая принимает число и выдаёт сумму цифр.
    int number = 12345;
    int sum = 0;
    Console.Write("Сумма цифр в числе " + number);
    while(number > 0)
    {
        sum += number%10;
        number /= 10;
    }
    Console.WriteLine(" равна " + sum);
}
void Zadacha29()
{
// 29. Программа которая задаёт массив из 8 случайных чисел и выводит отсортированный по модулю массив.
    int size = 8;
    int [] array = new int [size];
    Random random = new Random();
    for (int i = 0; i <size; i++)
    {
        array[i] = random.Next(-10, 11);
    }
    for (int i = 0; i <size; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
    for (int i = size - 1; i > 0; i--)
    {
        for (int k = 0; k < i; k++)
        {
            if (Math.Abs(array[k]) > Math.Abs(array[k+1]))
            {
            int temp = array[k];
            array[k] = array[k+1];
            array[k+1] = temp;
            }
        }
    }
    for (int i = 0; i <size; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}
void Zadacha34()
{
//34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    int size = 10;
    int count = 0;
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"В массиве {count} четных чисел");
}
void Zadacha36()
{
// 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    int size = 4;
    int sum = 0;
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(0, 100);
    }
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    Console.WriteLine($"Сумма с нечётными индексами равна {sum}");
}
void Zadacha38()
{
//38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    int size = 10;
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 100 - 50, 2);
    }
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Разность между максимальным числом {max} и минимальным числом {min} равна {max - min}");
}
void Zadacha41()
{
//41. Пользователь вводит с клавиатуры М чисел. Посчитать сколько чисел больше 0 ввёл пользователь.
    int count = 0;
    Console.WriteLine("Сколько чисел требуется ввести?");
    int m = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Ведите {i+1} число:  ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) count++;
    }
    Console.WriteLine("Было введено чисел больше нуля: " + count);
}
void Zadacha43()
{
// 43.Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    Console.WriteLine("Введите k1: ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b1: ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите k2: ");
    int k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b2: ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны, точки пересечения нет.");
    }
    else
    {
        double x = (b2 - b1)/(k1-k2);
        double y = k1 * x + b1;
        double y2 = k2 * x + b2;
        Console.WriteLine($"Прямые пересекаются в точке А({x}, {y})");
        Console.WriteLine($"Прямые пересекаются в точке А({x}, {y2})");
    }
}


