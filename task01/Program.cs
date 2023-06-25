/*Напишите программу,которая на вход принимает два числа 
и проверяет,является ли первое число квадратом второго
a=25; b=5-> да
*/

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2*number2)
Console.WriteLine ("true");
else
Console.WriteLine ("false");

