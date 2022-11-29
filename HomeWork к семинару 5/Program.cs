// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

/*
int [] CreateRandomArray (int size, int minValue, int maxValue)  // метод создания массива с ранд элементами
{
    int [] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray (int[] array)  //  демонстрация массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int CountPolNumber(int[] array)  // нахождение количества четных чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}

int size_array = 10;
int minValue_array = 100;
int maxValue_array = 999;
int[] createdArray = CreateRandomArray(size_array, minValue_array, maxValue_array);
ShowArray(createdArray);
int res = CountPolNumber(createdArray);
Console.WriteLine($"Кол-во четных элементов равно {res}");
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int [] CreateRandomArray (int size, int minValue, int maxValue)  // метод создания массива с ранд элементами
{
    int [] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray (int[] array)  //  демонстрация массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumChetnElements(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            result += array[i];
    }
    return result;
}

int size_array = 10;
int minValue_array = -10;
int maxValue_array = 10;
int[] createdArray = CreateRandomArray(size_array, minValue_array, maxValue_array);
ShowArray(createdArray);

int sum = SumChetnElements(createdArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");
*/



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// коментарий для преподавателя: в голове всё работает, а в коде реализовать не могу. Пробовал менять по-разному, но от ошибок избавиться
// не могу. Основная ошибка в том, что не возможно преобразовать double в double[].

/*
double RandomArray(int size, int minValue, int maxValue)
{
    
    int [] newArray = new int[size];
    double [] newDoubleArray = new double[size];
    double [] newCreatedArray = new double[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
        newDoubleArray[i] = new Random().NextDouble();
        newCreatedArray[i] = newArray[i] + newDoubleArray[i];
    }
    return newCreatedArray[i];
}

double MaxNumber(double[] array)
{
    double maxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
    }
    return maxNumber;
}

double MinNumber(double[] array)
{
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber) minNumber = array[i];
    }
    return minNumber;
}

int size_array = 10;
int minValue_array = 0;
int maxValue_array = 10;
double randomArray = RandomArray(size_array, minValue_array, maxValue_array);
Console.WriteLine($"{Math.Round(randomArray, 2)}");

double max_num = MaxNumber(randomArray);
double min_num = MinNumber(randomArray);
double result = max_num - min_num;
Console.WriteLine($"Разница между макс и мин элементами равна {result}");
*/
