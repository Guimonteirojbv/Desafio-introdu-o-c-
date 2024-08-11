namespace Desafio;

public class Exercicio3
{
    double num1 = Convert.ToDouble(Console.ReadLine());
    double num2 = Convert.ToDouble(Console.ReadLine());

    public void Soma()
    {
        Console.WriteLine($"A soma entre os números é: {num1 + num2}");
    }

    public void Subtracao() 
    {
        Console.WriteLine($"A subtração entre os números é: {num1 - num2}");
    }

    public void Multiplicacao()
    {
        Console.WriteLine($"A Multiplicação entre os números é: {num1 * num2}");
    }

    public void Divisao()
    {
        if (num2 == 0)
        {
            Console.WriteLine("Não é possível dividir por 0");
        }
        Console.WriteLine($"A subtração entre os números é: {num1 - num2}");
    }
}
