using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_de_adivinhacao.Exit;

public class ExitGame
{
    public static void Exit()
    {
        Console.WriteLine("Você saiu do jogo! \nAté a próxima.");
        Environment.Exit(0);
    }
}
