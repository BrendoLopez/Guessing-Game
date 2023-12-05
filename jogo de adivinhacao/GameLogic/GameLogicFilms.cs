using jogo_de_adivinhacao.GameThemes;
using jogo_de_adivinhacao.HelpTips;
using jogo_de_adivinhacao.Player;

namespace GuessingGame;

public class GameLogicFilms
{
    public void LogicStartGameFilms(GameThemes temaJogo, Player nickNamePlayer)
    {
        if (temaJogo.SelecionarTemaJogo == 1)
        {
            Console.Clear();
            Console.WriteLine($"{nickNamePlayer.NickNamePlayer}, você escolheu o tema: <<{temaJogo.TemaJogo[1]}>>");
            Console.WriteLine("Para este tema, temos a seguinte questão: ESSE FILME FOI CAMPEÃO EM BILHETERIA EM 2009 E COMANDA ATÉ OS DIAS DE HOJE, FOI E É TOP 1 NO RANKING DOS CINEMAS, QUE FILME É ESSE? ");
            Console.Write("Resposta: ");
            string respostaUsuario = Console.ReadLine();
            string respostaCorreta = "Avatar";
            int tentativas = 10;
            respostaCorreta = respostaCorreta.ToLower();
            respostaUsuario = respostaUsuario.ToLower();
            while (respostaUsuario != respostaCorreta)
            {
                for (int i = 0; i < tentativas; i++)
                {
                    tentativas--;
                    if (respostaUsuario != respostaCorreta)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Você errou! \nVocê agora tem {tentativas} tentativas {nickNamePlayer.NickNamePlayer}.");
                        Console.Write("Resposta: ");
                        respostaCorreta = respostaCorreta.ToLower();
                        respostaUsuario = Console.ReadLine();
                        respostaUsuario = respostaUsuario.ToLower();
                        break;
                    }
                }
                if (tentativas <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Suas tentivas acabaram, total restante: {tentativas}");
                    Console.WriteLine("A resposta era Avatar 1, esse filme foi um estouro em bilheteria nos cinemas, revolucionou a era cinematografica.");
                    Console.WriteLine("Ranking atual até a data de 04/12/2023");
                    Console.WriteLine("1º Avatar - Ano 2009 - Bilheteria(US$) 2 923 706 026");
                    Console.WriteLine("2º Vingadores: Ultimato - Ano 2019 - Bilheteria(US$) 2 799 439 100");
                    Console.WriteLine("3º Avatar: O caminho da água - Ano 2022 - Bilheteria(US$) 2 320 250 281");
                    Console.WriteLine("Até a próxima!");
                    break;
                }
                if (tentativas == 2)
                {
                    TipsFilms.TipsFilmes();
                }
            }
            if (respostaUsuario == respostaCorreta)
            {
                Console.WriteLine();
                Console.WriteLine("Você acertou, o filme do Avatar é o Campeão em bilheterias, até a data da criação deste jogo ele continua no top 1.");
                Console.WriteLine("Data da criação do game: 04/12/2023");
                Console.WriteLine("Até a próxima!");
                Environment.Exit(0);
            }
        }
    }
}
