/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Enter x for first point");
int aX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y for first point");
int aY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter z for second point");
int aZ = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter x for second point");
int bX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y for second point");
int bY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter z for second point");
int bZ = Convert.ToInt32(Console.ReadLine());


int a = aY - bY;
int b = aX - bX;
int c = aZ - bZ;

double distance = Math.Sqrt(a * a + b * b + c * c);
Console.WriteLine(distance);