// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int Stepen(int a, int b)
{
    int count = 1;
    int result = 1;
    while (count <= b)
    {
        result = result * a;
        count++;
    }
    return result;
}

Console.WriteLine("Введите число A: ");
int user_num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int user_num2 = Convert.ToInt32(Console.ReadLine());

int numOfStepen = Stepen(user_num1, user_num2);
Console.WriteLine($"Ваше число {user_num1} в степени {user_num2} равно {numOfStepen}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int CountOfDigits(int number)
{
    int current = 1;
    while (number >= 10)
    {
        number = number / 10;
        current++;
    }
    return current;
}

Console.Write("Введите число: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int count_digit = CountOfDigits(user_num);
Console.WriteLine($"Кол-во цифр в числе: {count_digit}");

int count = 1;
int sum = 0;
int current = user_num;
while (count <= count_digit)
{
    sum = (current % 10) + sum;
    current = user_num / 10;
    count += 1;
}

Console.WriteLine($"Сумма цифр в числе {user_num} равна {sum}");
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
int [] CreateNewArray (int min, int max)  // Создание рандомного массива
{
    int size = 8;
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int [] array)  // Вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    
    }
}

Console.Write("Введите минимальный элемент: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [] array1 = CreateNewArray(minValue, maxValue);
ShowArray(array1);
*/