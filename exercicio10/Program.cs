// Permita que o usuário adicione tarefas a uma lista e, ao final, mostre todas as tarefas inseridas. 
// Use List<string> e ofereça uma opção para marcar tarefas como concluídas.

using System;
using System.Collections.Generic;

class Program{
    static void Main(){

        List<string> tarefas = new List<string>(); 
        string tarefa;
        string opcao;

        Console.WriteLine("Deseja adicionar uma tarefa? 1 - Sim, 2 - Não");
        opcao = Console.ReadLine();

        while (opcao == "1"){

            Console.WriteLine("Digite uma tarefa: ");
            tarefa = Console.ReadLine();
            tarefas.Add(tarefa);

            Console.WriteLine("Deseja adicionar outra tarefa? 1 - Sim, 2 - Não");
            opcao = Console.ReadLine();}

        if (tarefas.Count == 0){
            
            Console.WriteLine("\nNenhuma tarefa foi adicionada.");
            
            return;}

        Console.WriteLine("\nLista de Tarefas:");

        for(int i = 0; i < tarefas.Count; i++){

            Console.WriteLine($"{i + 1}. {tarefas[i]}");}

        Console.WriteLine("\nDeseja marcar alguma tarefa como concluída? 1 - Sim, 2 - Não");
        opcao = Console.ReadLine();

        while (opcao == "1"){
            
            Console.WriteLine("Digite o número da tarefa que você deseja marcar como concluída: ");
            string input = Console.ReadLine();
            int numeroTarefa;

            if (int.TryParse(input, out numeroTarefa) && numeroTarefa >= 1 && numeroTarefa <= tarefas.Count){
                
                tarefas[numeroTarefa - 1] += " - Concluída";}

            else{

                Console.WriteLine("Opção inválida.");}

            Console.WriteLine("\nLista atualizada de Tarefas:");

            for (int i = 0; i < tarefas.Count; i++){
                
                Console.WriteLine($"{i + 1}. {tarefas[i]}");}

                Console.WriteLine("\nDeseja marcar outra tarefa como concluída? 1 - Sim, 2 - Não");
                opcao = Console.ReadLine();}

        Console.WriteLine("\nTarefas finais:");

        foreach (var t in tarefas){

            Console.WriteLine(t);}}}

