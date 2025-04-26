# Trabalho Prático – Lógica de Programação em C# #

Participantes:
- Thyago Almeida Paulo
- Caio Soares
- Rafael Fernandes

<br>

### Questão 1 (Resolvida):
Fizemos um programa que pede uma senha e usa verificações com if e expressões regulares para checar se ela tem pelo menos 8 caracteres, uma letra maiúscula, um número e um caractere especial. Se passar em todas as condições, a senha é válida; se não, ele avisa que não atende aos requisitos.

<br>

## Explicação detalhada da resolução questão 2:

QUESTÃO: Solicite ao usuário um número e imprima a tabuada completa dele (de 1 a 10), com for.

````Csharp
using System;

class Program{

    static void Main(){

        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
````

Mostra a frase “Digite um número:” na tela para o usuário pelo Console.Write, e o int.Parse(Console.ReadLine()); lê o que a pessoa digitou e transforma isso em número inteiro.

````Csharp
for (int i = 1; i <= 10; i++){

            Console.WriteLine($"{numero} x {i} = {numero * i}");}}}
````

Criamos uma repetição que vai de 1 até 10, i aumenta em 1 a cada volta. Console.WriteLine mostra na tela a multiplicação do número digitado com o valor atual de i. Exemplo: "5 x 2 = 10".

<br>

### Questão 3 (Resolvida):
Fizemos um programa que pede para o usuário digitar um número inteiro positivo e depois calcula o fatorial desse número usando um laço while. Se o número for negativo, ele avisa que o número é inválido e encerra o programa. O cálculo do fatorial vai multiplicando o número por todos os anteriores até chegar a 1. Começa com o resultado igual a 1 e a variável i em 1, e o while vai somando os valores até atingir o número informado. No final, o programa mostra o fatorial.

<br>

### Questão 4 (Resolvida):
Fizemos um programa que tem um menu com três opções: converter Celsius para Fahrenheit, converter Fahrenheit para Celsius ou sair. Ele fica rodando um laço while até o usuário escolher sair (opção 3). Dentro do laço, ele usa um switch para verificar o que o usuário escolheu. Se for a opção 1, ele pede a temperatura em Celsius, faz a conversão para Fahrenheit e mostra o resultado. Se for a opção 2, pede a temperatura em Fahrenheit, converte para Celsius e exibe. Se o usuário escolher a opção 3, ele sai. Se escolher qualquer outra opção, o programa avisa que é inválido e volta pro menu.

<br>

### Questão 5 (Resolvida):
Fizemos um programa que pede para o usuário digitar uma palavra ou frase e verifica se ela é um palíndromo (algo que pode ser lido da mesma forma de frente para trás e de trás para frente). Ele começa transformando tudo em minúsculas com o ToLower() para não se importar com maiúsculas ou minúsculas. Depois, usa uma expressão regular (Regex.Replace) para tirar espaços e pontuação (só vai considerar letras e números). Aí, ele inverte a frase com Reverse() e compara se a frase original é igual à invertida. Se for, o programa diz "É um palíndromo!", se não for, ele fala "Não é um palíndromo.".

<br>

### Questão 6 (Resolvida):
Fizemos um programa que cria uma classe Produto com três propriedades: Nome, Preço e Quantidade. O usuário é solicitado a cadastrar 3 produtos usando um laço for. Para cada produto, o programa pede o nome, o preço e a quantidade, e esses dados são armazenados em um array de objetos da classe Produto. Após o cadastro, o programa utiliza outro laço for para calcular e exibir o valor total em estoque de cada produto, que é obtido multiplicando o preço pela quantidade. A saída apresenta o nome, preço, quantidade e valor total de cada produto.

<br>

## Explicação detalhada da resolução da questão 7:

QUESTÃO: Peça ao usuário 10 números e armazene em um array. Depois, calcule a soma apenas dos números pares.

````Csharp
using System;

class Program{
    static void Main(){

        int[] numeros = new int[10];
        int soma = 0;
````

Atraves do int[] guardamos os números digitados. A variável chamada soma começa com 0 porque será usada para guardar o total dos números pares.

````Csharp
for (int i = 0; i < 10; i++){

            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
````

Criamos uma repetição que vai de 1 até 10, i aumenta em 1 a cada volta. O Console.Write mostra qual número está sendo pedido para digitar (de 1 até 10), precisamos somar i com 1 porque ele começa com o valor 0, e queremos iniciar com 1. Em seguida, int.Parse(Console.ReadLine()); lê o número digitado pelo usuário, transforma em inteiro, e guarda na lista.

````Csharp
if(numeros[i] % 2 == 0)

                soma += numeros[i];}

        Console.WriteLine($"Soma dos pares: {soma}");}}
````

o if verifica se o número é par. Se o número for par, ele é somado ao total da variável soma. E depois de todos os números digitados, mostra a soma de todos os números pares através da variável.

<br>

### Questão 8 (Resolvida):
Fizemos um programa que solicita ao usuário o peso e a altura utilizando Console.ReadLine(). Em seguida, o IMC é calculado com a fórmula IMC = peso / (altura * altura). Para classificar o IMC, o programa usa uma série de instruções if: se o IMC for menor que 18.5, exibe "Abaixo do peso"; se estiver entre 18.5 e 24.9, exibe "Peso normal"; se estiver entre 25 e 29.9, exibe "Sobrepeso"; e se for 30 ou mais, exibe "Obesidade". O programa então exibe o IMC calculado e a classificação correspondente.

<br>

### Questão 9 (Resolvida):
Fizemos um programa que usa o Random para gerar um número aleatório entre 1 e 100. Ele então entra em um do-while onde pede o número do usuário e compara com o sorteado usando if e else. Se o número for maior ou menor, ele avisa e continua pedindo até o usuário acertar. O número de tentativas é contado com uma variável e mostrado no final.

<br>

### Questão 10 (Resolvida):
Fizemos um programa que começa perguntando se o usuário quer adicionar uma tarefa. Se ele responder "sim", entra no while, onde ele pode digitar a tarefa, que é adicionada à lista com o método .Add(). O for é usado para listar todas as tarefas depois que o usuário parar de adicionar. Em seguida, o programa pergunta se o usuário quer marcar alguma tarefa como concluída. Se ele disser "sim", um while é usado novamente para permitir que ele digite o número da tarefa. Aqui, o if verifica se o número digitado é válido, ou seja, se está dentro da lista de tarefas. Se for válido, a tarefa é atualizada com " - Concluída". O for é usado novamente para mostrar a lista atualizada de tarefas. O while garante que o usuário possa continuar até decidir sair.
