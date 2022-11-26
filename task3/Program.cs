/* 
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет 
*/

Console.WriteLine("enter the number of the day of the week");
int day = int.Parse(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("Monday, no");
}
if (day == 2)
{
    Console.WriteLine("Tuesday, no");
}
if (day == 3)
{
    Console.WriteLine("Wednesday, no");
}
if (day == 4)
{
    Console.WriteLine("Thursday, no");
}
if (day == 5)
{
    Console.WriteLine("Friday, no");
}
if (day == 6)
{
    Console.WriteLine("Saturday, yes");
}
if (day == 7)
{
    Console.WriteLine("Sunday, yes");
}
if (day < 1 | day > 7)
{
    Console.WriteLine("invalid value");
}