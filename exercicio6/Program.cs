// Crie uma classe Produto com propriedades Nome, Preço e Quantidade. Permita ao usuário cadastrar 3 produtos e 
// depois liste todos com o valor total em estoque (Preço * Quantidade).

using System;

class Produto{

    public string Nome {get; set;}

    public double Preco {get; set;}

    public int Quantidade {get; set;}

    public double ValorTotalEmEstoque(){

        return Preco * Quantidade;}}

class Program{
    static void Main(){

        Produto[] produtos = new Produto[3]; 

        for (int i = 0; i < 3; i++){

            produtos[i] = new Produto();

            Console.WriteLine($"Cadastro do Produto {i + 1}:");

            Console.Write("Digite o nome do produto: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade do produto: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();}

        Console.WriteLine("\nProdutos cadastrados:");

        for (int i = 0; i < 3; i++){

            double valorTotal = produtos[i].ValorTotalEmEstoque();

            Console.WriteLine($"Produto: {produtos[i].Nome}, Preço: R${produtos[i].Preco:F2}, Quantidade: {produtos[i].Quantidade}, Valor total em estoque: R${valorTotal:F2}");}}}

