/*-------------------------------------------------------------------
Atividade 7: Experiência e Nível do Jogador após Batalha
• Contextualização: Em um jogo, o jogador enfrenta dois tipos diferentes de inimigos em uma
batalha. Cada tipo de inimigo concede uma quantidade específica de XP. Após a batalha, o
jogador ganha esse XP e precisa somá-lo ao XP total acumulado para determinar o nível atual
do personagem.
• Comando:Desenvolva um programa que receba a quantidade de XP acumulado, o XP concedido
pelo primeiro tipo de inimigo, o XP concedido pelo segundo tipo de inimigo, o número de cada
tipo de inimigo derrotado, e a constante de nível. O programa deve calcular o XP total
acumulado após a batalha e determinar o nível atual do jogador.
@Lista: 01 - Lógica de Programação
@Autor: Ana Vitoria
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main (string[] args)
    {
        int inim1, inim2;
        double  soma, xpAcumulado, xpConc1, xpConc2;

        Console.WriteLine("Quantos XP acumulados?");
        double.TryParse(Console.ReadLine(), out xpAcumulado);

        Console.WriteLine("XP inimigo");
        double.TryParse(Console.ReadLine(), out xpConc1);

        Console.WriteLine("Inimigos derrotados 1");
        int.TryParse(Console.ReadLine(), out inim1);

         Console.WriteLine("XP inimigo 2");
        double.TryParse(Console.ReadLine(), out xpConc2);

        Console.WriteLine("Inimigos derrotados 2");
        int.TryParse(Console.ReadLine(), out inim2);

        soma = (xpAcumulado + xpConc1 * inim1 + xpConc2 * inim2);

        Console.WriteLine($"Xp total: {soma}");

        Console.ReadLine();

    }
}