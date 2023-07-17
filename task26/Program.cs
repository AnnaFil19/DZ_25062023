/*
Напишите программу,которая принимает на вход число и выдает количество цифр в числн
456-3
78-2
*/
int AmoutOF(int num)
{
    int amout = 0;
   while (num > 0)
   {
    num/=10; // num = num/10
    amout++; //amout = amout +1
   }
   return amout;
}

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе {number} = {AmoutOF(number)}");

