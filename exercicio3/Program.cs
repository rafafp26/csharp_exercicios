using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());
        int resultado = 1, i = 1;

        while (i <= numero)
        {
            resultado *= i;
            i++;
        }

        Console.WriteLine($"Fatorial de {numero} é {resultado}");
    }
}
