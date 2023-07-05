/* # Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка (или на какой оси она находится).
# Пример:
# - x=34; y=-30 -> 4
# - x=2; y=4-> 1
# - x=-34; y=-30 -> 3
*/

int GetNumberOfQuater(int x, int y)
{
    int result = 0;
    if (x > 0 && y > 0)
{
    result = 1;
}
else if ( x < 0 && y < 0)
{
    result = 2;
}
   
    if (x < 0 && y < 0)
{
    result = 3;
}
else if ( x > 0 && y < 0)
{
    result = 4;
}
return result;
}

Console.WriteLine("Введите переменную x");
int userx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную y");
int usery = Convert.ToInt32(Console.ReadLine());

int quarter = GetNumberOfQuater (userx, usery);
if (quarter > 0)
{
    Console.WriteLine($"Точка [{userx}]:[{usery}] находится в {quarter} плоскости");
}
else
{
    Console.WriteLine($"Точка [{userx}]:[{usery}] находится на пересечении плоскости");
}