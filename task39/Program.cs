/*
Напишите программу,которая перевернет одномерный массив
 (последний элемент будет на первом месте,а первый - на последнем и т.д.)
*/ 

int [] GenerateArray( int lenght, int start, int end)
{
    int[] array = new int[lenght];
    for(int i=0; i < lenght; i++ )
    {
     array[i]= new Random().Next(start, end + 1);
    }
    return array;
}

void printArray(int[] array, string name = "")
{
    Console.WriteLine(name);
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
     Console.Write(array[i]);
     if(i !=array.Length -1)
     {
        Console.Write(", ");
     }
    }
    Console.WriteLine("]");
}

int [] reverseArray (int[] array)
{
    int[] result = new int[array.Length];
    for (int i=0; i < array.Length; i++)
    {
        result[i] = array[array.Length -1 -i];
    }
return result;
}

Console.Clear();
int[] numbers = GenerateArray(10, -100, 100);
printArray(numbers, "Начальный");
int[] revArray = reverseArray(numbers);
printArray(revArray, "Перевернутый");
