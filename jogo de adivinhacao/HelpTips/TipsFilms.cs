namespace jogo_de_adivinhacao.HelpTips;

public class TipsFilms
{
    public static void TipsFilmes()
    {
        Random random = new Random();
        int girarDadoSorte = random.Next(1, 3);

        if (girarDadoSorte == 1)
        {
            Console.WriteLine();
            Console.WriteLine("Você teve direito a uma dica!");
            Console.WriteLine("1 - Filme com bonecos azuis!!!");
        }
        else if (girarDadoSorte == 2)
        {
            Console.WriteLine();
            Console.WriteLine("Você teve direito a duas dica!");
            Console.WriteLine("1 - Humanos no controle!!!");
            Console.WriteLine("2 - Técnologia e novos mundos!!!");
        }
        else if (girarDadoSorte == 3)
        {
            Console.WriteLine();
            Console.WriteLine("Você teve direito a três dica!");
            Console.WriteLine("1 - Humanos no controle!!!");
            Console.WriteLine("2 - Técnologia e novos mundos!!!");
            Console.WriteLine("3 - Um mundo totalmente diferente, cheio de animais exóticos, se conectam com cabelo [...]");
        }
    }
}
