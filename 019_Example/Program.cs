/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// Решение задачи #19 для ЛЮБОГО введённого ЧИСЛА

Console.Write("Введите число ->");
string? number = Console.ReadLine();
int i = number.Length;
char[] reverseChar = new char[i];
int k = 0;
while (i > 0)
{
   i--;
   reverseChar[i] = number[k];
   k = k + 1;
}
string reverse = new string(reverseChar);
Console.WriteLine($"Введённое число: {number}");
Console.WriteLine($"Перевернутое число: {reverse}");
if (number == reverse)
{
    Console.Write("Вывод: введённое число является палиндромом!");
}
else
{
    Console.Write("Вывод: введённое число не является палиндромом!");
}