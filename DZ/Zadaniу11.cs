Console.WriteLine("Введите внутренний радиус (r):");
double r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите внешний радиус (R):");
double R = Convert.ToInt32(Console.ReadLine());
double S = Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2));
Console.WriteLine($"Площадь кольца: {S}");
