// Determine o número de dígitos de um número informado

using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Numero:");
		long num = long.Parse(Console.ReadLine());
		
		int dig = num.ToString().Length;
		
		Console.WriteLine($"{num} possuí {dig} digitos");
	}
}
