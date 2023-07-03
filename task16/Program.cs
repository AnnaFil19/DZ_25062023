/*
Напишите программу, которая будет принимать на вход два числа и проверятет,является ли одно число квадратом другого
8,9-> нет
5,25-> да
*/
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
if ( firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber  ) Console.WriteLine("True");
else Console.WriteLine("fals");


