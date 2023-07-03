/* Напиши программу,которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78-8
*/
int rundomNumber = new Random().Next(10,100);
Console.WriteLine (rundomNumber);

int numberOne = rundomNumber % 10; 
int numberTwo = rundomNumber / 10; 

if (numberOne > numberTwo)
{
    Console.WriteLine (numberOne);
}
else
{
    Console.WriteLine (numberTwo);
}