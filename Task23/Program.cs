// напишите программу которая принимает на вход N и выдает таблицу кубов от 1 до N

Console.Clear();
Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine()!);

string x = "";
for (int i = 1; i <= num; i++)
{
x+= Math.Pow(i, 3).ToString()+ " ";
}
Console.WriteLine(x);
