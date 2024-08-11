namespace Desafio;

public class Exercicio4
{
    string frase = Console.ReadLine();
    private int qntdCaracter = 0;
    public void QuantityOfCaracteres()
    {
        for (int i = 0; i < frase.Length; i++) {
            if (Char.IsLetter(frase[i])) {
                qntdCaracter++;
            }
        }

        Console.WriteLine($"A quantidade de caracteres na frase é {qntdCaracter}");
    }
}
