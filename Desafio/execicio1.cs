namespace Desafio;

public class Execicio1
{
    string name = Console.ReadLine();

    public void MostrarNome()
    {
        if(name == "")
        {
            Console.WriteLine("Nome não inserido");
        } else
        {
            Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
        }
    }

}
