// Determine as raízes de uma equação de 2º grau: ax2 + bx + c = 0 (recordar que o
// discriminante Δ = b2 – 4ac, e que a raiz r = (–b ± √Δ)/2a).

using System;
using System.Numerics;

class Program
{
	static void Main()
	{
		Console.WriteLine("Digite o valor de a");
		double a = double.Parse(Console.ReadLine());
		
		Console.WriteLine("Digite o valor de b");
		double b = double.Parse(Console.ReadLine());
		
		Console.WriteLine("Digite o valor de c");
		double c = double.Parse(Console.ReadLine());
		
		Complex delta = new Complex(b*b-4*a*c, 0);
		
		Complex r1 = (-b + Complex.Sqrt(delta)) / (2*a);
		Complex r2 = (-b - Complex.Sqrt(delta)) / (2*a);
		
		Console.WriteLine($"Raizes: {r1} e {r2}");
	}
}
