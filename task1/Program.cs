/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("enter the number");
int num = int.Parse(Console.ReadLine());

if (num > 99)
{
    num = num / 10;
    num = num % 10;
}
else
{
    num = num % 10;
}
Console.WriteLine(num);
