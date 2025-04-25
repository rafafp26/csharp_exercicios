using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string entrada = Console.ReadLine().ToLower();
        entrada = Regex.Replace(entrada, @"[^a-z0-9]", ""); 

        string reverso = new string(entrada.Reverse().ToArray());

        if (entrada == reverso)
            Console.WriteLine("É um palíndromo!");
        else
            Console.WriteLine("Não é um palíndromo.");
    }
}

