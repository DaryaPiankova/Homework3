Console.Clear();

Console.WriteLine("Введите координаты точки A. Введите x1");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y1");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z1");
double z1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты точки Б. Введите x2");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y2");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z2");
double z2 = Convert.ToInt32(Console.ReadLine());


double result=Math.Sqrt(Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2)+Math.Pow(z1-z2, 2));
Console.WriteLine(result);