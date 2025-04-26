// Gere um número aleatório entre 1 e 100. Peça que o usuário tente adivinhar. 
// Após cada tentativa, informe se o número é maior ou menor. 
// Conte o número de tentativas.

using System;

class Program
{
    static void Main(){
        Random Aleatorio = new Random(); 

        int numeroAleatorio = Aleatorio.Next(1, 101); 
        int tentativa;
        int numeroTentativas = 0;

        Console.WriteLine("Acerte o número entre 1 e 100.");

        do{

            Console.Write("Digite um número: ");
            tentativa = int.Parse(Console.ReadLine());

            numeroTentativas++;

            if(tentativa < numeroAleatorio){

                Console.WriteLine($"O número é maior do que {tentativa}.");}

            else if(tentativa > numeroAleatorio){

                Console.WriteLine($"O número é menor do que {tentativa}.");}

            else{

                Console.WriteLine($"Número correto. Um total de {numeroTentativas} tentativas para acertar.");}} 
                
        while(tentativa != numeroAleatorio);}}



