// Напишите программу, которая на вход принимает пятизначное число и проверяет, является ли оно палиндромом
// 14212 = да
// 23432 = нет
// 12821 = да

Console.Clear();
Console.WriteLine("Enter number = ");
int x = 0;
int y;
int z;

int n = int.Parse(Console.ReadLine());
z = n;

while (n!=0)
{
    y = n%10;
    x = x*10 + remy;
    n = n/10;
}

if (z == x) 
{ 
    Console.WriteLine("PALL");
}
else 
{
    Console.WriteLine("NOT PALL");
}