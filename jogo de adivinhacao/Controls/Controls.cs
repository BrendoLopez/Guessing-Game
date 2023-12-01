﻿using GuessingGame;
using jogo_de_adivinhacao.GameThemes;
using jogo_de_adivinhacao.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame.Controls;

public class Controls
{
    public static void Start()
    {
        Console.Clear();

        bool opcaoEscolhida = false;
        GameThemes temaJogo = new GameThemes();
        GameLogic gameLogic = new GameLogic();
        
        Console.Write("O jogo está começando! \nMas antes de começarmos, nos diga o seu Nickname: ");
        string nickNamePlayer = Console.ReadLine();
        Player player = new Player(nickNamePlayer);

        do
        {
            Console.Clear();
            Console.WriteLine($"{player.NickNamePlayer}, escolha o tema do jogo abaixo.");
            Console.WriteLine();

            temaJogo.CoresTemasJogo();

            ConsoleKeyInfo clickInfoKey = Console.ReadKey();

            switch (clickInfoKey.Key)
            {
                case ConsoleKey.UpArrow:
                temaJogo.SelecionarTemaJogo = (temaJogo.SelecionarTemaJogo - 1 + temaJogo.TemaJogo.Length) % temaJogo.TemaJogo.Length;
                break;

                case ConsoleKey.DownArrow:
                temaJogo.SelecionarTemaJogo = (temaJogo.SelecionarTemaJogo + 1) % temaJogo.TemaJogo.Length;
                break;

                case ConsoleKey.Enter:
                opcaoEscolhida = true;
                gameLogic.LogicStartGame(temaJogo, player);
                break;
            }
        } while (!opcaoEscolhida);
        Environment.Exit(0);
    }
}