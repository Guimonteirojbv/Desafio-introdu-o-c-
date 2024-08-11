using System.Runtime.CompilerServices;

namespace Desafio;

public class Exercicio2
{
    private string nome = Console.ReadLine();
    private string sobrenome = Console.ReadLine();

    public void MonstrarNomeCompleto()
    {
        Console.WriteLine($"{nome} {sobrenome}");
    }
}
