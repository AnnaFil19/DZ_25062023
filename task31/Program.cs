/* Задайте массив из 12 элементов, заполненный случайными числами из промежутка -9;9.
Найдите сумму отрицательных и положительных элементов массива.
 3,9,-8,1,0,-7,2,-1,8,-3,-1,6
 сумма поло 29, отриц -20
*/ 

int [] getRandomArray(int Lenght, int deviation)
{
    int [] result = new int[Lenght];
    for (int i = 0; i < Lenght; i++)
    {
        result[i]= new Random().Next(- deviation, deviation + 1);
    }
    return result;
}
 void printArray(int[] arrayToPrint)
 {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if ( i != arrayToPrint.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
 }
 int sumElementsOFArray(int [] arrayToCalculate, int multiply)
 {
    int result=0;
    for (int i=0; i < arrayToCalculate.Length; i++)
    {
        if (arrayToCalculate[i] * multiply > 0)
        {
            result += arrayToCalculate[i];
        }
    }
    return result;
 }
 int [] randomArray = getRandomArray( 12, 9);
 printArray(randomArray);
 Console.WriteLine();

int positiveSumOFArray = sumElementsOFArray(randomArray,1);
int negativeSumOFArray = sumElementsOFArray(randomArray,-1);
Console.WriteLine($"Сумма положительных чисел в массиве равна {positiveSumOFArray},сумма отрицательных в массиве равна {negativeSumOFArray}");


