// Calcule a série de Fibonacci para um número inteiro não negativo informado pelo usuário.
// A série de Fibonacci inicia com os números F0 = 0 e F1 = 1, e cada número posterior
// equivale à soma dos dois números anteriores (Fn = Fn-1 + Fn-2). Por exemplo, caso o usuário
// informe o número 9, o resultado seria: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.

using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Numero:");
		int num = int.Parse(Console.ReadLine());
		int a = 0; int b = 1;
		
		for (int i = 0; i <= num; i++)
		{
			Console.Write(a + " ");
			int proximo = (a+b);
			a = b;
			b = proximo;
		}
	}
}
