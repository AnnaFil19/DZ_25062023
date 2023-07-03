/*
Напишите программу, которая будет принимать на вход число и проверятет,кратно ли оно одновременно 7 и 23
14-> нет
161-> да
*/
int firstNumber = Convert.ToInt32(Console.ReadLine());
if ( firstNumber % 7 == 0 && firstNumber % 23 == 0  ) Console.WriteLine("True");
else Console.WriteLine("fals");


