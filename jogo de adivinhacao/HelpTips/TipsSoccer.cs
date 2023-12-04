namespace jogo_de_adivinhacao.HelpTips;

public class TipsSoccer
{
    public static void TipsFootball()
    {
        Random random = new Random();
        int girarDadoSorte = random.Next(1, 3);

        if (girarDadoSorte == 1)
        {
            Console.WriteLine();
            Console.WriteLine("Você teve direito a uma dica!");
            Console.WriteLine("1 - Esse jogador já foi preso e ganhou um campeonato na cadeia.");
        }
        else if (girarDadoSorte == 2)
        {
            Console.WriteLine();
            Console.WriteLine("Você teve direito a duas dicas!");
            Console.WriteLine("1 - Esse jogador já jogou no Grêmio, Flamengo, Fluminense, Atlético Mineiro");
            Console.WriteLine("2 - Esse jogador saiu do PSG para o Barcelona e eternizou-se com jogadas magnificas!");
        }
        else if (girarDadoSorte == 3)
        {
            Console.WriteLine();
            Console.WriteLine("Você teve direito a três dicas!");
            Console.WriteLine("1 - Esse jogador tem um dente enorme.");
            Console.WriteLine("2 - Esse jogador tem um cabelo grande.");
            Console.WriteLine("3 - Esse jogador tem o apelido de bruxo!");
        }
    }
}
