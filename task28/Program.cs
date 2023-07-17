/*
Напишите программу,которая принимает на вход число N и выдает произведение чисел от 1 до N
456-3
78-2
*/
int Base (int from,int to)
{
    int result=1;
    for ( int i = from; i <= to; i++)
    {
        result *= i; 
    }
    return result;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int proizvedenie = Base(1, number);
Console.WriteLine($"Произведение от 1 до {number} = {proizvedenie} ");