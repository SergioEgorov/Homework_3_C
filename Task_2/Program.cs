Console.Write("Введите координату X точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X точки В: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки В: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки В: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1-x2,2)) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2);
Console.WriteLine($"Расстояние между точками А и В: {Math.Round(result,3)}");
