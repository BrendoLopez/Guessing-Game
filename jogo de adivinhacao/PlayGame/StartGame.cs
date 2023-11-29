using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_de_adivinhacao.PlayGame;

public class StartGame
{
    public static void Start()
    {
        Console.Clear();
        Console.Write("O jogo está começando! \nMas antes de começarmos, nos diga o seu Nickname: ");
        string nickNamePlayer = Console.ReadLine();

        bool opcaoEscolhida = false;
        string[] temaJogo = { "Futebol", "Filmes", "Séries", "Jogos Online", "Guerras" };
        int selecionarTemaJogo = 0;
        do
        {
            Console.Clear();
            Console.WriteLine($"{nickNamePlayer}, escolha o tema do jogo abaixo.");
            Console.WriteLine();

            for (int i = 0; i < temaJogo.Length; i++)
            {
                if (i == selecionarTemaJogo)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine($"  << {temaJogo[i]} >>  ");
                Console.ResetColor();
            }

            ConsoleKeyInfo clickInfoKey = Console.ReadKey();
            switch (clickInfoKey.Key)
            {
                case ConsoleKey.UpArrow:
                selecionarTemaJogo = (selecionarTemaJogo - 1 + temaJogo.Length) % temaJogo.Length;
                break;

                case ConsoleKey.DownArrow:
                selecionarTemaJogo = (selecionarTemaJogo + 1) % temaJogo.Length;
                break;

                case ConsoleKey.Enter:
                opcaoEscolhida = true;
                if (selecionarTemaJogo == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"{nickNamePlayer}, você escolheu o tema: <<{temaJogo[0]}>>");
                    Console.WriteLine("Para este tema, temos a seguinte questão: QUAL JOGADOR DE FUTEBOL MARCOU 23 GOLS EM UM ÚNICO JOGO, COM APENAS 13 ANOS? ");
                    Console.Write("Resposta: ");
                    string respostaUsuario = Console.ReadLine();
                    string respostaCorreta = "Ronaldinho";
                    int tentativas = 10;
                    while (respostaUsuario != respostaCorreta || tentativas == 0)
                    {
                        for (int i = 0; i < tentativas; i++)
                        {
                            tentativas--;
                            if (respostaUsuario != respostaCorreta)
                            {
                                Console.WriteLine($"Você errou! \nVocê agora tem {tentativas} tentativas {nickNamePlayer}.");
                                Console.Write("Resposta: ");
                                respostaUsuario = Console.ReadLine();
                                break;
                            }
                        }
                        if (tentativas <= 0)
                        {
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
                break;
            }
        } while (!opcaoEscolhida);
        Environment.Exit(0);
    }
}
