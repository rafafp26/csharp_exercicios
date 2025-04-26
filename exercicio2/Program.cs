// Solicite ao usuário um número e imprima a tabuada completa dele (de 1 a 10), utilizando um for.

using System;

class Program{

    static void Main(){

        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++){

            Console.WriteLine($"{numero} x {i} = {numero * i}");}}}
