Console.WriteLine("Введите длину окружности");
double l = Convert.ToDouble(Console.ReadLine());
double S = Math.Pow((l / 2), 2) / Math.PI;
Console.WriteLine($"Площадь вписанного круга: {S}");