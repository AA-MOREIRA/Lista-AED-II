/*
Para cada produto informado (nome, preço e quantidade), escreva o nome do produto
comprado e o valor total a ser pago, considerando que são oferecidos descontos pelo
número de unidades compradas, segundo a tabela abaixo:

a. Até 10 unidades: valor total
b. de 11 a 20 unidades: 10% de desconto
c. de 21 a 50 unidades: 20% de desconto
d. acima de 50 unidades: 25% de desconto
*/

using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Nome do produto");
		string nome = Console.ReadLine();
		
		Console.WriteLine("Quantidade do produto");
		int quant = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Preço do produto");
		double preco = double.Parse(Console.ReadLine());
		
		double total = preco * quant;
		
		if (quant >= 11 && quant <= 20)
			total *= 0.9;
		else if (quant >= 21 && quant <= 50)
			total *= 0.8;
		else if (quant > 50)
			total *= 0.75;
		Console.WriteLine($"O valor de {quant} unidades de {nome} deu {total}");
	}
}
