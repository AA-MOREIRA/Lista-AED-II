// Calcule a raiz quadrada aproximada de um número inteiro informado pelo usuário,
// respeitando o erro máximo também informado pelo usuário. Não utilize funções predefinidas.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número: ");
        double n = double.Parse(Console.ReadLine());

        Console.Write("Digite o erro máximo: ");
        double erroMaximo = double.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Não é possível calcular a raiz de um número negativo");
            return;
        }

        double x = n;
        double raiz = 0;
        if (n == 0)
        {
            raiz = 0;
        }
        else
        {
            while (true)
            {
                raiz = 0.5*(x + (n / x));
                
                double diferenca = raiz - x;
                if (diferenca < 0) diferenca = -diferenca;

                if (diferenca < erroMaximo)
                {
                    break;
                }
                x = raiz;
            }
        }
        Console.WriteLine($"A raiz aproximada é: {raiz}");
    }
}
