//  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
double[,] Create2dArray(int row, int column, int minVal, int maxVal)
{
    double[,] created2dArray = new double[row, column];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray[i, j] = Math.Round(rnd.NextDouble() * (maxVal - minVal) + minVal, 2);
    return created2dArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] created2dArray = Create2dArray(3, 4, 0, 9);
Show2dArray(created2dArray);
*/

//  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

//17 -> такого числа в массиве нет

/*
int[,] Create2dArray(int row, int column, int minVal, int maxVal)
{
    int[,] created2dArray = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray[i, j] = new Random().Next(minVal, maxVal + 1);
    return created2dArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ElementOfPosition(int[,] array)
{
    Console.WriteLine("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца: ");
    int column = Convert.ToInt32(Console.ReadLine());
    if (row >= array.GetLength(0) && column >= array.GetLength(1))
        Console.WriteLine("Ваши значения превышают размер массива.");
    else
        Console.WriteLine($"Ваш элемент массива равен: {array[row, column]}");
}


int[,] newArray = Create2dArray(5, 5, 1, 9);
Show2dArray(newArray);
ElementOfPosition(newArray);
*/


//  Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int[,] Create2dArray(int row, int column, int minVal, int maxVal)
{
    int[,] created2dArray = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray[i, j] = new Random().Next(minVal, maxVal + 1);
    return created2dArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void AverageSum(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        double averageSum = Math.Round(sum / array.GetLength(0), 1);
        Console.Write(averageSum + " ");
    }
    
}

int[,] newArray = Create2dArray(3, 5, 1, 9);
Show2dArray(newArray);
AverageSum(newArray);
*/