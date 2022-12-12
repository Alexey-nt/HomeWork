//  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  В итоге получается вот такой массив:
//  7 4 2 1
//  9 5 3 2
//  8 4 4 2

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

int[,] FromMaxToMin(int[,] array)
{
    int maxNumber = array[i, j];
    for (int i = 0; i < array.GetLength(0); i++)
    {

        if (array[i, j] > maxNumber)
            Console.Write(array[i, j] + " ");
    }
    for (int j = 0; j < array.GetLength(1); j++)
        return array;
}


int[,] newArray = Create2dArray(5, 5, 0, 9);
Show2dArray(newArray);
FromMaxToMin(newArray);
*/

//  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//  
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  5 2 6 7
//  
//  Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void SumElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        int minSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            if (sum <= minSum)
            {
                
            }

        }
        Console.Write(sum2 + " ");
    }
}

int[,] newArray = Create2dArray(5, 4, 0, 9);
Show2dArray(newArray);
SumElements(newArray);


//  Задача 58(дополнительно): Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//  Например, даны 2 матрицы:
//  2 4 | 3 4
//  3 2 | 3 3
//  Результирующая матрица будет:
//  18 20
//  15 18





//  Задача 60(дополнительно): ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//  Массив размером 2 x 2 x 2
//  66(0,0,0) 25(0,1,0)
//  34(1,0,0) 41(1,1,0)
//  27(0,0,1) 90(0,1,1)
//  26(1,0,1) 55(1,1,1)




//  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//  Например, на выходе получается вот такой массив:
//  01 02 03 04
//  12 13 14 05
//  11 16 15 06
//  10 09 08 07
