// Solicite o peso (kg) e altura (m) do usuário, calcule o IMC e informe a classificação:
// Abaixo de 18.5: Abaixo do peso
// 18.5 a 24.9: Peso normal
// 25 a 29.9: Sobrepeso
// 30 ou mais: Obesidade

using System;

class Program{
    static void Main(){
       
        Console.Write("Digite seu peso: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite sua altura: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine($"Seu IMC é: {imc:F2}");

        if (imc < 18.5){
            
            Console.WriteLine("Abaixo do peso");}
        
        else if (imc >= 18.5 && imc < 25){
            
            Console.WriteLine("Peso normal");}
        
        else if (imc >= 25 && imc < 30){
            
            Console.WriteLine("Sobrepeso");}
        
        else{
            
            Console.WriteLine("Obesidade");}}}

