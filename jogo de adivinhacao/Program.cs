using jogo_de_adivinhacao;
using jogo_de_adivinhacao.Exit;
using jogo_de_adivinhacao.Instructions;
using jogo_de_adivinhacao.PlayGame;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string[] menuOptions = { "Play Game", "Instructions", "Exit" };
        int selectedIndex = 0;
        Console.Write("O jogo está começando! \nMas antes de começarmos, nos diga o seu Nickname: ");
        Player player = new Player();
        player.NickNamePlayer = Console.ReadLine();

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
                    StartGame.Start(player);
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