using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_de_adivinhacao.Player;

public class Player
{
    public string NickNamePlayer { get; set; }

    public Player(string nickNamePlayer)
    {
        NickNamePlayer = nickNamePlayer;
    }
}
