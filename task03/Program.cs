/*Напишите программу,которая будет выдавать 
название дня недели по заданному номеру
3- среда
*/
int userInput = Convert.ToInt32(Console.ReadLine());
if (userInput <8 && userInput > 0)
{if (userInput == 1)
Console.WriteLine ("Понедельник");
if (userInput == 2)
Console.WriteLine ("Вторник");
if (userInput == 3)
Console.WriteLine ("Среда");
if (userInput == 4)
Console.WriteLine ("Четверг");
if (userInput == 5)
Console.WriteLine ("Пятница");
if (userInput == 6)
Console.WriteLine ("Суббота");
if (userInput == 7)
Console.WriteLine ("Воскресенье");}


