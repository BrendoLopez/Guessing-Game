namespace jogo_de_adivinhacao.Instructions;

public class ShowInstructions
{
    public static void Show()
    {
        Console.Clear();
        Console.WriteLine("Instruções do jogo...");
        Console.WriteLine("");
        Console.WriteLine("É um jogo bem simples, onde você tem apenas 10 tentativas para acertar.");
        Console.WriteLine("As palavras serão aleatórias e haverá uma dica inicial, boa sorte!");
        Console.ReadKey();
    }
}
