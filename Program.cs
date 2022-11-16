/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Console.WriteLine("Введите ваше первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваше второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2)
{
    Console.WriteLine($"Число {num_1} больше чем число {num_2}");
}
else
{
    Console.WriteLine($"Число {num_2} больше чем число {num_1}");
}
*/


/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.WriteLine("Введите ваше первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваше второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваше третье число: ");
int num_3 = Convert.ToInt32(Console.ReadLine());

int num_max = num_1;

if (num_2 > num_1)
{
    num_max = num_2;
}
if (num_3 > num_1)
{
    num_max = num_3;
}

Console.WriteLine($"Максимальным числом является число {num_max}");
*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.WriteLine("Введите ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"Число {num} четное.");
}
else
{
    Console.WriteLine($"Число {num} нечетное.");
}
*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
Console.WriteLine("Введите ваше число N: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = (num / num) + 1;

while (current <= num)
{
    Console.WriteLine(current + " ");
    current = current + 2;
}
*/