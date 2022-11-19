/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
/*
int SecondDigit(int num)
{
    int num_2zn = num % 100;
    int num_1zn = num_2zn / 10;
    return num_1zn;
}

Console.Write("Введите ваше трехзначное число: ");
int user_num = Convert.ToInt32(Console.ReadLine());
while (user_num < 100 | user_num > 999)
{
    Console.Write("Ваше число не трехзначное.");
    break;
}
int num2 = SecondDigit(user_num);

Console.Write($"Вторая цифра вашего числа {num2}");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int ThirdDigit(int num)
{
    if (num > 99)
    {
        int num1 = num / 100;
        int num2 = num1 % 100000;
        return num2;
    }
    else Console.WriteLine("Третьей цифры нет.");
}

Console.WriteLine("Введите ваше число: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int num_1 = ThirdDigit(user_num);
Console.Write($"Третья цифра вашего числа {num_1}");

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/