using System;

class Program
{
    private class CorpoCeleste
    {
        private double massa;
        private double densidade;
        private double posicaoX;
        private double posicaoY;

        internal CorpoCeleste(double massa, double densidade, double posicaoX, double posicaoY)
        {
            this.massa = massa;
            this.densidade = densidade;
            this.posicaoX = posicaoX;
            this.posicaoY = posicaoY;
        }

        internal double Massa { get { return massa; } }
        internal double PosicaoX { get { return posicaoX; } }

        internal double Raio
        {
            get
            {
                if (densidade <= 0) return 0;
                double volume = massa / densidade;
                return Math.Pow((3.0 * volume) / (4.0 * Math.PI), 1.0 / 3.0);
            }
        }
    }

    static void Main()
    {
        Carro c = new Carro(5, 4, 50f, 100f, 10f, 999950f, "Gol", 4);
        Console.WriteLine($"Km inicial: {c.QuilometragemAtual}");
        c.Percorrer(60f);
        Console.WriteLine($"Km atual: {c.QuilometragemAtual}\n");

        CorpoCeleste[] sistema = new CorpoCeleste[10];
        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            sistema[i] = new CorpoCeleste(
                rnd.NextDouble() * 1000 + 10,
                rnd.NextDouble() * 5 + 1,
                rnd.NextDouble() * 1000 - 500,
                rnd.NextDouble() * 1000 - 500
            );
        }

        CorpoCeleste maiorMassa = sistema[0];
        CorpoCeleste maiorRaio = sistema[0];
        CorpoCeleste menorX = sistema[0];
        CorpoCeleste maiorX = sistema[0];

        for (int i = 1; i < sistema.Length; i++)
        {
            if (sistema[i].Massa > maiorMassa.Massa) maiorMassa = sistema[i];
            if (sistema[i].Raio > maiorRaio.Raio) maiorRaio = sistema[i];

            if (sistema[i].PosicaoX < menorX.PosicaoX) menorX = sistema[i];
            if (sistema[i].PosicaoX > maiorX.PosicaoX) maiorX = sistema[i];
        }

        Console.WriteLine($"Maior massa: {maiorMassa.Massa:F2}");
        Console.WriteLine($"Maior raio: {maiorRaio.Raio:F2}");
        Console.WriteLine($"Distancia entre os mais distantes no eixo X: {(maiorX.PosicaoX - menorX.PosicaoX):F2}");

        Console.ReadLine();
    }
}
