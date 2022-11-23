// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
void Palindrome(int num)
{
    if ((num % 10 == num / 10000) && (num / 1000) % 10 == (num % 100) / 10)
    {
        Console.WriteLine("Ваше число является палиндромом.");
    }
    else Console.WriteLine("Ваше число не является палиндромом.");
}

Console.WriteLine("Введите ваше пятизначное число для проверки на палиндром: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if (user_num >= 10000 && user_num <= 99999)
{
    Palindrome(user_num);
}
else Console.WriteLine("Ваше число не соответствует условию задачи.");
*/


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double LongLine(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distanceAB = Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)), 2);
    return distanceAB;
}

Console.WriteLine("Введите вашу координату X для точки А: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вашу координату Y для точки А: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вашу координату Z для точки А: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вашу координату X для точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вашу координату Y для точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вашу координату Z для точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = LongLine(xA, yA, zA, xB, yB, zB);

Console.WriteLine($"Расстояние между вашими точками в 3D пространстве равно {distance}");
*/


// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*
void Cube(int num)
{
    int current = 1;
    while (current <= num)
    {
        int result = current * current * current;
        Console.Write($"{result}, ");
        current++;
    }
    Console.WriteLine($"\b\b.");
}

Console.WriteLine("Введите ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{
    Console.Write($"{number} -> ");
    Cube(number);
}
else Console.WriteLine("Невозможное значение.");
*/