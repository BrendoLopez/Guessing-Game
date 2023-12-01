using jogo_de_adivinhacao.GameThemes;
using jogo_de_adivinhacao.Player;

namespace GuessingGame;

public class GameLogic
{
    public void LogicStartGame(GameThemes temaJogo, Player nickNamePlayer)
    {

        if (temaJogo.SelecionarTemaJogo == 0)
        {
            Console.Clear();
            Console.WriteLine($"{nickNamePlayer}, você escolheu o tema: <<{temaJogo.TemaJogo[0]}>>");
            Console.WriteLine("Para este tema, temos a seguinte questão: QUAL JOGADOR DE FUTEBOL MARCOU 23 GOLS EM UM ÚNICO JOGO, COM APENAS 13 ANOS? ");
            Console.Write("Resposta: ");
            string respostaUsuario = Console.ReadLine();
            string respostaCorreta = "Ronaldinho";
            int tentativas = 10;
            while (respostaUsuario != respostaCorreta)
            {
                for (int i = 0; i < tentativas; i++)
                {
                    tentativas--;
                    if (respostaUsuario != respostaCorreta)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Você errou! \nVocê agora tem {tentativas} tentativas {nickNamePlayer}.");
                        Console.Write("Resposta: ");
                        respostaUsuario = Console.ReadLine();
                        break;
                    }
                }
                if (tentativas <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Suas tentivas acabaram, total restante: {tentativas}");
                    Console.WriteLine("A resposta era Ronaldinho Gaúcho, esse mito marcou simplesmente " +
                    "\n23 gols em uma única partida com apenas 13 anos de idade!");
                    Console.WriteLine("Até a próxima!");
                    break;
                }
                if (respostaUsuario == respostaCorreta)
                {
                    Console.WriteLine("Você acertou, o mito do Ronaldinho Gaúcho marcou simplesmente " +
                    "\n23 gols em uma única partida com apenas 13 anos de idade!");
                    Console.WriteLine("Até a próxima!");
                    Environment.Exit(0);
                }
            }
        }
    }
}
