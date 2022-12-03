//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//  0, 7, 8, -2, -2 -> 2
//  1, -7, 567, 89, 223-> 3

/*
Console.Write("Введите количество чисел: ");
int count_of_numbers = Convert.ToInt32(Console.ReadLine());

int[] ShowNewArray( int count)
{
    int [] array = new int [count];
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите ваше {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    return array;
}

int PolNumbers(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) count++;
    }
    return count;
}

int [] array = ShowNewArray(count_of_numbers);
Console.WriteLine($"Кол-во положительных элементов: {PolNumbers(array)}");
*/


//  Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


/*
double Dot_x(int k1, int b1, int k2, int b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double Dot_y(int k1, int b1, double x)
{
    double y = k1 * x + b1;
    return y;
}

Console.Write("Введите первую точку: ");
int k_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую точку: ");
int b_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью точку: ");
int k_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите четвертую точку: ");
int b_2 = Convert.ToInt32(Console.ReadLine());

if ((k_1 * b_2 - k_2 * b_1) == 0)    // прямые параллельны
{  
    Console.WriteLine("Прямые параллельны друг другу.");
}

double x = Dot_x(k_1, b_1, k_2, b_2);
double y = Dot_y(k_1, b_1, x);
Console.WriteLine($"Точка пересечения прямых имеет координаты ({x}, {y}).");
*/