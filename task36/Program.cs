/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.WriteLine($"Задайте длину массива: ");
int ElementNumbers = Convert.ToInt32(Console.ReadLine()); 
int randomNumber =  RandomNumbers(ElementNumbers, 1, 10);


int RandomNumbers(int ElementNumbers, int min, int max)
  {
  int[] randomNumber = new int[ElementNumbers];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");
 Console.Write("[ ");
    for (int i = 0; i <randomNumber.Length; i++ ){
      randomNumber[i] = new Random().Next(min, max);

      Console.Write(randomNumber[i] + ", ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumber[i];
      }
    }
     Console.Write("]");
     
  return sumElements;
 
  }
  Console.WriteLine($"  Сумма элементов, стоящих на нечётных позициях: {randomNumber}");
