/*
Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
7- 28
4-10
*/

int Getsum (int from,int to)
{
    int result=0;
    for ( int i = from; i <= to; i++)
    {
        result += i; //result = result + 1;
    }
    return result;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Getsum(1, number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum} ");