/*-------------------------------------------------------------------
Questão 4: Somatório de Moedas
• Contextualização: No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total
de moedas aumenta.
• Comando: Desenvolva um programa que receba cinco valores de moedas coletadas e some-os,
exibindo o total de moedas coletadas ao final.

@Lista: 01 - Lógica de Programação
@Autor: Ana Vitoria
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
{

    int moedas1, moedas2, moedas3, moedas4, moedas5, soma;

    Console.WriteLine("Quantas moedas coletadas na 1:");
    int.TryParse(Console.ReadLine(), out moedas1);
    
    Console.WriteLine("Quantas moedas coletadas na 2:");
    int.TryParse(Console.ReadLine(), out moedas2 );

    Console.WriteLine("Quantas moedas coletadas na 3:");
    int.TryParse(Console.ReadLine(), out moedas3);

    Console.WriteLine("Quantas moedas coletadas na 4:");
    int.TryParse(Console.ReadLine(), out moedas4);

    Console.WriteLine("Quantas moedas coletadas na 5:");
    int.TryParse(Console.ReadLine(), out moedas5);

     soma = (moedas1 + moedas2 + moedas3 + moedas4 + moedas5);

     Console.WriteLine($"total é:{soma}");
    
     
}
}
