// Peça ao usuário que digite uma senha e verifique se ela atende aos seguintes critérios:
// Mínimo de 8 caracteres
// Pelo menos uma letra maiúscula
// Pelo menos um número
// Pelo menos um caractere especial (ex: !, @, #)

using System;
using System.Text.RegularExpressions;

class Program{
    static void Main(){

        Console.Write("Digite uma senha: ");
        string senha = Console.ReadLine();

        bool tamanho = senha.Length >= 8;
        bool temMaiuscula = Regex.IsMatch(senha, "[A-Z]");
        bool temNumero = Regex.IsMatch(senha, "[0-9]");
        bool temEspecial = Regex.IsMatch(senha, "[!@#$%^&*(),.?\":{}|<>]");

        if(tamanho && temMaiuscula && temNumero && temEspecial){

            Console.WriteLine("Senha válida!");}

        else{

            Console.WriteLine("Senha não atende aos requisitos!");}}}
