/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
456-> 46
*/
int rundomNumber = new Random().Next(100,1000);
Console.WriteLine (rundomNumber);

int numberTwo = rundomNumber % 10;  //последняя цифра
int numberThree = rundomNumber / 100;  //первая цифра

int result = numberThree * 10 + numberTwo;
Console.WriteLine (result);