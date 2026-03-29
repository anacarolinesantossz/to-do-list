using System;
using System.Collections.Generic;
List<string> tarefas = new List<string>();
while (true)
{
    Console.WriteLine("\n--- To Do List ---");
    Console.WriteLine("1. Adicionar tarefa");
    Console.WriteLine("2. Listar tarefas");
    Console.WriteLine("3. Remover tarefa");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
    Console.Write("Digite a tarefa: ");
    string tarefa = Console.ReadLine();
    tarefas.Add(tarefa);
    Console.WriteLine("Tarefa adicionada!");
    break;
           case "2":
    Console.WriteLine("\nTarefas:");

    for (int i = 0; i < tarefas.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {tarefas[i]}");
    }

    break;
}
}
