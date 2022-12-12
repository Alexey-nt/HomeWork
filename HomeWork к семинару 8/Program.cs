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

void FromMaxToMin(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int[,] newArray = Create2dArray(5, 5, 0, 9);
Show2dArray(newArray);
FromMaxToMin(newArray);
Show2dArray(newArray);
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

int[] SumElements(int[,] array)
{
    int[] sumElements = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            sumElements[i] = sum;
        }
        sum = 0;
    }
    return sumElements;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int RowMinResult(int[] array)
{
    int resultSum = array[0];
    int row = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < resultSum)
        {
            resultSum = array[i];
            row = i;
        }
    }
    return (row);
}

int[,] newArray = Create2dArray(5, 4, 0, 9);
Show2dArray(newArray);
Console.WriteLine();
int[] sum = SumElements(newArray);
PrintArray(sum);
Console.WriteLine();
int minSum = RowMinResult(sum);
Console.WriteLine($"Строка с наименьшей суммой: {minSum + 1}");
*/

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

/*
int[,,] Create3dArray(int row, int column, int column2, int minVal, int maxVal)
{
    int[,,] created3dArray = new int[row, column, column2];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            for (int k = 0; k < column2; k++)
            {
                created3dArray[i, j, k] = new Random().Next(minVal, maxVal + 1);

            }
    return created3dArray;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] newArray = Create3dArray(2, 2, 2, 0, 9);
Show3dArray(newArray);
*/

//  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//  Например, на выходе получается вот такой массив:
//  01 02 03 04
//  12 13 14 05
//  11 16 15 06
//  10 09 08 07

/*
int n = 4;
int[,] array = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.Length)
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

void ShowSpiralArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($"0{array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

ShowSpiralArray(array);
*/