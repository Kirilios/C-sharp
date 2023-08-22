/*Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("enter coordinates: ");
int a1 =Convert.ToInt32(Console.ReadLine());
int b1 =Convert.ToInt32(Console.ReadLine()); 
int a2 =Convert.ToInt32(Console.ReadLine());   
int b2 =Convert.ToInt32(Console.ReadLine());
int a3 =Convert.ToInt32(Console.ReadLine());
int b3 =Convert.ToInt32(Console.ReadLine());
int c = (b1 - a1)*(b1 - a1)+ (a2 - b2)*(a2 - b2)+ (a3 - b3)*(a3 -b3);
double distance = Math.Pow(c, 0.5);
Console.WriteLine($"{distance}");
