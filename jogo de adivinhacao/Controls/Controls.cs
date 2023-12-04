using jogo_de_adivinhacao.Exit;
using jogo_de_adivinhacao.GameThemes;
using jogo_de_adivinhacao.Instructions;
using jogo_de_adivinhacao.Player;

namespace GuessingGame.Controls;

public class Controls
{
    public static void ControlsThemesGame()
    {
        Console.Clear();

        bool opcaoEscolhida = false;
        GameThemes temaJogo = new GameThemes();
        GameLogicSoccer gameLogicSoccer = new GameLogicSoccer();
        GameLogicFilms gameLogicFilms = new GameLogicFilms();
        GameLogicGames gameLogicGames = new GameLogicGames();
        GameLogicSeries gameLogicSeries = new GameLogicSeries();
        GameLogicWars gameLogicWars = new GameLogicWars();

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
                gameLogicSoccer.LogicStartGameSoccer(temaJogo, player);
                gameLogicFilms.LogicStartGameFilms(temaJogo, player);
                gameLogicGames.LogicStartGameGames(temaJogo, player);
                gameLogicSeries.LogicStartGameSeries(temaJogo, player);
                gameLogicWars.LogicStartGameWars(temaJogo, player);
                break;
            }
        } while (!opcaoEscolhida);
        Environment.Exit(0);
    }

    public static void ControlsStartMenuOptions()
    {
        string[] menuOptions = { "Play Game", "Instructions", "Exit" };
        int selectedIndex = 0;

        do
        {
            Console.Clear();
            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine($"  << {menuOptions[i],-12} >>  ");
                Console.ResetColor();
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                selectedIndex = (selectedIndex - 1 + menuOptions.Length) % menuOptions.Length;
                break;

                case ConsoleKey.DownArrow:
                selectedIndex = (selectedIndex + 1) % menuOptions.Length;
                break;

                case ConsoleKey.Enter:
                if (selectedIndex == 0)
                {
                    Controls.ControlsThemesGame();
                }
                else if (selectedIndex == 1)
                {
                    ShowInstructions.Show();
                }
                else if (selectedIndex == 2)
                {
                    ExitGame.Exit();
                }
                break;
            }
        } while (true);
    }
}
