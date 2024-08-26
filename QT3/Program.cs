/*-------------------------------------------------------------------
Questão 3: Cálculo de Vida Restante
• Contextualização: Durante um combate, o jogador recebe dano e a vida do personagem
diminui.
• Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de
regeneração, do atacado, e dois modificadores, do atacante, (um para equipamentos e outro
para habilidades), e calcule a vida restante.

@Lista: 01 - Lógica de Programação
@Autor: Ana Vitoria 
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Program 
{
    static void Main(string[] args)
    {
        Double vida, danos, bonus, modoequipamentos, modohabilidades;

        Console.WriteLine("Qual a vida inicial? ");
        Double.TryParse(Console.ReadLine(), out vida);

        Console.WriteLine("Quantos danos recebidos? ");
        Double.TryParse(Console.ReadLine(), out danos);

        Console.WriteLine("Quantos bonus por regeração? ");
        Double.TryParse(Console.ReadLine(), out bonus);

        Console.WriteLine("Quantos Modificador de Equipamentos? ");
        Double.TryParse(Console.ReadLine(), out modoequipamentos);

        Console.WriteLine("Quantos Modificadores de Habilidades? ");
        Double.TryParse(Console.ReadLine(), out modohabilidades);

        Double Soma = ((vida - danos * modoequipamentos) + bonus * modohabilidades);
        Console.WriteLine($"Vida Restante: {Soma}");

        Console.ReadLine();
        }

}