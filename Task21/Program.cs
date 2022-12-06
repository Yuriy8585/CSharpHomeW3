// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// А (3,6,8); В (2,1,-7) -> 15.84
// A (7,-5,0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter X1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Z1");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter X2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Z2");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2)), 2); // Pow возведение в степень Round округление после запятой
Console.WriteLine($"Расстояние между точками = {result}");
