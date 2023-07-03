/*
Напишите программу, которая будет принимать на вход два числа и выводить,является ли второе число кратным первому. Если второе число не кратно первому,
то программа выводит остаток от деления
34,5-> не кратно,остаток 4
*/
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int result = firstNumber % secondNumber ;
 if (result == 0 ) Console.WriteLine("True");
else Console.WriteLine(result);


