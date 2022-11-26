/* 
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет 
*/

Console.WriteLine("enter the number");
int day = int.Parse(Console.ReadLine());

if (day > 0 & day < 6)
{
    Console.WriteLine("No");
}
if (day == 6 | day == 7)
{
    Console.WriteLine("Yes");
}
if (day < 1 | day > 7)
{
    Console.WriteLine("invalid value");
}