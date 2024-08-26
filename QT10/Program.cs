/*-------------------------------------------------------------------
Questão 10: Atualização de Pontos de Vida
• Contextualização: Em um jogo de estratégia, um personagem pode ganhar pontos de vida a
cada nível alcançado.
• Comando: Desenvolva um programa que receba os pontos de vida iniciais e o aumento de vida
por nível, e calcule a quantidade de pontos de vida após alcançar um novo nível.
@Lista: 01 - Lógica de Programação
@Autor: Ana Vitoria
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
{

    int pontosInicias, aumento, nivel, soma; 

    Console.WriteLine("Quantos pontos inicias:");
    int.TryParse(Console.ReadLine(), out pontosInicias );

     Console.WriteLine("Quantos aumento por nivel:");
    int.TryParse(Console.ReadLine(), out aumento );

     Console.WriteLine("Quantos niveis alcançados:");
    int.TryParse(Console.ReadLine(), out nivel );

    soma = ((aumento * nivel) + pontosInicias);

    Console.WriteLine($"Os pontos finais são : {soma}"); 
}

}
