Console.Clear();

int func(string dot, string axis)
{
    Console.WriteLine($"Введите координату {dot} точки {axis}");
    return Convert.ToInt32(Console.ReadLine());
}

double result(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
}

int x1 = func("x", "a");
int y1 = func("y", "a");
int z1 = func("z", "a");
int x2 = func("x", "b");
int y2 = func("y", "b");
int z2 = func("z", "b");

double distance = Math.Round(result(x1, x2, y1, y2, z1, z2));
Console.WriteLine(distance);



