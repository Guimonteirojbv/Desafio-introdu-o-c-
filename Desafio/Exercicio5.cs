namespace Desafio;

public class Exercicio5
{
    private string placa = Console.ReadLine();


    public void IsPlaca()
    {
          if (
            Char.IsLetter(placa, 0) && 
            Char.IsLetter(placa, 1) && 
            Char.IsLetter(placa, 2) &&
            int.IsPositive(placa[3]) &&
            int.IsPositive(placa[4]) &&
            int.IsPositive(placa[5]) && 
            int.IsPositive(placa[6])
            )
        {
            Console.WriteLine("Verdadeiro");
        } else
        {
            Console.WriteLine("Falso");
        }
    }

    

}
