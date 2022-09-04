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
        array[i] = Convert.ToDouble(random.Next(100, 1000))/10; // изменяя 10 на 100, можно увеличить количество цифр после запятой.
        //array[i] = Math.Round(random.NextDouble() * 100 - 50, 2); это специальное действие для получения чисел double, как второй вариант, а предыдущее делит целочисленное на целочисленное
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
void Zadacha47()
{
// 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
int rows = 4;
int columns = 4;
double[,] array = new double[rows, columns];
FillArrayDouble(array);
PrintArrayDouble(array);
}
void FillArrayDouble(double[,] array, int startNumber = -100, int finishNumber = 9)
{
    finishNumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Convert.ToDouble(random.Next(1000, 10000))/10;
        }
    }
}
void PrintArrayDouble(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] +"  ");
        }
        Console.WriteLine();
    }
}
void Zadacha50()
{
// 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
    Console.WriteLine("Введите размер массива:");
    int rows = Convert.ToInt32(Console.ReadLine());
    int columns = rows;
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("Введите искомую строку:");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите искомый столбец:");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Элемент массива: {array[row, column]}");
}
void Zadacha52()
{
// 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    int rows = 5;
    int columns = 5;
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    double arifm = 0;
    for (int j = 0; j < rows; j++)
    {
        for (int i = 0; i < columns; i++)
        {
            arifm += array[i, j];
        }
        Console.WriteLine($"Результат {j+1} столбца = {arifm/rows}");
        arifm = 0;
    }
}
void Zadacha54()
{
// 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    int rows = 5;
    int columns = 6;
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Sort(array);
    Console.WriteLine();
    Console.WriteLine("Отсортированный массив");
    PrintArray(array);
}
void Sort(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = columns - 1; j > 0; j--)
        {
            for (int k = 0; k < j; k++)
            {
                if (array[i, k] < array[i, k+1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k+1];
                    array[i, k+1] = temp;
                }
            }
        }
    }
}
void FillArray(int[,] array, int startNumber = 1, int finishNumber = 9)
{
    finishNumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] +"\t");
        }
        Console.WriteLine();
    }
}
void Zadacha56()
{
// 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    int rows = 5;
    int columns = 6;
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    int indexMin = 0;
    int sumMin = RowSum(array, 0);
    Console.WriteLine();
    Console.WriteLine($"В строке {indexMin+1} сумма сумма элементов равна {sumMin}");
    for (int i = 1; i < rows; i++)
    {
        int sum = RowSum(array, i);
        Console.WriteLine($"В строке {i+1} сумма сумма элементов равна {sum}");
        if (sum < sumMin)
        {
            sumMin = sum;
            indexMin = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма равна {sumMin} и находится в строке {indexMin+1}");
}
int RowSum(int[,] array, int i)
{
    int sum = 0;
    int columns = array.GetLength(1);
    for (int j = 0; j < columns; j++)
    {
        sum += array[i, j];
    }
    return sum;
}
void Zadacha58()
{
// 58. Заполните спирально массив 4 на 4 числами от 1 до 16.
    int rows = 6;
    int columns = 6;
    int[,] array = new int[rows, columns];
    int row = 0;
    int column = 0;
    int changeRow = 0;
    int changeColumn = 1;
    int steps = columns;
    int turn = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[row, column] = i + 1;
        steps--;
        if (steps == 0)
        {
            if (turn % 2 == 0)
            {
                steps = rows - 1 - turn/2;
            }
            else
            {
                steps = columns - 1 - turn/2;
            }
            //steps = columns * (turn%2) + rows * ((turn+1) % 2) - 1 - turn/2; это повтор условия только в виде математической формулы.
            int temp = changeRow;
            changeRow = changeColumn;
            changeColumn = -temp;
            turn++;
        }
        row += changeRow;
        column += changeColumn;
    }
    PrintArray(array);
}

// 
