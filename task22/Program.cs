/* Напишите программу,которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
*/
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int mult = 0;
if (Num > 0)
{ while(count < Num + 1)
{mult = count * count;
count = count+1;
Console.Write($"{mult}, ");
}
}
else
{ count =count * (-1);
    while(count > Num - 1)
{mult = count * count;
count = count - 1;
Console.Write($"{mult}, ");
}
}