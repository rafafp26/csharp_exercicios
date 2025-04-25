using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma senha: ");
        string senha = Console.ReadLine();

        bool tamanho = senha.Length >= 8;
        bool temMaiuscula = Regex.IsMatch(senha, "[A-Z]");
        bool temNumero = Regex.IsMatch(senha, "[0-9]");
        bool temEspecial = Regex.IsMatch(senha, "[!@#$%^&*(),.?\":{}|<>]");

        if (tamanho && temMaiuscula && temNumero && temEspecial)
            Console.WriteLine("Senha valida!");
        else
            Console.WriteLine("Senha está faltando algum caracter especial!");
    }
}
