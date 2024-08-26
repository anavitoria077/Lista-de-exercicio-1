/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir
as informações básicas do personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.

@Lista: 01 - Lógica de Programação
@Autor: Ana Vitoria
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main()
    {  

        Console.WriteLine("Qual o seu nome?");
        string nome = Console.ReadLine();

        Console.WriteLine("Qual a sua Idade?");
        int idade;
        int.TryParse(Console.ReadLine(), out idade);

        Console.WriteLine("Qual seu nivel inicial?");
        int nivel;
        int.TryParse(Console.ReadLine(),out nivel);

        Console.WriteLine("Qual a sua classe?");
        string classe = Console.ReadLine();
        
        Console.WriteLine("Qual a sua raça?");
        string raça = Console.ReadLine();

        Console.WriteLine("");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Nivel: " + nivel);
        Console.WriteLine("Classe: " + classe);
        Console.WriteLine("Raça: " + raça);

        Console.WriteLine("\nPressione enter para fechar ");
        Console.ReadLine();
        

    }
}