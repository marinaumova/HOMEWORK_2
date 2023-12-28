Console.Write ("Введите координаты точки x и y: ");
string[] coordinates = Console.ReadLine().Split(' ');
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);
if (x > 0 && y > 0)
{
Console.WriteLine("1");
}
else if (x < 0 && y > 0)
{
Console.WriteLine("2");
}
else if (x < 0 && y < 0)
{
Console.WriteLine("3");
}
else if (x > 0 && y < 0)
{
Console.WriteLine("4");
}
