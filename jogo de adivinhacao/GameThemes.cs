using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_de_adivinhacao;

public class GameThemes
{
    public string[] TemaJogo { get; set; } = { "Futebol", "Filmes", "Séries", "Jogos Online", "Guerras" };
    public int SelecionarTemaJogo { get; set; } = 0;

    public void CoresTemasJogo()
    {
        for (int i = 0; i < TemaJogo.Length; i++)
        {
            if (i == SelecionarTemaJogo)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            Console.WriteLine($"  << {TemaJogo[i]} >>  ");
            Console.ResetColor();
        }
    }
}
