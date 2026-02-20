/*
Calcule o retorno de um investimento financeiro fazendo as contas mês a mês, sem usar a
fórmula de juros compostos. O usuário deve informar quanto será investido por mês e
qual será a taxa de juros mensal. O programa deve informar o saldo do investimento após
um ano (soma das aplicações mês a mês considerando os juros compostos), e perguntar ao
usuário se ele deseja que seja calculado o ano seguinte, sucessivamente. Por exemplo,
caso o usuário deseje investir R$ 100,00 por mês, e tenha uma taxa de juros de 1% ao mês,
o programa forneceria a seguinte saída:

Saldo do investimento após 1 ano: 1280.9328043328942
Deseja processar mais um ano? (S/N)
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Valor investido por mês: ");
        double din = double.Parse(Console.ReadLine());

        Console.Write("Taxa de juros mensal (em %): ");
        double taxa = double.Parse(Console.ReadLine()) / 100.0;

        double saldo = 0;
        string resposta;

        do
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                saldo += din;
                saldo += saldo * taxa;
            }

            Console.WriteLine($"Saldo do investimento após 1 ano: {saldo}");
            Console.Write("Deseja processar mais um ano? (S/N): ");
            resposta = Console.ReadLine().ToUpper();

        } while (resposta == "S");
    }
}
