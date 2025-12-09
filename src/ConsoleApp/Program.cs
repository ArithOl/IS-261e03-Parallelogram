double ladoA = 5;
double ladoB = 10;
double altura = 15;
double perimetro = Application.Paralelogramo.Perimetro(ladoA, ladoB);
double area = Application.Paralelogramo.Area(ladoA, altura);
double volumen = Application.Paralelogramo.Volumen(area, altura);

Console.WriteLine($"El perimetro de un paralelogramo con lados {ladoA} cm y{ladoB} cm es {perimetro} cm");
Console.WriteLine($"El area de un paralelogramo con base {ladoA} cm y altura {altura} cm es {area} cm2");
 