/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string s = Convert.ToString(num);
while (s.Length!=5)
{
    Console.Write($" {s.Length}\nВведите пятизначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
    s = Convert.ToString(num);
}

if ((s[0] == s[4]) & (s[1] == s[3]))
    Console.WriteLine($"Число {num} -> палиндром");
else
    Console.WriteLine($"Число {num} -> не палиндром");